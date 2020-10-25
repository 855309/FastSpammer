using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastSpammer
{
    public partial class SpamWindow : Form
    {
        public static int delaytime = 500;

        public SpamWindow()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            delaytime = trackBar1.Value;
            mslabel.Text = trackBar1.Value.ToString() + " ms";
            spamtimer.Interval = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startbutton.Enabled = false;
            stopbutton.Enabled = true;
            trackBar1.Enabled = false;
            clearbutton.Enabled = false;
            textBox1.ReadOnly = true;
            exitbutton.Enabled = false;
            spamtimer.Start();
        }

        private void spamtimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            startbutton.Enabled = true;
            stopbutton.Enabled = false;
            trackBar1.Enabled = true;
            clearbutton.Enabled = true;
            textBox1.ReadOnly = false;
            exitbutton.Enabled = true;
            spamtimer.Stop();
        }
    }
}
