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
using System.Windows.Input;

namespace SoftSynth
{
    public partial class Synth : Form
    {
        internal const int SAMPLE_RATE = 44100;
        internal const short BITS_PER_SAMPLE = 16;
        internal float frequency = 0;
        internal bool toggle = false;

        public Synth()
        {

            InitializeComponent();
            Oscillator Oscillator = new Oscillator();

        }

        private void SoftSynth_KeyDown(object sender, KeyEventArgs e)
        {
            Frequencies freq = new Frequencies();

            switch (e.KeyCode)
            {
                // c4-c5
                case Keys.Z:
                    if (toggle)
                    {
                        frequency = freq.get(30);
                        button18.Select();

                    } else
                    {
                        frequency = freq.get(1);    //c4
                        button1.Select();
                    }
                    break;
                case Keys.S:
                    if (toggle)
                    {
                        frequency = freq.get(31);
                        button48.Select();
                    } else
                    {
                        frequency = freq.get(2);    // c#4
                        button36.Select();
                    }
                    break;
                case Keys.X:
                    if (toggle)
                    {
                        frequency = freq.get(32);
                        button19.Select();
                    }
                    else
                    {
                        frequency = freq.get(3);     // d4
                        button2.Select();
                    }
                    break;
                case Keys.D:
                    if (toggle)
                    {
                        frequency = freq.get(33);
                        button49.Select();
                    } else
                    {
                        frequency = freq.get(4);    // d#4
                        button37.Select();
                    }
                    break;
                case Keys.C:
                    if (toggle)
                    {
                        frequency = freq.get(34);
                        button20.Select();
                    } else
                    {
                        frequency = freq.get(5);    // e4
                        button3.Select();
                    }
                    break;
                case Keys.V:
                    if (toggle)
                    {
                        frequency = freq.get(35);
                        button21.Select();
                    } 
                    else
                    {
                        frequency = freq.get(6);    // f4
                        button4.Select();
                    }
                    break;
                case Keys.G:
                    if (toggle)
                    {
                        frequency = freq.get(36);
                        button50.Select();
                    } 
                    else
                    {
                        frequency = freq.get(7);    // f#4
                        button38.Select();
                    }
                    break;
                case Keys.B:
                    if (toggle)
                    {
                        frequency = freq.get(37);
                        button22.Select();
                    } 
                    else
                    {
                        frequency = freq.get(8);    // g4
                        button5.Select();
                    }
                    break;
                case Keys.H:
                    if (toggle)
                    {
                        frequency = freq.get(38);
                        button51.Select();
                    }
                    else
                    {
                        frequency = freq.get(9);    // g#4
                        button39.Select();
                    }
                    break;
                case Keys.N:
                    if (toggle)
                    {
                        frequency = freq.get(39);
                        button23.Select();
                    } 
                    else
                    {
                        frequency = freq.get(10);    // a4
                        button6.Select();
                    }
                    break;
                case Keys.J:
                    if (toggle)
                    {
                        frequency = freq.get(40);
                        button52.Select();
                    } 
                    else
                    {
                        frequency = freq.get(11);    //a#4
                        button40.Select();
                    }
                    break;
                case Keys.M:
                    if (toggle)
                    {
                        frequency = freq.get(41);
                        button24.Select();
                    } 
                    else
                    {
                        frequency = freq.get(12);    // b4
                        button7.Select();
                    }
                    break;
                case Keys.Q:
                    if (toggle)
                    {
                        frequency = freq.get(42);
                        button25.Select();
                    }
                    else
                    {
                        frequency = freq.get(13);    // c5
                        button8.Select();
                    }
                    break;
                case Keys.D2:
                    if (toggle)
                    {
                        frequency = freq.get(43);
                        button53.Select();
                    } 
                    else
                    {
                        frequency = freq.get(14);    // c#5
                        button41.Select();
                    }
                    break;
                case Keys.W:
                    if (toggle)
                    {
                        frequency = freq.get(44);
                        button26.Select();
                    } 
                    else
                    {
                        frequency = freq.get(15);    // d5
                        button9.Select();
                    }
                    break;
                case Keys.D3:
                    if (toggle)
                    {
                        frequency = freq.get(45);
                        button54.Select();
                    } 
                    else
                    {
                        frequency = freq.get(16);    // d#5
                        button42.Select();
                    }
                    break;
                case Keys.E:
                    if (toggle)
                    {
                        frequency = freq.get(46);
                        button27.Select();
                    }
                    else
                    {
                        frequency = freq.get(17);    // e5
                        button10.Select();
                    }
                    break;
                case Keys.R:
                    if (toggle)
                    {
                        frequency = freq.get(47);
                        button28.Select();
                    }
                    else
                    {
                        frequency = freq.get(18);    // f5
                        button11.Select();
                    }
                    break;
                case Keys.D5:
                    if (toggle)
                    {
                        frequency = freq.get(48);
                        button55.Select();
                    }
                    else
                    {
                        frequency = freq.get(19);   // f#5
                        button43.Select();
                    }
                    break;
                case Keys.T:
                    if (toggle)
                    {
                        frequency = freq.get(49);
                        button29.Select();
                    }
                    else
                    {
                        frequency = freq.get(20);    // g5
                        button12.Select();
                    }
                    break;
                case Keys.D6:
                    if (toggle)
                    {
                        frequency = freq.get(50);
                        button56.Select();
                    }
                    else
                    {
                        frequency = freq.get(21);    // g#5
                        button44.Select();
                    }
                    break;
                case Keys.Y:
                    if (toggle)
                    {
                        frequency = freq.get(51);
                        button30.Select();
                    }
                    else
                    {
                        frequency = freq.get(22);    // a5
                        button13.Select();
                    }
                    break;
                case Keys.D7:
                    if (toggle)
                    {
                        frequency = freq.get(52);
                        button57.Select();
                    }
                    else
                    {
                        frequency = freq.get(23);    // a#5
                        button45.Select();
                    }
                    break;
                case Keys.U:
                    if (toggle)
                    {
                        frequency = freq.get(53);
                        button31.Select();
                    }
                    else
                    {
                        frequency = freq.get(24);    // b5
                        button14.Select();
                    }
                    break;
                case Keys.I:
                    if (toggle)
                    {
                        frequency = freq.get(54);
                        button32.Select();
                    }
                    else
                    {
                        frequency = freq.get(25);   // c6
                        button15.Select();
                    }
                    break;
                case Keys.D9:
                    if (toggle)
                    {
                        frequency = freq.get(55);
                        button58.Select();
                    }
                    else
                    {
                        frequency = freq.get(26);    // c#6
                        button46.Select();
                    }
                    break;
                case Keys.O:
                    if (toggle)
                    {
                        frequency = freq.get(56);
                        button33.Select();
                    }
                    else
                    {
                        frequency = freq.get(27);   // d6
                        button16.Select();
                    }
                    break;
                case Keys.D0:
                    if (toggle)
                    {
                        frequency = freq.get(57);
                        button59.Select();
                    }
                    else
                    {
                        frequency = freq.get(28);   // d#6
                        button47.Select();
                    }
                    break;
                case Keys.P:
                    if (toggle)
                    {
                        frequency = freq.get(58);
                        button34.Select();
                    }
                    else
                    {
                        frequency = freq.get(29);   // e6
                        button17.Select();
                    }
                    break;
                case Keys.ShiftKey:
                    if (toggle == true)
                        this.toggle = false;
                    else 
                        this.toggle = true;
                    frequency = 0;
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