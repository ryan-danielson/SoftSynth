using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SoftSynth
{
    public class Oscillator : GroupBox
    {
        public Oscillator()
        {
            this.Controls.Add(new Button()
            {
                Name = "Sine",
                Location = new Point(10, 15),
                Text = "Sine",
                BackColor = Color.DarkOliveGreen
            });

            this.Controls.Add(new Button()
            {
                Name = "Square",
                Location = new Point(80, 15),
                Text = "Square",
                BackColor = Color.White
            });

            this.Controls.Add(new Button()
            {
                Name = "Saw",
                Location = new Point(150, 15),
                Text = "Saw",
                BackColor = Color.White
            });

            this.Controls.Add(new Button()
            {
                Name = "Triangle",
                Location = new Point(10, 50),
                Text = "Triangle",
                BackColor = Color.White
            });

            this.Controls.Add(new Button()
            {
                Name = "Noise",
                Location = new Point(80, 50),
                Text = "Noise",
                BackColor = Color.White
            });

            this.Controls.Add(new Button()
            {
                Name = "Octave",
                Location = new Point(150, 50),
                Text = "Octave",
                BackColor = Color.White
            });

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Size = new Size(70, 30);
                    control.Font = new Font("Microsoft Sans Serif", 6.75f);
                    control.Click += WaveButton_Click;
                }
            }
        }
        public WaveForm WaveForm { get; private set; }
        private void WaveButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.WaveForm = (WaveForm)Enum.Parse(typeof(WaveForm), button.Text);
            foreach (Button otherButtons in this.Controls.OfType<Button>())
            {
                otherButtons.BackColor = Color.White;
            }
            button.BackColor = Color.DarkOliveGreen;
        }
    }
}
