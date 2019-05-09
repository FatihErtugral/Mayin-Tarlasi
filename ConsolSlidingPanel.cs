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
            pnl.Height     = location_X_Start;
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
            if (hidden)
            {
                Consol.Show();
                ChangeSize(+10);
            }
            else
            {
                Consol.Hide();
                ChangeSize(-10);
            }
        }

        private void ChangeSize(int val)
        {
            Consol.Height += val;

            if(Consol.Height <= Xstart || Consol.Height >= Xend)
            {
                tmr.Stop();
                hidden = !hidden;
            }
        }
    }
}
