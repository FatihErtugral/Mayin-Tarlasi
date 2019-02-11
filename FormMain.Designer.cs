

namespace MMayinTarlasi
{
    partial class FormMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Menu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skorTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new MetroFramework.Controls.MetroButton();
            this.pnlTakmeIsimBaslat = new System.Windows.Forms.Panel();
            this.btnBaslat = new MetroFramework.Controls.MetroButton();
            this.txtBoxTakmaIsim = new MetroFramework.Controls.MetroTextBox();
            this.lblTakmeIsim = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblKolay = new MetroFramework.Controls.MetroLabel();
            this.toggleKolay = new MetroFramework.Controls.MetroToggle();
            this.lblOrta = new MetroFramework.Controls.MetroLabel();
            this.toggleOrta = new MetroFramework.Controls.MetroToggle();
            this.lblZor = new MetroFramework.Controls.MetroLabel();
            this.toggleZor = new MetroFramework.Controls.MetroToggle();
            this.pnlSkorBoard = new System.Windows.Forms.TableLayoutPanel();
            this.lblKalanSureDisplay = new System.Windows.Forms.Label();
            this.lblTemizAlanDisplay = new System.Windows.Forms.Label();
            this.lblSkorDisplay = new System.Windows.Forms.Label();
            this.lblMayinSayisiDisplay = new System.Windows.Forms.Label();
            this.lblTemizAlan = new MetroFramework.Controls.MetroLabel();
            this.lblKalanSure = new MetroFramework.Controls.MetroLabel();
            this.lblMayinSayisi = new MetroFramework.Controls.MetroLabel();
            this.lblSkor = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pnlGameStart = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlConsolMain = new System.Windows.Forms.Panel();
            this.txtBoxConsoleInput = new System.Windows.Forms.TextBox();
            this.txtBoxConsoleBody = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainStyleManager)).BeginInit();
            this.Menu.SuspendLayout();
            this.pnlTakmeIsimBaslat.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlSkorBoard.SuspendLayout();
            this.pnlGameStart.SuspendLayout();
            this.pnlConsolMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStyleManager
            // 
            this.mainStyleManager.Owner = this;
            this.mainStyleManager.Style = MetroFramework.MetroColorStyle.Red;
            this.mainStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.skorTablosuToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(142, 92);
            this.Menu.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenu_Opening);
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // skorTablosuToolStripMenuItem
            // 
            this.skorTablosuToolStripMenuItem.Name = "skorTablosuToolStripMenuItem";
            this.skorTablosuToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.skorTablosuToolStripMenuItem.Text = "Skor Tablosu";
            this.skorTablosuToolStripMenuItem.Click += new System.EventHandler(this.skorTablosuToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(24, 64);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 19);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseSelectable = true;
            this.btnMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseDown);
            // 
            // pnlTakmeIsimBaslat
            // 
            this.pnlTakmeIsimBaslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTakmeIsimBaslat.Controls.Add(this.btnBaslat);
            this.pnlTakmeIsimBaslat.Controls.Add(this.txtBoxTakmaIsim);
            this.pnlTakmeIsimBaslat.Controls.Add(this.lblTakmeIsim);
            this.pnlTakmeIsimBaslat.Location = new System.Drawing.Point(0, 0);
            this.pnlTakmeIsimBaslat.Name = "pnlTakmeIsimBaslat";
            this.pnlTakmeIsimBaslat.Size = new System.Drawing.Size(184, 80);
            this.pnlTakmeIsimBaslat.TabIndex = 2;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaslat.Location = new System.Drawing.Point(6, 55);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(172, 23);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseSelectable = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // txtBoxTakmaIsim
            // 
            this.txtBoxTakmaIsim.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtBoxTakmaIsim.CustomButton.Image = null;
            this.txtBoxTakmaIsim.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtBoxTakmaIsim.CustomButton.Name = "";
            this.txtBoxTakmaIsim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxTakmaIsim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxTakmaIsim.CustomButton.TabIndex = 1;
            this.txtBoxTakmaIsim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxTakmaIsim.CustomButton.UseSelectable = true;
            this.txtBoxTakmaIsim.CustomButton.Visible = false;
            this.txtBoxTakmaIsim.Lines = new string[0];
            this.txtBoxTakmaIsim.Location = new System.Drawing.Point(6, 25);
            this.txtBoxTakmaIsim.MaxLength = 32767;
            this.txtBoxTakmaIsim.Name = "txtBoxTakmaIsim";
            this.txtBoxTakmaIsim.PasswordChar = '\0';
            this.txtBoxTakmaIsim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxTakmaIsim.SelectedText = "";
            this.txtBoxTakmaIsim.SelectionLength = 0;
            this.txtBoxTakmaIsim.SelectionStart = 0;
            this.txtBoxTakmaIsim.ShortcutsEnabled = true;
            this.txtBoxTakmaIsim.Size = new System.Drawing.Size(172, 23);
            this.txtBoxTakmaIsim.TabIndex = 1;
            this.txtBoxTakmaIsim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTakmaIsim.UseSelectable = true;
            this.txtBoxTakmaIsim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxTakmaIsim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxTakmaIsim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTakmaIsim_KeyDown);
            // 
            // lblTakmeIsim
            // 
            this.lblTakmeIsim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTakmeIsim.AutoSize = true;
            this.lblTakmeIsim.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTakmeIsim.Location = new System.Drawing.Point(6, 2);
            this.lblTakmeIsim.Name = "lblTakmeIsim";
            this.lblTakmeIsim.Size = new System.Drawing.Size(78, 19);
            this.lblTakmeIsim.TabIndex = 0;
            this.lblTakmeIsim.Text = "Takma isim:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.lblKolay);
            this.flowLayoutPanel1.Controls.Add(this.toggleKolay);
            this.flowLayoutPanel1.Controls.Add(this.lblOrta);
            this.flowLayoutPanel1.Controls.Add(this.toggleOrta);
            this.flowLayoutPanel1.Controls.Add(this.lblZor);
            this.flowLayoutPanel1.Controls.Add(this.toggleZor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(112, 72);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblKolay
            // 
            this.lblKolay.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKolay.Location = new System.Drawing.Point(3, 0);
            this.lblKolay.Name = "lblKolay";
            this.lblKolay.Size = new System.Drawing.Size(50, 19);
            this.lblKolay.TabIndex = 0;
            this.lblKolay.Text = "Kolay:";
            // 
            // toggleKolay
            // 
            this.toggleKolay.AutoSize = true;
            this.toggleKolay.Checked = true;
            this.toggleKolay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleKolay.DisplayStatus = false;
            this.toggleKolay.Location = new System.Drawing.Point(59, 3);
            this.toggleKolay.Name = "toggleKolay";
            this.toggleKolay.Size = new System.Drawing.Size(50, 17);
            this.toggleKolay.TabIndex = 1;
            this.toggleKolay.Text = "On";
            this.toggleKolay.UseSelectable = true;
            this.toggleKolay.Click += new System.EventHandler(this.toggleKolay_Click);
            // 
            // lblOrta
            // 
            this.lblOrta.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOrta.Location = new System.Drawing.Point(3, 23);
            this.lblOrta.Name = "lblOrta";
            this.lblOrta.Size = new System.Drawing.Size(50, 19);
            this.lblOrta.TabIndex = 0;
            this.lblOrta.Text = "Orta:";
            // 
            // toggleOrta
            // 
            this.toggleOrta.AutoSize = true;
            this.toggleOrta.DisplayStatus = false;
            this.toggleOrta.Location = new System.Drawing.Point(59, 26);
            this.toggleOrta.Name = "toggleOrta";
            this.toggleOrta.Size = new System.Drawing.Size(50, 17);
            this.toggleOrta.TabIndex = 2;
            this.toggleOrta.Text = "Off";
            this.toggleOrta.UseSelectable = true;
            this.toggleOrta.Click += new System.EventHandler(this.toggleOrta_Click);
            // 
            // lblZor
            // 
            this.lblZor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblZor.Location = new System.Drawing.Point(3, 46);
            this.lblZor.Name = "lblZor";
            this.lblZor.Size = new System.Drawing.Size(50, 19);
            this.lblZor.TabIndex = 0;
            this.lblZor.Text = "Zor:";
            // 
            // toggleZor
            // 
            this.toggleZor.AutoSize = true;
            this.toggleZor.DisplayStatus = false;
            this.toggleZor.Location = new System.Drawing.Point(59, 49);
            this.toggleZor.Name = "toggleZor";
            this.toggleZor.Size = new System.Drawing.Size(50, 17);
            this.toggleZor.TabIndex = 3;
            this.toggleZor.Text = "Off";
            this.toggleZor.UseSelectable = true;
            this.toggleZor.Click += new System.EventHandler(this.toggleZor_Click);
            // 
            // pnlSkorBoard
            // 
            this.pnlSkorBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSkorBoard.ColumnCount = 4;
            this.pnlSkorBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSkorBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSkorBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSkorBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSkorBoard.Controls.Add(this.lblKalanSureDisplay, 1, 0);
            this.pnlSkorBoard.Controls.Add(this.lblTemizAlanDisplay, 3, 0);
            this.pnlSkorBoard.Controls.Add(this.lblSkorDisplay, 1, 1);
            this.pnlSkorBoard.Controls.Add(this.lblMayinSayisiDisplay, 3, 1);
            this.pnlSkorBoard.Controls.Add(this.lblTemizAlan, 2, 0);
            this.pnlSkorBoard.Controls.Add(this.lblKalanSure, 0, 0);
            this.pnlSkorBoard.Controls.Add(this.lblMayinSayisi, 2, 1);
            this.pnlSkorBoard.Controls.Add(this.lblSkor, 0, 1);
            this.pnlSkorBoard.Location = new System.Drawing.Point(106, 88);
            this.pnlSkorBoard.Name = "pnlSkorBoard";
            this.pnlSkorBoard.RowCount = 2;
            this.pnlSkorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSkorBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSkorBoard.Size = new System.Drawing.Size(448, 56);
            this.pnlSkorBoard.TabIndex = 4;
            this.pnlSkorBoard.Visible = false;
            // 
            // lblKalanSureDisplay
            // 
            this.lblKalanSureDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKalanSureDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lblKalanSureDisplay.Font = new System.Drawing.Font("Arvo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSureDisplay.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblKalanSureDisplay.Location = new System.Drawing.Point(152, 2);
            this.lblKalanSureDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.lblKalanSureDisplay.Name = "lblKalanSureDisplay";
            this.lblKalanSureDisplay.Size = new System.Drawing.Size(72, 24);
            this.lblKalanSureDisplay.TabIndex = 1;
            this.lblKalanSureDisplay.Text = "01:89";
            this.lblKalanSureDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemizAlanDisplay
            // 
            this.lblTemizAlanDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTemizAlanDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lblTemizAlanDisplay.Font = new System.Drawing.Font("Arvo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemizAlanDisplay.ForeColor = System.Drawing.Color.LightYellow;
            this.lblTemizAlanDisplay.Location = new System.Drawing.Point(376, 2);
            this.lblTemizAlanDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemizAlanDisplay.Name = "lblTemizAlanDisplay";
            this.lblTemizAlanDisplay.Size = new System.Drawing.Size(72, 24);
            this.lblTemizAlanDisplay.TabIndex = 1;
            this.lblTemizAlanDisplay.Text = "01:89";
            this.lblTemizAlanDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkorDisplay
            // 
            this.lblSkorDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSkorDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lblSkorDisplay.Font = new System.Drawing.Font("Arvo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkorDisplay.ForeColor = System.Drawing.Color.Gold;
            this.lblSkorDisplay.Location = new System.Drawing.Point(152, 30);
            this.lblSkorDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.lblSkorDisplay.Name = "lblSkorDisplay";
            this.lblSkorDisplay.Size = new System.Drawing.Size(72, 24);
            this.lblSkorDisplay.TabIndex = 1;
            this.lblSkorDisplay.Text = "01:89";
            this.lblSkorDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMayinSayisiDisplay
            // 
            this.lblMayinSayisiDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMayinSayisiDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lblMayinSayisiDisplay.Font = new System.Drawing.Font("Arvo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMayinSayisiDisplay.ForeColor = System.Drawing.Color.LightYellow;
            this.lblMayinSayisiDisplay.Location = new System.Drawing.Point(376, 30);
            this.lblMayinSayisiDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.lblMayinSayisiDisplay.Name = "lblMayinSayisiDisplay";
            this.lblMayinSayisiDisplay.Size = new System.Drawing.Size(72, 24);
            this.lblMayinSayisiDisplay.TabIndex = 1;
            this.lblMayinSayisiDisplay.Text = "01:89";
            this.lblMayinSayisiDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemizAlan
            // 
            this.lblTemizAlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTemizAlan.AutoSize = true;
            this.lblTemizAlan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTemizAlan.Location = new System.Drawing.Point(256, 4);
            this.lblTemizAlan.Name = "lblTemizAlan";
            this.lblTemizAlan.Size = new System.Drawing.Size(77, 19);
            this.lblTemizAlan.TabIndex = 0;
            this.lblTemizAlan.Text = "Temiz Alan:";
            this.lblTemizAlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKalanSure.Location = new System.Drawing.Point(33, 4);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(76, 19);
            this.lblKalanSure.TabIndex = 0;
            this.lblKalanSure.Text = "Kalan Süre:";
            this.lblKalanSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMayinSayisi
            // 
            this.lblMayinSayisi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMayinSayisi.AutoSize = true;
            this.lblMayinSayisi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMayinSayisi.Location = new System.Drawing.Point(246, 32);
            this.lblMayinSayisi.Name = "lblMayinSayisi";
            this.lblMayinSayisi.Size = new System.Drawing.Size(87, 19);
            this.lblMayinSayisi.TabIndex = 0;
            this.lblMayinSayisi.Text = "Mayın Sayısı:";
            this.lblMayinSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkor
            // 
            this.lblSkor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSkor.AutoSize = true;
            this.lblSkor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSkor.Location = new System.Drawing.Point(70, 32);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(39, 19);
            this.lblSkor.TabIndex = 0;
            this.lblSkor.Text = "Skor:";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile1.Enabled = false;
            this.metroTile1.Location = new System.Drawing.Point(16, 156);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(538, 4);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.TabStop = false;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // pnlGameStart
            // 
            this.pnlGameStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGameStart.Controls.Add(this.pnlTakmeIsimBaslat);
            this.pnlGameStart.Controls.Add(this.flowLayoutPanel1);
            this.pnlGameStart.Location = new System.Drawing.Point(191, 64);
            this.pnlGameStart.Name = "pnlGameStart";
            this.pnlGameStart.Size = new System.Drawing.Size(320, 88);
            this.pnlGameStart.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlConsolMain
            // 
            this.pnlConsolMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConsolMain.AutoScroll = true;
            this.pnlConsolMain.Controls.Add(this.txtBoxConsoleInput);
            this.pnlConsolMain.Controls.Add(this.txtBoxConsoleBody);
            this.pnlConsolMain.Location = new System.Drawing.Point(4, -376);
            this.pnlConsolMain.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlConsolMain.Name = "pnlConsolMain";
            this.pnlConsolMain.Size = new System.Drawing.Size(564, 400);
            this.pnlConsolMain.TabIndex = 8;
            // 
            // txtBoxConsoleInput
            // 
            this.txtBoxConsoleInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConsoleInput.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConsoleInput.Enabled = false;
            this.txtBoxConsoleInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxConsoleInput.ForeColor = System.Drawing.Color.Yellow;
            this.txtBoxConsoleInput.Location = new System.Drawing.Point(0, 384);
            this.txtBoxConsoleInput.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxConsoleInput.MaxLength = 140;
            this.txtBoxConsoleInput.Name = "txtBoxConsoleInput";
            this.txtBoxConsoleInput.Size = new System.Drawing.Size(564, 15);
            this.txtBoxConsoleInput.TabIndex = 9;
            this.txtBoxConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxConsoleInput_KeyDown);
            this.txtBoxConsoleInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxConsoleInput_KeyPress);
            // 
            // txtBoxConsoleBody
            // 
            this.txtBoxConsoleBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConsoleBody.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtBoxConsoleBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxConsoleBody.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxConsoleBody.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtBoxConsoleBody.Location = new System.Drawing.Point(0, 0);
            this.txtBoxConsoleBody.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxConsoleBody.Name = "txtBoxConsoleBody";
            this.txtBoxConsoleBody.ReadOnly = true;
            this.txtBoxConsoleBody.Size = new System.Drawing.Size(564, 384);
            this.txtBoxConsoleBody.TabIndex = 0;
            this.txtBoxConsoleBody.TabStop = false;
            this.txtBoxConsoleBody.Text = "";
            this.txtBoxConsoleBody.WordWrap = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(570, 200);
            this.Controls.Add(this.pnlConsolMain);
            this.Controls.Add(this.pnlSkorBoard);
            this.Controls.Add(this.pnlGameStart);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnMenu);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(490, 200);
            this.Name = "FormMain";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Mayın Tarlası";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.mainStyleManager)).EndInit();
            this.Menu.ResumeLayout(false);
            this.pnlTakmeIsimBaslat.ResumeLayout(false);
            this.pnlTakmeIsimBaslat.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlSkorBoard.ResumeLayout(false);
            this.pnlSkorBoard.PerformLayout();
            this.pnlGameStart.ResumeLayout(false);
            this.pnlConsolMain.ResumeLayout(false);
            this.pnlConsolMain.PerformLayout();
            this.ResumeLayout(false);

        }



        private MetroFramework.Components.MetroStyleManager mainStyleManager;
        private MetroFramework.Controls.MetroButton btnMenu;
        private MetroFramework.Controls.MetroContextMenu Menu;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skorTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel lblKolay;
        private MetroFramework.Controls.MetroToggle toggleKolay;
        private MetroFramework.Controls.MetroLabel lblOrta;
        private MetroFramework.Controls.MetroToggle toggleOrta;
        private MetroFramework.Controls.MetroLabel lblZor;
        private MetroFramework.Controls.MetroToggle toggleZor;
        private System.Windows.Forms.Panel pnlTakmeIsimBaslat;
        private MetroFramework.Controls.MetroButton btnBaslat;
        private MetroFramework.Controls.MetroTextBox txtBoxTakmaIsim;
        private MetroFramework.Controls.MetroLabel lblTakmeIsim;
        private System.Windows.Forms.TableLayoutPanel pnlSkorBoard;
        private System.Windows.Forms.Label lblKalanSureDisplay;
        private System.Windows.Forms.Label lblTemizAlanDisplay;
        private System.Windows.Forms.Label lblSkorDisplay;
        private System.Windows.Forms.Label lblMayinSayisiDisplay;
        private MetroFramework.Controls.MetroLabel lblTemizAlan;
        private MetroFramework.Controls.MetroLabel lblKalanSure;
        private MetroFramework.Controls.MetroLabel lblMayinSayisi;
        private MetroFramework.Controls.MetroLabel lblSkor;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Panel pnlGameStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlConsolMain;
        private System.Windows.Forms.TextBox txtBoxConsoleInput;
        private System.Windows.Forms.RichTextBox txtBoxConsoleBody;
    }
}

