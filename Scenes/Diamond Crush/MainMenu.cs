using ClassLibrary1;
using Diamond_Crush.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diamond_Crush
{
    public partial class MainMenu : Form
    {
        private static MainMenu _mainMenuFormm=null;
        CImageBase _exitImage;
        private MainMenu()
        {
            InitializeComponent();
            _exitImage = new CImageBase(Resources.but_exit_75x75) { Left = 10,Top = 10 };


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            _exitImage.DrawSprite(dc);
            base.OnPaint(e);
        }

        private void MainMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (_exitImage.IsClicked(e.X,e.Y))
            {
                Application.Exit();
            }
        }

        private void timerGameLoop(object sender, EventArgs e)
        {

        }
        public static MainMenu Instance()
        {
            if (_mainMenuFormm == null)
            {
                _mainMenuFormm = new MainMenu();
                return _mainMenuFormm;
            }
            return _mainMenuFormm;
        }
        public void SetMainMenuVisible(bool Visible)
        {
            if (Visible == true)
            {
                this.SetVisibleCore(true);
            }
            else this.SetVisibleCore(false);
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            lab_welcom.Text = "Hello " + CUser._staticUsername;
        }
        private void label_shop_Click(object sender, EventArgs e)
        {
            ShopScene f = ShopScene.Instance();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }

        private void lable_setting_Click(object sender, EventArgs e)
        {
            
            //this.SetVisibleCore(false);
            SettingScene f = SettingScene.Instance();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
            // Thread.Sleep(50);
            //SetParent(f.Handle, this.Handle);
            //f.WindowState = FormWindowState.Maximized;
        }

        private void label_playy_Click(object sender, EventArgs e)
        {
            PickLevelScene.Instance().StartPosition = FormStartPosition.CenterParent;
            PickLevelScene.Instance().ShowDialog(this);
            this.SetVisibleCore(true);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CUser._staticUsername = "";
            CUser._staticPassword = "";

            SignIn.Instance().SetVisible(true);
            LogoutGame();
            
        }
        private void LogoutGame()
        {
            _mainMenuFormm = null;
            this.Close();
        }
    }
}
