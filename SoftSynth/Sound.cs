using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SoftSynth
{
    public class Sound : Synth
    {
        private short[] wave;
        private byte[] binaryWave;
        public Sound(short[] wave, byte[] binaryWave) {
            this.wave = wave;
            this.binaryWave = binaryWave;
        }
        public void Play()
        {

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
}