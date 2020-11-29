using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Globalization;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Net;

namespace SoftSynth
{
    public partial class Synth : Form
    {
        internal const int SAMPLE_RATE = 44100;
        internal const short BITS_PER_SAMPLE = 16;
        internal float frequency = 0;

        public Synth()
        {
            InitializeComponent();
            Oscillator Oscillator = new Oscillator();
        }

        private void SoftSynth_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // c4-c5
                case Keys.Z:
                    frequency = 261.62f;    //c4
                    break;
                case Keys.S:
                    frequency = 277.18f;    // c#4
                    break;
                case Keys.X:
                    frequency = 293.66f;     // d4
                    break;
                case Keys.D:
                    frequency = 311.13f;    // d#4
                    break;
                case Keys.C:
                    frequency = 329.63f;    // e4
                    break;
                case Keys.V:
                    frequency = 349.23f;    // f4
                    break;
                case Keys.G:
                    frequency = 369.99f;    // f#4
                    break;
                case Keys.B:
                    frequency = 392.00f;    // g4
                    break;
                case Keys.H:
                    frequency = 415.30f;    // g#4
                    break;
                case Keys.N:
                    frequency = 440.00f;    // a4
                    break;
                case Keys.J:
                    frequency = 466.16f;    //a#4
                    break;
                case Keys.M:
                    frequency = 493.88f;    // b4
                    break;
                case Keys.Q:
                    frequency = 523.25f;    // c5
                    break;
                case Keys.D2:
                    frequency = 554.37f;    // c#5
                    break;
                case Keys.W:
                    frequency = 587.33f;    // d5
                    break;
                case Keys.D3:
                    frequency = 622.25f;    // d#5
                    break;
                case Keys.E:
                    frequency = 659.25f;    // e5
                    break;
                case Keys.R:
                    frequency = 698.46f;    // f5
                    break;
                case Keys.D5:
                    frequency = 739.99f;    // f#5
                    break;
                case Keys.T:
                    frequency = 783.99f;    // g5
                    break;
                case Keys.D6:
                    frequency = 830.61f;    // g#5
                    break;
                case Keys.Y:
                    frequency = 880.00f;    // a5
                    break;
                case Keys.D7:
                    frequency = 932.33f;    // a#5
                    break;
                case Keys.U:
                    frequency = 987.77f;    // b5
                    break;
                case Keys.I:
                    frequency = 1046.50f;   // c6
                    break;
                case Keys.D9:
                    frequency = 1108.73f;    // c#6
                    break;
                case Keys.O:
                    frequency = 1174.66f;   // d6
                    break;
                case Keys.D0:
                    frequency = 1244.51f;   // d#6
                    break;
                case Keys.P:
                    frequency = 1318.51f;   // e6
                    break;
                default:
                    frequency = 0;
                    break;
            }
            
            makeSoundWave();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Frequencies freq = new Frequencies();
            if (sender.Equals(button1))
                frequency = freq.get(0);
            else if (sender.Equals(button36))
                frequency = freq.get(1);
            else if (sender.Equals(button2))
                frequency = freq.get(2);
            else if (sender.Equals(button37))
                frequency = freq.get(3);
            else if (sender.Equals(button3))
                frequency = freq.get(4);
            else if (sender.Equals(button4))
                frequency = freq.get(5);
            else if (sender.Equals(button38))
                frequency = freq.get(6);
            else if (sender.Equals(button5))
                frequency = freq.get(7);
            else if (sender.Equals(button39))
                frequency = freq.get(8);
            else if (sender.Equals(button6))
                frequency = freq.get(9);
            else if (sender.Equals(button40))
                frequency = freq.get(10);
            else if (sender.Equals(button7))
                frequency = freq.get(11);
            else if (sender.Equals(button8))
                frequency = freq.get(12);
            else if (sender.Equals(button41))
                frequency = freq.get(13);
            else if (sender.Equals(button9))
                frequency = freq.get(14);
            else if (sender.Equals(button42))
                frequency = freq.get(15);
            else if (sender.Equals(button10))
                frequency = freq.get(16);
            else if (sender.Equals(button11))
                frequency = freq.get(17);
            else if (sender.Equals(button43))
                frequency = freq.get(18);
            else if (sender.Equals(button12))
                frequency = freq.get(19);
            else if (sender.Equals(button44))
                frequency = freq.get(20);
            else if (sender.Equals(button13))
                frequency = freq.get(21);
            else if (sender.Equals(button45))
                frequency = freq.get(22);
            else if (sender.Equals(button14))
                frequency = freq.get(23);
            else if (sender.Equals(button15))
                frequency = freq.get(24); // c_5
            else if (sender.Equals(button46))
                frequency = freq.get(25);
            else if (sender.Equals(button16))
                frequency = freq.get(26);
            else if (sender.Equals(button47))
                frequency = freq.get(27);
            else if (sender.Equals(button17))
                frequency = freq.get(28);
            else if (sender.Equals(button18))
                frequency = freq.get(29);
            else if (sender.Equals(button48))
                frequency = freq.get(30);
            else if (sender.Equals(button19))
                frequency = freq.get(31);
            else if (sender.Equals(button49))
                frequency = freq.get(32);
            else if (sender.Equals(button20))
                frequency = freq.get(33);
            else if (sender.Equals(button50))
                frequency = freq.get(34);
            else if (sender.Equals(button21))
                frequency = freq.get(35);
            else if (sender.Equals(button22))
                frequency = freq.get(36); //c_6
            else if (sender.Equals(button51))
                frequency = freq.get(37);
            else if (sender.Equals(button23))
                frequency = freq.get(38);
            else if (sender.Equals(button52))
                frequency = freq.get(39);
            else if (sender.Equals(button24))
                frequency = freq.get(40);
            else if (sender.Equals(button25))
                frequency = freq.get(41);
            else if (sender.Equals(button53))
                frequency = freq.get(42);
            else if (sender.Equals(button26))
                frequency = freq.get(43);
            else if (sender.Equals(button54))
                frequency = freq.get(44);
            else if (sender.Equals(button27))
                frequency = freq.get(45);
            else if (sender.Equals(button55))
                frequency = freq.get(46);
            else if (sender.Equals(button28))
                frequency = freq.get(47);
            else if (sender.Equals(button29))
                frequency = freq.get(48); //c_7
            else if (sender.Equals(button56))
                frequency = freq.get(49);
            else if (sender.Equals(button30))
                frequency = freq.get(50);
            else if (sender.Equals(button57))
                frequency = freq.get(51);
            else if (sender.Equals(button31))
                frequency = freq.get(52);
            else if (sender.Equals(button32))
                frequency = freq.get(53);
            else if (sender.Equals(button58))
                frequency = freq.get(54);
            else if (sender.Equals(button33))
                frequency = freq.get(55);
            else if (sender.Equals(button59))
                frequency = freq.get(56);
            else if (sender.Equals(button34))
                frequency = freq.get(57);
            else if (sender.Equals(button60))
                frequency = freq.get(58);
            else if (sender.Equals(button35))
                frequency = freq.get(59);
            else if (sender.Equals(button36))
                frequency = freq.get(60); //c_8
            else
                frequency = 0f;
            makeSoundWave();
        }

        private void makeSoundWave()
        {
            short[] wave = new short[SAMPLE_RATE];  // one second of audio 

            IEnumerable<Oscillator> oscillators = this.Controls.OfType<Oscillator>();
            IEnumerable<Sample> sampleRate = this.Controls.OfType<Sample>();
            int oscCount = oscillators.Count();
            byte[] binaryWave = new byte[SAMPLE_RATE * sizeof(short)];
            Random random = new Random();

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
                            wave[i] += Convert.ToInt16((short.MaxValue * Math.Sign(Math.Sin((Math.PI * 2 * frequency) / SAMPLE_RATE * i))) / oscCount);
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
                    case WaveForm.Octave:
                        for (int i = 0; i < SAMPLE_RATE; i++)
                        {
                            wave[i] += Convert.ToInt16((short.MaxValue * Math.Sin(((Math.PI * 3 * frequency) / SAMPLE_RATE) * i)) / oscCount);
                        }
                        break;
                }
            }
            Sound sound = new Sound(wave, binaryWave);
            sound.Play();
        }

    }
    public enum WaveForm
    {
        Sine, Square, Saw, Triangle, Noise, Octave
    }
} 