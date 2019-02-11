using MMayinTarlasi.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMayinTarlasi
{
    //
    // X = WIDTH    = COLUMN
    // Y = HEIGHT   = ROW
    // 
    class GameCreate
    {
        private static GameCreate _;
        private static readonly object _lockObject = new object();

        private GameButton          gBtn; 
        private GameButton[,]       gameBtnList;
        private GameArrayMap  gameArrMap;
        public  Panel               panelMap;
        
        private byte gameBtnColNum;
        private byte gameBtnRowNum;
        public  byte gameBtnMineNum;

        public int  gameBtnEmptyNum = 0;
        public int  score = 0;
        public bool lose = false;

        private Point    _Point     = new Point(0, 0);

        #region Game Button Attributes
        private readonly int btnLeftRightMargin = 1;
        private readonly int btnTopBottomMargin = 1;

        private readonly Color btnGameStep_BackColor     = Color.FromArgb(143,188,139);
        private readonly Color btnGameStep_BorderColor   = Color.FromArgb(143,188,139);
        private readonly Color btnGameMine_BackColor     = Color.FromArgb(255,255,200);
        private readonly Color btnGameMine_BorderColor   = Color.FromArgb(255,255,200);
        private readonly Color btnGameClean_BackColor    = Color.FromArgb(191, 191, 191); 
        private readonly Color btnGameClean_BorderColor  = Color.FromArgb(191, 191, 191); 
        private readonly Color btnGameNum_BackColor      = Color.FromArgb(241,241,241);     
        private readonly Color btnGameNum_ForeColor      = Color.FromArgb(13, 13, 13); //Color.FromArgb(165, 219, 0); 
        private readonly Color btnGameNum_BorderColor    = Color.FromArgb(164,164, 164);
        private readonly Color btnGameDefault_BackColor  = Color.FromArgb(72, 72, 72);
        private readonly Color btnGameDefault_BorderColor = Color.FromArgb(72, 72, 72);
        private readonly Size     btnSize    = new Size(24, 24);
        private readonly Padding  btnMargin  = new Padding(0);
        private readonly Padding  btnPadding = new Padding(0);
        private readonly Image    btnGameMineImg  = Resources.mine;
        private readonly Image    btnGameStepImg  = Resources.flag;
        private readonly Font     btnFont = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Pixel);
        #endregion

        public static GameCreate GetInstance()
        {
            if(_ == null)
            {
                lock (_lockObject)
                {
                    if (_ == null)
                        _ = new GameCreate();
                }
            }
            return _;
        }

        public void Start(byte gameBtnRowNum, byte gameBtnColNum, byte gameBtnMineNum)
        {
            // Array'lerde hafıza temizlenip yeniden oluşturuluyor.
            if(this.gameArrMap != null || this.gameBtnList != null)
            {
                Clear();
            }
            this.gameBtnColNum  = gameBtnRowNum;
            this.gameBtnRowNum  = gameBtnColNum;
            this.gameBtnMineNum = gameBtnMineNum;
            this.gameBtnEmptyNum = gameBtnRowNum * gameBtnColNum - gameBtnMineNum;
            this.gameArrMap = new GameArrayMap(this.gameBtnColNum, this.gameBtnRowNum, this.gameBtnMineNum);
            this.gameBtnList    = new GameButton[this.gameBtnColNum, this.gameBtnRowNum];

            //Butonlar gameBtnList dizisine ve Form Panele ekleniyor.
            for (byte row = 0; row < this.gameBtnColNum; row++)
            {
                for (byte col = 0; col < this.gameBtnRowNum; col++)
                {
                    this.gameBtnList[row, col] =  GameBtnClonePrototype(ref row, ref col);
                    panelMap.Controls.Add(this.gameBtnList[row, col]);
                }
            }
            //Panel yeniden boyutlandırılıyor.
            panelMap.Width  = (_.gameBtnColNum * btnSize.Width   + _.gameBtnColNum* btnLeftRightMargin)-btnLeftRightMargin;
            panelMap.Height = (_.gameBtnRowNum * btnSize.Height  + _.gameBtnRowNum* btnTopBottomMargin)-btnTopBottomMargin;
        }
        

        public void Clear()
        {
            panelMap.Hide();
            if(thread !=null)
                thread.Abort();
            gameArrMap = null;
            gameBtnList = null;
            panelMap.Controls.Clear();
            score = 0;
            lose = false;
            gameBtnEmptyNum = 0;
            GC.Collect();
        }


        // Form Panel hafızada oluşturuluyor.
        private void PanelMapInstance()
        {
            panelMap = new Panel
            {
                Location = new System.Drawing.Point(16, 173),
                Size = new System.Drawing.Size(0, 0),
                TabIndex = 2
            };

        }

        // Prototip tasarım deseni için hafızada bir buton prototipi oluşturuluyor.
        private void GameBtnCreatePrototype()
        {
            gBtn = new GameButton
            {
                Font    = btnFont,
                Size    = btnSize,
                Margin  = btnMargin,
                Padding = btnPadding,
                TabStop = false,
                Enabled = true,
                TabIndex  = 10,
                FlatStyle = FlatStyle.Flat,
                BackColor = btnGameDefault_BackColor,
                BackgroundImageLayout = ImageLayout.Stretch
            };
        }
        
        // Constructor
        private GameCreate()
        {
            PanelMapInstance();
            GameBtnCreatePrototype();
        }

        // Butonlar kopyalanıp gerekli ayarlar set ediliyor.
        private static GameButton GameBtnClonePrototype(ref byte cordX, ref byte cordY)
        {
            GameButton btn = (GameButton)_.gBtn.Clone();
             
            btn.FlatAppearance.BorderColor = _.btnGameDefault_BorderColor;
            btn.GameValue   = _.gameArrMap.map[cordX, cordY];
            btn.CordX       = cordX;
            btn.CordY       = cordY;
            _._Point.X      = (cordX * (btn.Width + _.btnLeftRightMargin));
            _._Point.Y      = (cordY * (btn.Height + _.btnTopBottomMargin));
            btn.Location    = _._Point;
            btn.MouseDown   += _.GameBtnClick;

            return btn;
        }

        #region Mayın tarlasını tarayıp otomatik açan algoritmamız.
        
        private static readonly sbyte[] x = { 1, -1,  1, -1, 0, 1, 0,  -1, 0};
        private static readonly sbyte[] y = { 1, -1, -1,  1, 0, 0, -1, 0, 1};

        private static void GameBtnEmptyOpen(sbyte cordX, sbyte cordY)
        {
            for (byte i = 4; i < 9; i++)
            {
                if 
                (      cordX + x[i] >= 0
                    && cordY + y[i] >= 0
                    && cordX + x[i] < _.gameBtnColNum
                    && cordY + y[i] < _.gameBtnRowNum
                    && _.gameBtnList[(cordX + x[i]), (cordY + y[i])].Enabled
                    && _.gameBtnList[(cordX + x[i]), (cordY + y[i])].GameValue != 9
                    && !_.gameBtnList[(cordX + x[i]), (cordY + y[i])].prevention
                )
                {
                    if (_.gameBtnList[ (cordX +x[i]), (cordY + y[i]) ].GameValue == 0)
                    {
                        GameBtnEmptyAttrbutes(ref _.gameBtnList[ (cordX +x[i]), (cordY + y[i]) ]);
                        GameBtnEmptyOpen((sbyte)(cordX + x[i]),(sbyte)(cordY + y[i]));// # //

                        
                        for (byte k = 0; k < 9; k++)
                        {

                            if 
                            (      cordX + x[i] + x[k] >= 0
                                && cordY + y[i] + y[k] >= 0
                                && cordX + x[i] + x[k] < _.gameBtnColNum
                                && cordY + y[i] + y[k] < _.gameBtnRowNum
                                && _.gameBtnList[(cordX + x[i] + x[k]), (cordY + y[i] + y[k])].Enabled
                                && _.gameBtnList[(cordX + x[i] + x[k]), (cordY + y[i] + y[k])].GameValue != 9
                                && _.gameBtnList[(cordX + x[i] + x[k]), (cordY + y[i] + y[k])].GameValue != 0 
                                && !_.gameBtnList[(cordX + x[i] + x[k]), (cordY + y[i] + y[k])].prevention
                            )
                            { GameBtnNumAttrbutes(ref _.gameBtnList[(cordX + x[i] + x[k]), (cordY + y[i] + y[k])]); }
                        }
                    }
                }
            }
        }
        #endregion

        // Mayınsız buton özellikleri
        private static void GameBtnEmptyAttrbutes(ref GameButton btn)
        {
            btn.Enabled   = false;
            btn.BackColor = _.btnGameClean_BackColor;
            btn.FlatAppearance.BorderColor = _.btnGameClean_BorderColor;

            // Skor puanlama
            _.score += 2;
            _.gameBtnEmptyNum--;
        }

        // Numaralı buton özellikleri
        private static void GameBtnNumAttrbutes(ref GameButton btn)
        {
            btn.BackColor = _.btnGameNum_BackColor;
            btn.ForeColor = _.btnGameNum_ForeColor;
            btn.FlatAppearance.BorderColor = _.btnGameNum_BorderColor;
            btn.Text = ""+_.gameArrMap.map[btn.CordX, btn.CordY];
            btn.Enabled = false;

            _.score += 2 + btn.GameValue;
            _.gameBtnEmptyNum--;
        }

        // Numaralı buton özellikleri
        private static void GameBtnmMineAttrbutes(ref GameButton btn)
        {
            btn.BackColor = _.btnGameMine_BackColor;
            btn.BackgroundImage = _.btnGameMineImg;
            btn.FlatAppearance.BorderColor = _.btnGameMine_BorderColor;
            btn.Enabled = false;
        }

        private void GameBtnPrevetion(ref GameButton btn)
        {
            if (!btn.prevention)
            {
                btn.prevention = true;
                btn.BackgroundImage = btnGameStepImg;
                btn.BackColor = btnGameStep_BackColor;
                btn.FlatAppearance.BorderColor = btnGameStep_BorderColor;
            }
            else {
                btn.prevention = false;
                btn.BackgroundImage = null;
                btn.BackColor = btnGameDefault_BackColor;
                btn.FlatAppearance.BorderColor = btnGameDefault_BorderColor;
            }
        }

        private void GameBtnMineAllOpen()
        {
            for (byte row = 0; row < this.gameBtnColNum; row++)
                for (byte col = 0; col < this.gameBtnRowNum; col++)
                {
                    if(_.gameArrMap.map[row, col] == 9)
                    { GameBtnmMineAttrbutes(ref _.gameBtnList[row, col]); }
                }
            lose = true;
            return;
        }

        Thread thread;
        private void GameBtnClick(object sender, MouseEventArgs e)
        {
            GameButton btn = (GameButton)sender;
            if (e.Button == MouseButtons.Left && !btn.prevention)
            {
                switch (gameArrMap.map[btn.CordX, btn.CordY])
                {
                    case 0:
                        thread = new Thread(() => GameBtnEmptyOpen((sbyte)btn.CordX, (sbyte)btn.CordY));
                        thread.Start();
                        thread.Join();
                        break;
                    case 9:
                        GameBtnMineAllOpen();
                        break;
                    default:
                        GameBtnNumAttrbutes(ref btn);
                        break;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                GameBtnPrevetion(ref btn);
            }

        }

        #region Konsol Metodları

        public void MineToggleLock()
        {
            if(_.gameBtnList != null)
            for (byte row = 0; row < this.gameBtnColNum; row++)
                for (byte col = 0; col < this.gameBtnRowNum; col++)
                {
                    if(_.gameArrMap.map[row, col] == 9)
                    { GameBtnPrevetion(ref _.gameBtnList[row, col]); }
                }
            return;
        }

        public string MapMatrixToString()
        {
            string map ="";

            if(_.gameBtnList != null)
            for (byte row = 0; row < this.gameBtnColNum; row++)
            {
                for (byte col = 0; col < this.gameBtnRowNum; col++)
                {
                    map += $" [{_.gameArrMap.map[row, col]}]";
                }
                map += "\n";
            }
            return map;
        }
        #endregion
    }
}
