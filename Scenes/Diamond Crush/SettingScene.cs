using Diamond_Crush.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diamond_Crush
{
    public partial class SettingScene : Form
    {
        CImageBase _volume;
        CImageBase _moreGame;
        CImageBase _butHome;
        public static SettingScene _settingScene=null;
        public static SettingScene Instance()
        {
            if(_settingScene == null)
            {
                _settingScene = new SettingScene();
                return _settingScene;
            }
            return _settingScene;
        }
        [DllImport("winmm.dll")]
      public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        private SettingScene()
        {
            InitializeComponent();
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            trackBar1.Value = CalcVol / (ushort.MaxValue / 10);
            _volume = new CImageBase(Resources.volume) { Top = trackBar1.Location.Y -28, Left = trackBar1.Location.X - 75 };
            _moreGame = new CImageBase(Resources.MoreGamesButton) { Left = trackBar1.Location.X +10 , Top = trackBar1.Location.Y + trackBar1.Height +10};
            _butHome = new CImageBase(Resources.but_home_75x75) { Left = 0, Top = 0 };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            _volume.DrawSprite(e.Graphics);
            _moreGame.DrawSprite(e.Graphics);
            _butHome.DrawSprite(dc);
            base.OnPaint(e);
        }

        private void SettingScene_Load(object sender, EventArgs e)
        {

        }

        private void SettingScene_MouseClick(object sender, MouseEventArgs e)
        {
            if(_butHome.IsClicked(e.X,e.Y))
            {
                
                this.SetVisibleCore(false);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int NewVolume =  ((ushort.MaxValue / 10) * trackBar1.Value);
            uint NewVolumeAllChannels = ((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16);
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void SettingScene_VisibleChanged(object sender, EventArgs e)
        {
            //if (this.Visible == true) _testSound.Play();
            //else _testSound.Stop();
        }
    }
}
