namespace WinformTest
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sprite_ImageList = new System.Windows.Forms.ImageList(this.components);
            this.timer_selectedSpriteAnimation = new System.Windows.Forms.Timer(this.components);
            this.green_Selected = new System.Windows.Forms.ImageList(this.components);
            this.red_Selected = new System.Windows.Forms.ImageList(this.components);
            this.blue_Selected = new System.Windows.Forms.ImageList(this.components);
            this.orange_Selected = new System.Windows.Forms.ImageList(this.components);
            this.purple_Selected = new System.Windows.Forms.ImageList(this.components);
            this.yellow_Selected = new System.Windows.Forms.ImageList(this.components);
            this.white_Selected = new System.Windows.Forms.ImageList(this.components);
            this.timer_GoSwap = new System.Windows.Forms.Timer(this.components);
            this.timer_SwapBack = new System.Windows.Forms.Timer(this.components);
            this.timer_Explode = new System.Windows.Forms.Timer(this.components);
            this.greenExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.redExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.blueExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.orangeExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.purpleExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.yellowExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.whiteExplode_imgList = new System.Windows.Forms.ImageList(this.components);
            this.timer_updateScreen = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer_scoreCount = new System.Windows.Forms.Timer(this.components);
            this.timer_gameTimeLimit = new System.Windows.Forms.Timer(this.components);
            this.butt_imgList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.life_count_lab = new System.Windows.Forms.Label();
            this.gold_count_lab = new System.Windows.Forms.Label();
            this.life_count_picBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_back_picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.life_count_picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_back_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sprite_ImageList
            // 
            this.sprite_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sprite_ImageList.ImageStream")));
            this.sprite_ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.sprite_ImageList.Images.SetKeyName(0, "green_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(1, "red_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(2, "blue_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(3, "orange_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(4, "purple_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(5, "yellow_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(6, "white_sprite_original_state_50x50.png");
            this.sprite_ImageList.Images.SetKeyName(7, "selectedBoundBox_50x50.png");
            // 
            // timer_selectedSpriteAnimation
            // 
            this.timer_selectedSpriteAnimation.Interval = 115;
            this.timer_selectedSpriteAnimation.Tick += new System.EventHandler(this.timer_selectedSpriteAnimation_Tick);
            // 
            // green_Selected
            // 
            this.green_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("green_Selected.ImageStream")));
            this.green_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.green_Selected.Images.SetKeyName(0, "0.png");
            this.green_Selected.Images.SetKeyName(1, "1.png");
            this.green_Selected.Images.SetKeyName(2, "2.png");
            this.green_Selected.Images.SetKeyName(3, "3.png");
            this.green_Selected.Images.SetKeyName(4, "4.png");
            this.green_Selected.Images.SetKeyName(5, "5.png");
            this.green_Selected.Images.SetKeyName(6, "6.png");
            this.green_Selected.Images.SetKeyName(7, "7.png");
            this.green_Selected.Images.SetKeyName(8, "8.png");
            this.green_Selected.Images.SetKeyName(9, "9.png");
            // 
            // red_Selected
            // 
            this.red_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("red_Selected.ImageStream")));
            this.red_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.red_Selected.Images.SetKeyName(0, "0.png");
            this.red_Selected.Images.SetKeyName(1, "1.png");
            this.red_Selected.Images.SetKeyName(2, "2.png");
            this.red_Selected.Images.SetKeyName(3, "3.png");
            this.red_Selected.Images.SetKeyName(4, "4.png");
            this.red_Selected.Images.SetKeyName(5, "5.png");
            this.red_Selected.Images.SetKeyName(6, "6.png");
            this.red_Selected.Images.SetKeyName(7, "7.png");
            this.red_Selected.Images.SetKeyName(8, "8.png");
            this.red_Selected.Images.SetKeyName(9, "9.png");
            // 
            // blue_Selected
            // 
            this.blue_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("blue_Selected.ImageStream")));
            this.blue_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.blue_Selected.Images.SetKeyName(0, "0.png");
            this.blue_Selected.Images.SetKeyName(1, "1.png");
            this.blue_Selected.Images.SetKeyName(2, "2.png");
            this.blue_Selected.Images.SetKeyName(3, "3.png");
            this.blue_Selected.Images.SetKeyName(4, "4.png");
            this.blue_Selected.Images.SetKeyName(5, "5.png");
            this.blue_Selected.Images.SetKeyName(6, "6.png");
            this.blue_Selected.Images.SetKeyName(7, "7.png");
            this.blue_Selected.Images.SetKeyName(8, "8.png");
            this.blue_Selected.Images.SetKeyName(9, "9.png");
            // 
            // orange_Selected
            // 
            this.orange_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("orange_Selected.ImageStream")));
            this.orange_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.orange_Selected.Images.SetKeyName(0, "0.png");
            this.orange_Selected.Images.SetKeyName(1, "1.png");
            this.orange_Selected.Images.SetKeyName(2, "2.png");
            this.orange_Selected.Images.SetKeyName(3, "3.png");
            this.orange_Selected.Images.SetKeyName(4, "4.png");
            this.orange_Selected.Images.SetKeyName(5, "5.png");
            this.orange_Selected.Images.SetKeyName(6, "6.png");
            this.orange_Selected.Images.SetKeyName(7, "7.png");
            this.orange_Selected.Images.SetKeyName(8, "8.png");
            this.orange_Selected.Images.SetKeyName(9, "9.png");
            // 
            // purple_Selected
            // 
            this.purple_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("purple_Selected.ImageStream")));
            this.purple_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.purple_Selected.Images.SetKeyName(0, "0.png");
            this.purple_Selected.Images.SetKeyName(1, "1.png");
            this.purple_Selected.Images.SetKeyName(2, "2.png");
            this.purple_Selected.Images.SetKeyName(3, "3.png");
            this.purple_Selected.Images.SetKeyName(4, "4.png");
            this.purple_Selected.Images.SetKeyName(5, "5.png");
            this.purple_Selected.Images.SetKeyName(6, "6.png");
            this.purple_Selected.Images.SetKeyName(7, "7.png");
            this.purple_Selected.Images.SetKeyName(8, "8.png");
            this.purple_Selected.Images.SetKeyName(9, "9.png");
            // 
            // yellow_Selected
            // 
            this.yellow_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("yellow_Selected.ImageStream")));
            this.yellow_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.yellow_Selected.Images.SetKeyName(0, "0.png");
            this.yellow_Selected.Images.SetKeyName(1, "1.png");
            this.yellow_Selected.Images.SetKeyName(2, "2.png");
            this.yellow_Selected.Images.SetKeyName(3, "3.png");
            this.yellow_Selected.Images.SetKeyName(4, "4.png");
            this.yellow_Selected.Images.SetKeyName(5, "5.png");
            this.yellow_Selected.Images.SetKeyName(6, "6.png");
            this.yellow_Selected.Images.SetKeyName(7, "7.png");
            this.yellow_Selected.Images.SetKeyName(8, "8.png");
            this.yellow_Selected.Images.SetKeyName(9, "9.png");
            // 
            // white_Selected
            // 
            this.white_Selected.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("white_Selected.ImageStream")));
            this.white_Selected.TransparentColor = System.Drawing.Color.Transparent;
            this.white_Selected.Images.SetKeyName(0, "0.png");
            this.white_Selected.Images.SetKeyName(1, "1.png");
            this.white_Selected.Images.SetKeyName(2, "2.png");
            this.white_Selected.Images.SetKeyName(3, "3.png");
            this.white_Selected.Images.SetKeyName(4, "4.png");
            this.white_Selected.Images.SetKeyName(5, "5.png");
            this.white_Selected.Images.SetKeyName(6, "6.png");
            this.white_Selected.Images.SetKeyName(7, "7.png");
            this.white_Selected.Images.SetKeyName(8, "8.png");
            this.white_Selected.Images.SetKeyName(9, "9.png");
            this.white_Selected.Images.SetKeyName(10, "10.png");
            this.white_Selected.Images.SetKeyName(11, "11.png");
            this.white_Selected.Images.SetKeyName(12, "12.png");
            this.white_Selected.Images.SetKeyName(13, "13.png");
            this.white_Selected.Images.SetKeyName(14, "14.png");
            this.white_Selected.Images.SetKeyName(15, "15.png");
            this.white_Selected.Images.SetKeyName(16, "16.png");
            this.white_Selected.Images.SetKeyName(17, "17.png");
            this.white_Selected.Images.SetKeyName(18, "18.png");
            this.white_Selected.Images.SetKeyName(19, "19.png");
            // 
            // timer_GoSwap
            // 
            this.timer_GoSwap.Interval = 50;
            this.timer_GoSwap.Tick += new System.EventHandler(this.timer_swappingGem_Tick);
            // 
            // timer_SwapBack
            // 
            this.timer_SwapBack.Interval = 50;
            this.timer_SwapBack.Tick += new System.EventHandler(this.timer_SwapBack_Tick);
            // 
            // timer_Explode
            // 
            this.timer_Explode.Interval = 35;
            this.timer_Explode.Tick += new System.EventHandler(this.timer_Explode_Tick);
            // 
            // greenExplode_imgList
            // 
            this.greenExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("greenExplode_imgList.ImageStream")));
            this.greenExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.greenExplode_imgList.Images.SetKeyName(0, "0.png");
            this.greenExplode_imgList.Images.SetKeyName(1, "1.png");
            this.greenExplode_imgList.Images.SetKeyName(2, "2.png");
            this.greenExplode_imgList.Images.SetKeyName(3, "3.png");
            this.greenExplode_imgList.Images.SetKeyName(4, "4.png");
            this.greenExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // redExplode_imgList
            // 
            this.redExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("redExplode_imgList.ImageStream")));
            this.redExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.redExplode_imgList.Images.SetKeyName(0, "0.png");
            this.redExplode_imgList.Images.SetKeyName(1, "1.png");
            this.redExplode_imgList.Images.SetKeyName(2, "2.png");
            this.redExplode_imgList.Images.SetKeyName(3, "3.png");
            this.redExplode_imgList.Images.SetKeyName(4, "4.png");
            this.redExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // blueExplode_imgList
            // 
            this.blueExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("blueExplode_imgList.ImageStream")));
            this.blueExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.blueExplode_imgList.Images.SetKeyName(0, "0.png");
            this.blueExplode_imgList.Images.SetKeyName(1, "1.png");
            this.blueExplode_imgList.Images.SetKeyName(2, "2.png");
            this.blueExplode_imgList.Images.SetKeyName(3, "3.png");
            this.blueExplode_imgList.Images.SetKeyName(4, "4.png");
            this.blueExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // orangeExplode_imgList
            // 
            this.orangeExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("orangeExplode_imgList.ImageStream")));
            this.orangeExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.orangeExplode_imgList.Images.SetKeyName(0, "0.png");
            this.orangeExplode_imgList.Images.SetKeyName(1, "1.png");
            this.orangeExplode_imgList.Images.SetKeyName(2, "2.png");
            this.orangeExplode_imgList.Images.SetKeyName(3, "3.png");
            this.orangeExplode_imgList.Images.SetKeyName(4, "4.png");
            this.orangeExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // purpleExplode_imgList
            // 
            this.purpleExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("purpleExplode_imgList.ImageStream")));
            this.purpleExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.purpleExplode_imgList.Images.SetKeyName(0, "0.png");
            this.purpleExplode_imgList.Images.SetKeyName(1, "1.png");
            this.purpleExplode_imgList.Images.SetKeyName(2, "2.png");
            this.purpleExplode_imgList.Images.SetKeyName(3, "3.png");
            this.purpleExplode_imgList.Images.SetKeyName(4, "4.png");
            this.purpleExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // yellowExplode_imgList
            // 
            this.yellowExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("yellowExplode_imgList.ImageStream")));
            this.yellowExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.yellowExplode_imgList.Images.SetKeyName(0, "0.png");
            this.yellowExplode_imgList.Images.SetKeyName(1, "1.png");
            this.yellowExplode_imgList.Images.SetKeyName(2, "2.png");
            this.yellowExplode_imgList.Images.SetKeyName(3, "3.png");
            this.yellowExplode_imgList.Images.SetKeyName(4, "4.png");
            this.yellowExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // whiteExplode_imgList
            // 
            this.whiteExplode_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("whiteExplode_imgList.ImageStream")));
            this.whiteExplode_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.whiteExplode_imgList.Images.SetKeyName(0, "0.png");
            this.whiteExplode_imgList.Images.SetKeyName(1, "1.png");
            this.whiteExplode_imgList.Images.SetKeyName(2, "2.png");
            this.whiteExplode_imgList.Images.SetKeyName(3, "3.png");
            this.whiteExplode_imgList.Images.SetKeyName(4, "4.png");
            this.whiteExplode_imgList.Images.SetKeyName(5, "5.png");
            // 
            // timer_updateScreen
            // 
            this.timer_updateScreen.Interval = 35;
            this.timer_updateScreen.Tick += new System.EventHandler(this.timer_updateScreen_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(97, 564);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(486, 26);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 100;
            // 
            // timer_scoreCount
            // 
            this.timer_scoreCount.Enabled = true;
            this.timer_scoreCount.Interval = 1;
            this.timer_scoreCount.Tick += new System.EventHandler(this.timer_scoreCount_Tick);
            // 
            // timer_gameTimeLimit
            // 
            this.timer_gameTimeLimit.Enabled = true;
            this.timer_gameTimeLimit.Interval = 600;
            this.timer_gameTimeLimit.Tick += new System.EventHandler(this.timer_gameTimeLimit_Tick);
            // 
            // butt_imgList
            // 
            this.butt_imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("butt_imgList.ImageStream")));
            this.butt_imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.butt_imgList.Images.SetKeyName(0, "but_home_75x75.png");
            this.butt_imgList.Images.SetKeyName(1, "but_play_75x75.png");
            this.butt_imgList.Images.SetKeyName(2, "but_replay_75x75.png");
            this.butt_imgList.Images.SetKeyName(3, "but_resume_75x75.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target         : ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::WinformTest.Properties.Resources.grid_diamond_container_400x400;
            this.label1.Location = new System.Drawing.Point(144, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 400);
            this.label1.TabIndex = 0;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last score   :";
            // 
            // life_count_lab
            // 
            this.life_count_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.life_count_lab.Location = new System.Drawing.Point(131, 11);
            this.life_count_lab.Name = "life_count_lab";
            this.life_count_lab.Size = new System.Drawing.Size(80, 40);
            this.life_count_lab.TabIndex = 5;
            this.life_count_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gold_count_lab
            // 
            this.gold_count_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gold_count_lab.Location = new System.Drawing.Point(131, 50);
            this.gold_count_lab.Name = "gold_count_lab";
            this.gold_count_lab.Size = new System.Drawing.Size(80, 40);
            this.gold_count_lab.TabIndex = 5;
            this.gold_count_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // life_count_picBox
            // 
            this.life_count_picBox.BackColor = System.Drawing.Color.Transparent;
            this.life_count_picBox.BackgroundImage = global::WinformTest.Properties.Resources.heart_40x40;
            this.life_count_picBox.Location = new System.Drawing.Point(85, 10);
            this.life_count_picBox.Name = "life_count_picBox";
            this.life_count_picBox.Size = new System.Drawing.Size(40, 40);
            this.life_count_picBox.TabIndex = 6;
            this.life_count_picBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinformTest.Properties.Resources.coin_40x40;
            this.pictureBox1.Location = new System.Drawing.Point(85, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // but_back_picBox
            // 
            this.but_back_picBox.BackColor = System.Drawing.Color.Transparent;
            this.but_back_picBox.BackgroundImage = global::WinformTest.Properties.Resources.but_back_75x75;
            this.but_back_picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_back_picBox.Location = new System.Drawing.Point(10, 10);
            this.but_back_picBox.Name = "but_back_picBox";
            this.but_back_picBox.Size = new System.Drawing.Size(75, 75);
            this.but_back_picBox.TabIndex = 6;
            this.but_back_picBox.TabStop = false;
            this.but_back_picBox.UseWaitCursor = true;
            this.but_back_picBox.Click += new System.EventHandler(this.but_back_picBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(764, 602);
            this.ControlBox = false;
            this.Controls.Add(this.but_back_picBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.life_count_picBox);
            this.Controls.Add(this.gold_count_lab);
            this.Controls.Add(this.life_count_lab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(780, 640);
            this.MinimumSize = new System.Drawing.Size(780, 640);
            this.Name = "Form1";
            this.Text = "Diamond Crush";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.life_count_picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.but_back_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList sprite_ImageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_selectedSpriteAnimation;
        private System.Windows.Forms.ImageList green_Selected;
        private System.Windows.Forms.ImageList red_Selected;
        private System.Windows.Forms.ImageList blue_Selected;
        private System.Windows.Forms.ImageList orange_Selected;
        private System.Windows.Forms.ImageList purple_Selected;
        private System.Windows.Forms.ImageList yellow_Selected;
        private System.Windows.Forms.ImageList white_Selected;
        private System.Windows.Forms.Timer timer_GoSwap;
        private System.Windows.Forms.Timer timer_SwapBack;
        private System.Windows.Forms.Timer timer_Explode;
        private System.Windows.Forms.ImageList greenExplode_imgList;
        private System.Windows.Forms.ImageList redExplode_imgList;
        private System.Windows.Forms.ImageList blueExplode_imgList;
        private System.Windows.Forms.ImageList orangeExplode_imgList;
        private System.Windows.Forms.ImageList purpleExplode_imgList;
        private System.Windows.Forms.ImageList yellowExplode_imgList;
        private System.Windows.Forms.ImageList whiteExplode_imgList;
        private System.Windows.Forms.Timer timer_updateScreen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer_scoreCount;
        private System.Windows.Forms.Timer timer_gameTimeLimit;
        private System.Windows.Forms.ImageList butt_imgList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label life_count_lab;
        private System.Windows.Forms.Label gold_count_lab;
        private System.Windows.Forms.PictureBox life_count_picBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox but_back_picBox;
    }
}

