using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Diamond_Crush
{
    public partial class PickLevelScene : Form
    {
        private CUser _user;
        public static PickLevelScene _instance=null;
        public static PickLevelScene Instance()
        {
            if (_instance == null)
            {
                _instance = new PickLevelScene();
                return _instance;
            }
            return _instance;
        }
        private PickLevelScene()
        {
            _user = CUser.Instance();
            InitializeComponent();
            
            
        }

        private void PickLevelScene_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible==true)
                MainMenu.Instance().SetMainMenuVisible(false);
            var user = CUser.Instance();
            for (int i = 0; i < 9; i++)
            {
                
                if (i <= user._currLevel)
                {
                    user.GetLevel(i).IsUnlocked = true;
                }
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < 9; i++)
            {
                if (_user.GetLevel(i).IsUnlocked == true)
                    levelState_imageList.Draw(g, GetLevelLocation((uint)i), i);
                else levelState_imageList.Draw(g, GetLevelLocation((uint)i), 9);
            }
            base.OnPaint(e);
        }

        private void picBox_but_home_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            
        }

        private void PickLevelScene_MouseClick(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < 9; i++)
            {
                if (IsLevelClicked(e.X,e.Y,(uint)i) &&_user.GetLevel(i).IsUnlocked==true)
                {
                    CLevel._currLevel.LevelID = (uint)i;
                    var f = new PreviewLevelScene(i);
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.ShowDialog(this);
                    if(CDiamondCrushSceneControl._nextScene== CDiamondCrushSceneControl.Scene.PickLevel)
                    {
                        this.SetVisibleCore(true);
                    }
                    break;
                }
            }
        }
        public void SetPickLevelSceneVisible(bool Visible)
        {
            this.SetVisibleCore(Visible);
        }
        private bool IsLevelClicked(int x,int y,uint lvID)
        {
            var lvBoundBox = new Rectangle(GetLevelLocation(lvID), new Size(140, 140));
            if (lvBoundBox.Contains(new Point(x, y)))
                return true;
            return false;
        }
    }
}
