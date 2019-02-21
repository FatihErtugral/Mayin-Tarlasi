using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MMayinTarlasi
{
    class GameButton : Button, ICloneable
    {
        public byte GameValue { get; set; }
        public byte CordX { get; set; }
        public byte CordY { get; set; }
        public bool mine = false;
        public bool prevention = false;

        public object Clone()
        {
            GameButton copyButton = Activator.CreateInstance<GameButton>();//önce GameMineButton Bir instance oluşturulur.
            PropertyInfo[] piList = this.GetType()//mevcut içerinde bulunduğumuz sınıfın property leri çekilir.
                .GetProperties();

            //mevcut property' lerden kopyalanmak istenen property ler belirtilir. Ancak bu örnekte hepsine gerek yoktur.
            //çünkü zaten oluşturuduğumuz copy sınıfının default değerleri içerisinde bulunduğumuz sınıf tarafından değiştirilmemektedir.
            //uygulama gereksinimine göre hepsi de kopyalanabilir.

            List<string> attributeList = new List<string>
            {
                "Font",
                "FlatStyle",
                "Size",
                "BackColor",
                "Margin",
                "BackgroundImage",
                "Padding",
                "Text",
                "TabStop",
                "ForeColor",
                "TabIndex",
                "Paint",
                "Enabled",
                "BackgroundImageLayout",
                "Visible"
            };

            foreach (PropertyInfo pi in piList.Where(i=>attributeList.Contains(i.Name)))//içerisinde bulunduğumuz sınıfın propertyleri içerisinde dönülmeye başlanır.
            {
                if (pi.GetValue(copyButton, null) != pi.GetValue(this, null))//sırayla yeni copy nesnemize atanır.
                {
                    if (pi.CanWrite)
                    {
                        pi.SetValue(copyButton, pi.GetValue(this, null), null);
                    }
                }
            }

            return copyButton;
        }
        // Butonun Disabled rengi sistemde gri ve sabit, OnPaint override edilerek yeniden biçimlendiriliyor.
        protected override void OnPaint(PaintEventArgs pe)
        {
            if( base.Enabled )
            {
                base.OnPaint(pe);
                return;
            }
            else
            {
                // Calling the base class OnPaint
                base.OnPaint(pe);
                // Setup the Formatting for the text
                StringFormat formatText = new StringFormat(StringFormatFlags.NoClip)
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center,
                    Trimming = StringTrimming.Character
                };
                // Drawing the button yoursel. The background is color
                // pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(51,    55,     69)), pe.ClipRectangle);
                // Draw the line around the button
                // pe.Graphics.DrawRectangle(new Pen(base.FlatAppearance.BorderColor, 1), 0, 0, base.Width - 1, base.Height - 1);
                // Draw the text in the button in color
                pe.Graphics.DrawString(base.Text, base.Font, new SolidBrush(base.ForeColor),
                    new RectangleF(0F, 0F, base.Width, base.Height),  formatText);
                return;
            }
        }
    }
}
