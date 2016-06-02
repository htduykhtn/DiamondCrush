using ClassLibrary1;
using System.Drawing;

namespace Diamond_Crush
{
    partial class PickLevelScene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public static Point GetLevelLocation(uint levelID)
        {
            int X, Y;
            int _div = (int)levelID / 3;
            int _mod = (int)levelID % 3;
            X = 137 + (_mod)*(140+30)  ;
            Y=101+_div *(140+30);
            return new Point(X, Y);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickLevelScene));
            this.picBox_but_home = new System.Windows.Forms.PictureBox();
            this.levelState_imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_but_home)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_but_home
            // 
            this.picBox_but_home.BackColor = System.Drawing.Color.Transparent;
            this.picBox_but_home.BackgroundImage = global::Diamond_Crush.Properties.Resources.but_home_75x75;
            this.picBox_but_home.Location = new System.Drawing.Point(12, 12);
            this.picBox_but_home.Name = "picBox_but_home";
            this.picBox_but_home.Size = new System.Drawing.Size(75, 75);
            this.picBox_but_home.TabIndex = 0;
            this.picBox_but_home.TabStop = false;
            this.picBox_but_home.Click += new System.EventHandler(this.picBox_but_home_Click);
            // 
            // levelState_imageList
            // 
            this.levelState_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("levelState_imageList.ImageStream")));
            this.levelState_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.levelState_imageList.Images.SetKeyName(0, "level_1_unlocked_140x140.png");
            this.levelState_imageList.Images.SetKeyName(1, "level_2_unlock_140x140.png");
            this.levelState_imageList.Images.SetKeyName(2, "level_3_unlock_140x140.png");
            this.levelState_imageList.Images.SetKeyName(3, "level_4_unlock_140x140.png");
            this.levelState_imageList.Images.SetKeyName(4, "level_5_unlocked_140x140.png");
            this.levelState_imageList.Images.SetKeyName(5, "level_6_unlocked_140x140.png");
            this.levelState_imageList.Images.SetKeyName(6, "level_7_unlocked_140x140.png");
            this.levelState_imageList.Images.SetKeyName(7, "level_8_unlocked_140x140.png");
            this.levelState_imageList.Images.SetKeyName(8, "level_9_unlocked_140x140.png");
            this.levelState_imageList.Images.SetKeyName(9, "level_locked_140x140.png");
            // 
            // PickLevelScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diamond_Crush.Properties.Resources.ground_cartoon_780x640;
            this.ClientSize = new System.Drawing.Size(764, 602);
            this.ControlBox = false;
            this.Controls.Add(this.picBox_but_home);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(780, 640);
            this.MinimumSize = new System.Drawing.Size(780, 640);
            this.Name = "PickLevelScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Level";
            this.VisibleChanged += new System.EventHandler(this.PickLevelScene_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PickLevelScene_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_but_home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_but_home;
        private System.Windows.Forms.ImageList levelState_imageList;
    }
}