using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SoftSynth
{
    public class Sample : GroupBox
    {
        public Sample()
        {
            this.Controls.Add(new Button()
            {
                Name = "High",
                Location = new Point(10, 15),
                Text = "High",
                BackColor = Color.White
            }) ;

            this.Controls.Add(new Button()
            {
                Name = "Low",
                Location = new Point(80, 15),
                Text = "Low",
                BackColor = Color.White
            });
            foreach (Control control in this.Controls)
            {
                control.Size = new Size(50, 30);
                control.Font = new Font("Microsoft Sans Serif", 6.75f);
                control.Click += ArpButton_Click;
            }
        }
        public SampleSelect SampleSelect { get; private set; }

        private void ArpButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.SampleSelect = (SampleSelect)Enum.Parse(typeof(SampleSelect), button.Text);
            foreach (Button otherButtons in this.Controls.OfType<Button>())
            {
                otherButtons.BackColor = Color.White;
            }
            button.BackColor = Color.DarkOliveGreen;
        }
    }
}
