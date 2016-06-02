namespace Diamond_Crush
{
    partial class ShopScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopScene));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox_life = new System.Windows.Forms.PictureBox();
            this.picBox_coin = new System.Windows.Forms.PictureBox();
            this.harmmer_label = new System.Windows.Forms.Label();
            this.flash_label = new System.Windows.Forms.Label();
            this.sandclock_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_life)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_coin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Image = global::Diamond_Crush.Properties.Resources.coin_40x40;
            this.label1.Location = new System.Drawing.Point(164, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "x60";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Image = global::Diamond_Crush.Properties.Resources.coin_40x40;
            this.label2.Location = new System.Drawing.Point(164, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "x70";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Image = global::Diamond_Crush.Properties.Resources.coin_40x40;
            this.label3.Location = new System.Drawing.Point(164, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "x50";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_life
            // 
            this.picBox_life.BackColor = System.Drawing.Color.Transparent;
            this.picBox_life.BackgroundImage = global::Diamond_Crush.Properties.Resources.heart_40x40;
            this.picBox_life.ImageLocation = "";
            this.picBox_life.Location = new System.Drawing.Point(77, 0);
            this.picBox_life.Name = "picBox_life";
            this.picBox_life.Size = new System.Drawing.Size(40, 40);
            this.picBox_life.TabIndex = 5;
            this.picBox_life.TabStop = false;
            // 
            // picBox_coin
            // 
            this.picBox_coin.BackColor = System.Drawing.Color.Transparent;
            this.picBox_coin.BackgroundImage = global::Diamond_Crush.Properties.Resources.coin_40x40;
            this.picBox_coin.ImageLocation = "";
            this.picBox_coin.Location = new System.Drawing.Point(77, 36);
            this.picBox_coin.Name = "picBox_coin";
            this.picBox_coin.Size = new System.Drawing.Size(40, 40);
            this.picBox_coin.TabIndex = 5;
            this.picBox_coin.TabStop = false;
            // 
            // harmmer_label
            // 
            this.harmmer_label.AutoSize = true;
            this.harmmer_label.BackColor = System.Drawing.Color.Transparent;
            this.harmmer_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.harmmer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harmmer_label.Location = new System.Drawing.Point(210, 179);
            this.harmmer_label.Name = "harmmer_label";
            this.harmmer_label.Size = new System.Drawing.Size(101, 24);
            this.harmmer_label.TabIndex = 6;
            this.harmmer_label.Text = "(You have ";
            // 
            // flash_label
            // 
            this.flash_label.AutoSize = true;
            this.flash_label.BackColor = System.Drawing.Color.Transparent;
            this.flash_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flash_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flash_label.Location = new System.Drawing.Point(210, 270);
            this.flash_label.Name = "flash_label";
            this.flash_label.Size = new System.Drawing.Size(101, 24);
            this.flash_label.TabIndex = 6;
            this.flash_label.Text = "(You have ";
            // 
            // sandclock_label
            // 
            this.sandclock_label.AutoSize = true;
            this.sandclock_label.BackColor = System.Drawing.Color.Transparent;
            this.sandclock_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sandclock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sandclock_label.Location = new System.Drawing.Point(210, 360);
            this.sandclock_label.Name = "sandclock_label";
            this.sandclock_label.Size = new System.Drawing.Size(101, 24);
            this.sandclock_label.TabIndex = 6;
            this.sandclock_label.Text = "(You have ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShopScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diamond_Crush.Properties.Resources.shelf_512x512;
            this.ClientSize = new System.Drawing.Size(496, 474);
            this.ControlBox = false;
            this.Controls.Add(this.sandclock_label);
            this.Controls.Add(this.flash_label);
            this.Controls.Add(this.harmmer_label);
            this.Controls.Add(this.picBox_coin);
            this.Controls.Add(this.picBox_life);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(512, 512);
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "ShopScene";
            this.Text = "Diamond Crush";
            this.VisibleChanged += new System.EventHandler(this.ShopScene_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShopScene_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_life)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_life;
        private System.Windows.Forms.PictureBox picBox_coin;
        private System.Windows.Forms.Label harmmer_label;
        private System.Windows.Forms.Label flash_label;
        private System.Windows.Forms.Label sandclock_label;
        private System.Windows.Forms.Timer timer1;
    }
}