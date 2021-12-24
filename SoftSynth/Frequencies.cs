using System;
namespace SoftSynth
{
	public class Frequencies
	{
		private float freq;
		
		private float[] frequencies = { 130.81f, 138.59f, 146.83f, 155.56f, 164.81f, 174.61f, 185.00f, 196.00f, 207.65f, 220.00f, 233.08f, 246.94f,
							261.63f, 277.18f, 293.66f, 311.13f, 329.63f, 349.23f, 369.99f, 392.00f, 415.30f, 440.00f, 466.16f, 493.88f,
							523.25f, 554.37f, 587.33f, 622.25f, 659.25f, 698.46f, 739.99f, 783.99f, 830.61f, 880.00f, 932.33f, 987.77f,
							1046.50f, 1108.73f, 1174.66f, 1244.51f, 1318.51f, 1396.91f, 1479.98f, 1567.98f, 1661.22f, 1760.00f, 1864.66f, 1975.53f,
							2093.00f, 2217.46f, 2349.32f, 2489.02f, 2637.02f, 2793.83f, 2959.96f, 3135.96f, 3322.44f, 3520.00f, 3729.31f, 3951,07f };
		public Frequencies()
        {

        }
		public Frequencies(int i)
		{
			this.freq = frequencies[i];
		}

		public float get(int i)
		{
			return frequencies[i];
		}
	}
		
}
