using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMayinTarlasi
{
    class ConsolSlidingPanel
    {
        private Panel   Consol;
        private Timer   tmr;
        private bool    hidden;
        private int     Xstart;
        private int     Xend;

        public ConsolSlidingPanel(ref Panel pnl, int location_X_Start, int location_X_End)
        {
            pnl.Top     = location_X_Start;
            this.Consol   = pnl;
            hidden      = true;
            Xstart      = location_X_Start;
            Xend        = location_X_End;
            tmr = new Timer
            {
                Interval = 1
            };
            tmr.Tick    += new EventHandler(t_tick); 
        }

        public void ToggleOpenClose()
        {
            tmr.Start();
        }

        private void t_tick(object sender, EventArgs e)
        {
            if (hidden) ChangeSize(+10);
            else        ChangeSize(-10);
        }

        private void ChangeSize(int val)
        {
            Consol.Top += val;

            if(Consol.Top <= Xstart || Consol.Top >= Xend)
            {
                tmr.Stop();
                hidden = !hidden;
            }
        }
    }
}
