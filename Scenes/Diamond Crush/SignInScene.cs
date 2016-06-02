using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Diamond_Crush
{
    
    public partial class SignIn : Form
    {
        private static SignIn _instance = null;
        public static uint _newLifeTimeLeft = 20;
        public static SignIn Instance()
        {
            if (_instance == null)
            {
                _instance = new SignIn();
                return _instance;
            }
            return _instance;
        }
        private SignIn()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            Font font = new Font("Arial", 14, FontStyle.Regular);
            TextRenderer.DrawText(dc, "Press Esc to play ofline", font
                , new Rectangle(this.Width/2 - 100, 0, 215, 20), SystemColors.ControlText);
            base.OnPaint(e);
        }
        private void sign_in_Click(object sender, EventArgs e)
        {
            if (Username.Text != "" && Password.Text != "")
            {
                CUser._staticUsername = Username.Text;
                CUser._staticPassword = Password.Text;
                LoginGame();
            }
            else if (Username.Text == "") MessageBox.Show("Please insert username.");
            else if (Password.Text== "") MessageBox.Show("Please insert password.");
        }
        private void passwordEnter_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Int32) Keys.Enter)
            {
                if (Username.Text != "" && Password.Text != "")
                {
                    CUser._staticUsername = Username.Text;
                    CUser._staticPassword = Password.Text;
                    LoginGame();
                }
                else if (Username.Text == "") MessageBox.Show("Please insert username.");
            }
            else if (e.KeyChar == (Char)Keys.Escape)
            {
                SignInOfflineAccount();
            }
        }
        private void SignInOfflineAccount()
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            if (new FileInfo("User.txt").Exists==false)
            {
                string[] str = { "0", "5", "0", "0" };
                System.IO.File.WriteAllLines("User.txt", str);
                var user = CUser.Instance();
                user._goldCount = (uint)Convert.ToInt32(str[0]);
                user._lifeCount = (uint)Convert.ToInt32(str[1]);
                user._totalScore = (uint)Convert.ToInt32(str[2]);
                user._currLevel = (uint)Convert.ToInt32(str[3]);

            }
            else 
            {
                string[] str = System.IO.File.ReadAllLines("User.txt");
                var user = CUser.Instance();
                user._goldCount = (uint)Convert.ToInt32(str[0]);
                user._lifeCount = (uint)Convert.ToInt32(str[1]);
                user._totalScore = (uint)Convert.ToInt32(str[2]);
                user._currLevel = (uint)Convert.ToInt32(str[3]);
                if (user._lifeCount < 5)
                    lifeGenerateCount.Start();
                
            }
            for(int i = 0; i < 9; i++)
            {
                if(new FileInfo("Level_" + i.ToString() + ".txt").Exists == false)
                {
                    string[] str = { "0", "0"};
                    var user = CUser.Instance();
                    System.IO.File.WriteAllLines("Level_" + i.ToString() + ".txt", str);
                    user.GetLevel(i)._highestScore = (uint)Convert.ToInt32(str[0]);
                    user.GetLevel(i)._highestStar = (uint)Convert.ToInt32(str[1]);
                }
                else
                {
                    var user = CUser.Instance();
                    string[] str = System.IO.File.ReadAllLines("Level_" + i.ToString() + ".txt");
                    user.GetLevel(i)._highestScore = (uint)Convert.ToInt32(str[0]);
                    user.GetLevel(i)._highestStar = (uint)Convert.ToInt32(str[1]);
                }
            }
            if(new FileInfo("Item.txt").Exists == false)
            {
                string[] str = { "0", "0","0" };
                var user = CUser.Instance();
                System.IO.File.WriteAllLines("Item.txt", str);
                user._harmmerCount = (uint)Convert.ToInt32(str[0]);
                user._flashCount = (uint)Convert.ToInt32(str[1]);
                user._sandClockCount = (uint)Convert.ToInt32(str[2]);
            }
            else
            {
                var user = CUser.Instance();
                string[] str = System.IO.File.ReadAllLines("Item.txt");
                user._harmmerCount = (uint)Convert.ToInt32(str[0]);
                user._flashCount = (uint)Convert.ToInt32(str[1]);
                user._sandClockCount = (uint)Convert.ToInt32(str[2]);
            }
            for (int i = 0; i < 9; i++)
            {
                if (i < CUser.Instance()._currLevel)
                {
                    CUser.Instance().GetLevel(i).IsUnlocked = true;
                }
            }
            LoginGame();

        }
        private void usernameEnter_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (Username.Text != "" && Password.Text != "")
                {
                    CUser._staticUsername = Username.Text;
                    CUser._staticPassword = Password.Text;
                    LoginGame();
                }
                else if (Password.Text == "") MessageBox.Show("Please insert password.");
            }
            else if (e.KeyChar == (Char)Keys.Escape)
            {
                SignInOfflineAccount();
            }
        }
        private  void sign_up_Click(object sender, EventArgs e)
        {
            var f = new SignUp();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }
        private void exit_Click(object sender, EventArgs e)
        {
            CUser._staticUsername = "";
            CUser._staticPassword = "";
            Application.Exit();
        }
        private void sign_in_Load(object sender, EventArgs e)
        {
            //this.picBoxExit.Image = global::Diamond_Crush.Properties.Resources.but_exit_75x75;
        }
        private void LoginGame()
        {
            this.Hide();
            this.Username.Text = "";
            this.Password.Text = "";
            this.Username.Select();
            var f = MainMenu.Instance();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
        public void SetVisible(bool Visible)
        {
            if (Visible == true) this.SetVisibleCore(true);
            else this.SetVisibleCore(false);
        }
        private void timer_generateLifeCount(object sender, EventArgs e)
        {
            if (_newLifeTimeLeft > 0&&CUser.Instance()._lifeCount<5)
            {
                _newLifeTimeLeft--;
            }
            else if(_newLifeTimeLeft==0&&CUser.Instance()._lifeCount<5)
            {
                CUser.Instance()._lifeCount++;
                CUser.UpdateOfflineUserInfo();
                _newLifeTimeLeft = 20;
            }
            else
            {
                _newLifeTimeLeft = 20;
            }

        }
    }
}
