#define MY_DEBUG
using ClassLibrary1;
using Diamond_Crush.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diamond_Crush
{
    public partial class ShopScene : Form
    {
        private bool _isMouseClickListening = true;
        private CImageBase _harmmer,_flash, _sandClock;
        public static ShopScene _shopScene=null;
        private CImageBase _butBack;
        private CImageBase[] _butBuy;
        public static ShopScene Instance()
        {
            if (_shopScene == null)
            {
                _shopScene = new ShopScene();
                return _shopScene;
            }
            return _shopScene;
        }
        private ShopScene()
        {
            InitializeComponent();
            _butBuy = new CImageBase[3];
            
            for (int i = 0; i < 3; i++)
            {
                _butBuy[i] = new CImageBase(Resources.but_shop_75x75) {Left=337,Top=138+90*i };
            }
            _butBack = new CImageBase(Resources.but_back_75x75) { Left = 0, Top = 0 };
            _harmmer = new CImageBase(Resources.harmer_75x75){ Left= 83, Top =138};
            _flash = new CImageBase(Resources.flash_50x75) { Left = 108, Top = 219 };
            _sandClock = new CImageBase(Resources.bonus_time_50x75) { Left = 108, Top = 309 };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            //#if MY_DEBUG
            //            TextFormatFlags flag = TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis;
            //            Font font = new Font("Arial", 12, FontStyle.Regular);
            //            TextRenderer.DrawText(dc,"" + _cursX.ToString() + ";" + _cursY.ToString(),font
            //                ,new Rectangle(this.Width-150,0,150,20),SystemColors.ControlText,flag);
            //#endif
            
            foreach (var img in _butBuy)
            {
                img.DrawSprite(dc);
            }
            _butBack.DrawSprite(dc);
            _harmmer.DrawSprite(dc);
            _flash.DrawSprite(dc);
            _sandClock.DrawSprite(dc);
            TextFormatFlags flag = TextFormatFlags.HorizontalCenter;
            TextFormatFlags flag1 = TextFormatFlags.HorizontalCenter|TextFormatFlags.EndEllipsis;
            Font font = new Font("Arial", 14, FontStyle.Regular);
            if (CUser.Instance()._lifeCount < 5)
            {
                TextRenderer.DrawText(dc, CUser.Instance()._lifeCount.ToString() + "( New life in  0" + (SignIn._newLifeTimeLeft / 60).ToString()
                + ":" + ((SignIn._newLifeTimeLeft % 60) < 10 ? ("0" + (SignIn._newLifeTimeLeft % 60).ToString()) : (SignIn._newLifeTimeLeft % 60).ToString()), font
                , new Rectangle(this.picBox_life.Location.X, this.picBox_life.Location.Y + 10, 300, 20), SystemColors.ControlText, flag1);
                timer1.Start();
            }
            else
            {
                TextRenderer.DrawText(dc, CUser.Instance()._lifeCount.ToString() + " Full",font
                    , new Rectangle(this.picBox_life.Location.X, this.picBox_life.Location.Y + 10, 150, 20), SystemColors.ControlText, flag);
                timer1.Stop();
            }
            TextRenderer.DrawText(dc, CUser.Instance()._goldCount.ToString(), font
                , new Rectangle(this.picBox_coin.Location.X, this.picBox_coin.Location.Y +10, 150, 20), SystemColors.ControlText, flag);
            TextRenderer.DrawText(dc, CUser.Instance()._harmmerCount.ToString()+" )", font
                , new Rectangle(this.harmmer_label.Location.X+70, this.harmmer_label.Location.Y+2 , 100, 20), SystemColors.ControlText, flag);
            TextRenderer.DrawText(dc, CUser.Instance()._flashCount.ToString() + " )", font
                , new Rectangle(this.flash_label.Location.X + 70, this.flash_label.Location.Y+2 , 100, 20), SystemColors.ControlText, flag);
            TextRenderer.DrawText(dc, CUser.Instance()._sandClockCount.ToString() + " )", font
                , new Rectangle(this.sandclock_label.Location.X + 70, this.sandclock_label.Location.Y+2 , 100, 20), SystemColors.ControlText, flag);
            base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ShopScene_VisibleChanged(object sender, EventArgs e)
        {
            CUser.UpdateOfflineUserInfo();
        }

        private void ShopScene_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isMouseClickListening)
            {
                if (_butBack.IsClicked(e.X, e.Y))
                {
                    this.Hide();
                }
                for (int i = 0; i < 3; i++)
                {
                    if (_butBuy[i].IsClicked(e.X, e.Y))
                    {
                        switch (i)
                        {
                            case 0:
                                {
                                    if (CUser.Instance()._goldCount >= 60)
                                    {
                                        CUser.Instance()._goldCount -= 60;
                                        CUser.Instance()._harmmerCount++;
                                        CUser.UpdateOfflineUserInfo();
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("You need " + (60 - CUser.Instance()._goldCount).ToString() + " gold to buy harmmer.");
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    if (CUser.Instance()._goldCount >= 70)
                                    {
                                        CUser.Instance()._goldCount -= 70;
                                        CUser.UpdateOfflineUserInfo();
                                        CUser.Instance()._flashCount++;
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("You need " + (70 - CUser.Instance()._goldCount).ToString() + " gold to buy flash.");
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (CUser.Instance()._goldCount >= 50)
                                    {
                                        CUser.Instance()._goldCount -= 50;
                                        CUser.Instance()._sandClockCount++;
                                        CUser.UpdateOfflineUserInfo();
                                        break;
                                    }
                                    else
                                    {
                                        MessageBox.Show("You need " + (50 - CUser.Instance()._goldCount).ToString() + " gold to buy sand clock.");
                                    }
                                    break;
                                }
                        }
                        CUser.UpdateOfflineItemCount();
                        this.Refresh();
                        break;
                    }
            }
                
            }
        }
    }
}
