using System;
using System.Windows.Forms;

namespace T7WeaponConverter
{

    public partial class Splash : Form
    {
        Timer tmr;
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 1000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            //after 1 sec stop the timer
            tmr.Stop();
            //display mainform
            Form1 mf = new Form1();
            mf.Show();
            //hide this form
            Hide();
        }
    }
}
