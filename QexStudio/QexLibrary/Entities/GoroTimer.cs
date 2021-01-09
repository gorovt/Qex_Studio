using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Qex
{
    public static class GoroTimer
    {
        static System.Timers.Timer _timer;
        static ToolStripStatusLabel _label1;
        static ToolStripStatusLabel _label2;

        public static void Start(ToolStripStatusLabel label1, ToolStripStatusLabel label2)
        {
            _label1 = label1;
            _label2 = label2;
            _timer = new System.Timers.Timer(3000); // Set up the timer for 3 seconds
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Enabled = true; // Enable it
        }
        public static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _label1.Image = null;
            _label2.Text = "";
        }
    }
}
