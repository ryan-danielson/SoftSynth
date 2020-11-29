using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SoftSynth
{
    public class Sound : Oscillator
    {
        private const int SAMPLE_RATE = 44100;
        private const short BITS_PER_SAMPLE = 16;
        private float frequency;
        private Sound(float freq)
        {
            this.frequency = freq;
        }

        private void playSound()
        {
            short[] wave = new short[SAMPLE_RATE];  // one second of audio 

            IEnumerable<Oscillator> oscillators = this.Controls.OfType<Oscillator>();
            int oscCount = oscillators.Count();
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)];
            Random random = new Random();

            //foreach (Oscillator oscillator in this.Controls.OfType<Oscillator>())
            foreach (Oscillator oscillator in oscillators)
            {
                short tempSample = 0;
                int samplesPerWaveLength = (int)(SAMPLE_RATE / frequency);
                short ampStep = (short)((short.MaxValue * 2) / samplesPerWaveLength);


                switch (oscillator.WaveForm)
                {
                    case WaveForm.Sine:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] += Convert.ToInt16((short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SAMPLE_RATE) * i)) / oscCount);
                        }
                        break;
                    case WaveForm.Square:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] += Convert.ToInt16((short.MaxValue * Math.Sign(Math.Sin((Math.PI * 2 * frequency) / SAMPLE_RATE) * i)) / oscCount);
                        }
                        break;
                    case WaveForm.Saw:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            tempSample = -short.MaxValue;
                            for (int k = 0; k < samplesPerWaveLength && i < SAMPLE_RATE; k++)
                            {
                                tempSample += ampStep;

                                wave[i++] += Convert.ToInt16(tempSample / oscCount);
                            }
                            i--;
                        }
                        break;
                    case WaveForm.Triangle:
                        tempSample -= short.MaxValue;
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            if (Math.Abs(tempSample + ampStep) > short.MaxValue)
                            {
                                ampStep = (short)-ampStep;
                            }
                            tempSample += ampStep;
                            wave[i] += Convert.ToInt16(tempSample / oscCount);
                        }
                        break;
                    case WaveForm.Noise:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] += Convert.ToInt16(random.Next(-short.MaxValue, short.MaxValue) / oscCount);
                        }
                        break;
                    case WaveForm.Piano:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] += Convert.ToInt16(Math.Sin(Math.PI * 2 * frequency * i) * Math.Exp(-0.0004 * 2 * Math.PI * frequency * i) / oscCount);
                        }
                        break;
                }
            }


            Buffer.BlockCopy(wave, 0, binaryWave, 0, wave.Length * sizeof(short));
            /* using Canonical WAVE format */
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream()) // contains all information created
            using (System.IO.BinaryWriter binaryWriter = new System.IO.BinaryWriter(memoryStream))
            {
                short blockAlign = BITS_PER_SAMPLE / 8;
                int subChunck2ID = SAMPLE_RATE * blockAlign;
                binaryWriter.Write(new[] { 'R', 'I', 'F', 'F' });
                binaryWriter.Write(36 + subChunck2ID);
                binaryWriter.Write(new[] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
                binaryWriter.Write(16);
                binaryWriter.Write((short)1);
                binaryWriter.Write((short)1);
                binaryWriter.Write(SAMPLE_RATE);
                binaryWriter.Write(SAMPLE_RATE * blockAlign);
                binaryWriter.Write(blockAlign);
                binaryWriter.Write(BITS_PER_SAMPLE);
                binaryWriter.Write(new[] { 'd', 'a', 't', 'a' });
                binaryWriter.Write(subChunck2ID);
                binaryWriter.Write(binaryWave);     /* converted with block copy */
                memoryStream.Position = 0;          /* set position to 0 to go to start and read RIFF */
                new SoundPlayer(memoryStream).Play();
            }   // write to stream
        }

    }


    public enum WaveForm
    {
        Sine, Square, Saw, Triangle, Noise, Piano
    }
}
}
