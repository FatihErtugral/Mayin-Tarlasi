﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMayinTarlasi
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        #region Font Settings

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;
        #endregion


        GameCreate GAME;
        ConsolSlidingPanel GAMEConsol;
        ScoreSystem scoreSystem;
        private string playerName ="";
        private int second = 0;

        
        public FormMain()
        {
            
            GAME = GameCreate.GetInstance();
            scoreSystem = ScoreSystem.GetInstance();
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            #region Font Settings

            byte[]  fontData = Properties.Resources.Let_s_go_Digital_Regular;
            IntPtr  fontPtr  = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            uint    dummy   = 0;
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Let_s_go_Digital_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Let_s_go_Digital_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            myFont = new Font(fonts.Families[0], 14.25F);
            #endregion
            this.StyleManager = mainStyleManager;

            GAMEConsol = new ConsolSlidingPanel(ref pnlConsolMain, 0, 400);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblMayinSayisiDisplay.Font  = lblSkorDisplay.Font=
            lblTemizAlanDisplay.Font    = lblKalanSureDisplay.Font = myFont;
            this.Controls.Add(GAME.panelMap);
            GAME.panelMap.BackColor = Color.Black;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            pnlGameStart.Visible = false;
            GAME.panelMap.Hide();
            this.Refresh();
            #region Oyun zorluk derecesi
           
            if (toggleKolay.CheckState == CheckState.Checked)
            {
                GAME.Start(20, 20, 35); second = 120;
            }
            else if (toggleOrta.CheckState == CheckState.Checked)
            {
                GAME.Start(30, 20, 55);  second = 180;
            }
            else if (toggleZor.CheckState == CheckState.Checked)
            {
                GAME.Start(50, 20, 200); second = 250;
            }
            Refresh();
            #endregion
            this.Width  = (GAME.panelMap.Width + 32)  < 228 ? 228 : (GAME.panelMap.Width + 32);
            Refresh();
            this.Height = GAME.panelMap.Height + 183;
            Refresh();
            WindowPosition();
            Refresh();
            pnlSkorBoard.Visible = true;
            Refresh();
            playerName = (txtBoxTakmaIsim.Text == "" ) ? "-" : txtBoxTakmaIsim.Text;
            Refresh();
            
            GAME.panelMap.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            if (second == 0) //lost time is over
            {
                scoreSystem.Add(playerName, GAME.score);
                timer1.Stop();
                ScoreBoard();
                WindowStartupSettings();    
                return;
            }

            lblSkorDisplay.Text      = ""+GAME.score;
            lblTemizAlanDisplay.Text = ""+GAME.gameBtnEmptyNum;
            lblKalanSureDisplay.Text = ""+second;
            lblMayinSayisiDisplay.Text = ""+ GAME.gameBtnMineNum;

            if (GAME.gameBtnEmptyNum == 0) // Win
            {
                scoreSystem.Add(playerName, GAME.score); 
                timer1.Stop();
                ScoreBoard();
                WindowStartupSettings();
                return;
            }
            if (GAME.lose) // Game over
            {
                scoreSystem.Add(playerName, GAME.score);
                timer1.Stop();
                 ScoreBoard();
                WindowStartupSettings();
                return;
            }
        }

        private void WindowPosition()
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 4);
        }

        private void WindowStartupSettings()
        {
            timer1.Stop();
            GAME.Clear();
            Refresh();
            txtBoxTakmaIsim.Text = "";
            lblSkorDisplay.Text      =
            lblTemizAlanDisplay.Text =
            lblKalanSureDisplay.Text = "0";

            pnlSkorBoard.Visible   = false;
            this.Refresh();
            pnlGameStart.Visible  = true;
            txtBoxTakmaIsim.Focus();
        }


        private void toggleKolay_Click(object sender, EventArgs e)
        {
            toggleKolay.CheckState = CheckState.Checked;
            toggleOrta.CheckState = CheckState.Unchecked;
            toggleZor.CheckState = CheckState.Unchecked;
        }

        private void toggleOrta_Click(object sender, EventArgs e)
        {
            toggleKolay.CheckState = CheckState.Unchecked;
            toggleOrta.CheckState = CheckState.Checked;
            toggleZor.CheckState = CheckState.Unchecked;
        }

        private void toggleZor_Click(object sender, EventArgs e)
        {
            toggleKolay.CheckState = CheckState.Unchecked;
            toggleOrta.CheckState = CheckState.Unchecked;
            toggleZor.CheckState = CheckState.Checked;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBxTakmaIsim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnBaslat_Click(this, new EventArgs());
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowStartupSettings();
        }

        private void txtBoxConsoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtBoxConsoleBody.Text   += txtBoxConsoleInput.Text + "\n";
                switch(txtBoxConsoleInput.Text){
                    case "help" :
                        txtBoxConsoleBody.Text += 
                                    "print array    => iki boyutlu diziyi yazdırır, 9'lar mayınları temsil eder\n"+
                                    "bomb           => Bütün mayınları aktif-pasif yap.\n"+
                                    "clear          => Ekranı temizle.\n"+
                                    "exit           => Oyundan çık.\n";
                        break;
                    case "print array": txtBoxConsoleBody.Text += GAME.MapMatrixToString(); break;
                    case "bomb": GAME.MineToggleLock(); break;
                    case "clear": txtBoxConsoleBody.Text = ""; break;
                    case "exit": this.Close(); return;
                    default: break;
                }
                txtBoxConsoleInput.Text   = "";
                txtBoxConsoleBody.SelectionStart = txtBoxConsoleBody.TextLength;
                txtBoxConsoleBody.ScrollToCaret();
            }
        }

        private void txtBoxConsoleInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"')
            {
                e.Handled = true;
                return;
            }
            e.Handled=false;
            return;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"')
            {
                pnlConsolMain.Width = this.Width;
                GAMEConsol.ToggleOpenClose();
                if (pnlConsolMain.Visible)
                {
                    txtBoxConsoleInput.Focus();
                }
                Refresh();
                return;
            }
        }

        private void ScoreBoard()
        {
            FormScoreBoard skrfrm = new FormScoreBoard
            {
                Owner = this,
                StyleManager = StyleManager,
                Theme = Theme,
                Style = Style
            };
            skrfrm.ShowDialog();
        }

        private void skorTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreBoard();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu.Show(btnMenu, 0, btnMenu.Height);
        }
    }
}
