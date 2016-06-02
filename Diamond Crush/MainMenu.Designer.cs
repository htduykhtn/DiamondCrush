using System.Windows.Forms;

namespace Diamond_Crush
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_playy = new System.Windows.Forms.Label();
            this.label_shop = new System.Windows.Forms.Label();
            this.lable_setting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_welcom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timerGameLoop);
            // 
            // label_playy
            // 
            this.label_playy.BackColor = System.Drawing.Color.Transparent;
            this.label_playy.Location = new System.Drawing.Point(308, 335);
            this.label_playy.Name = "label_playy";
            this.label_playy.Size = new System.Drawing.Size(211, 116);
            this.label_playy.TabIndex = 0;
            this.label_playy.Click += new System.EventHandler(this.label_playy_Click);
            // 
            // label_shop
            // 
            this.label_shop.BackColor = System.Drawing.Color.Transparent;
            this.label_shop.Location = new System.Drawing.Point(296, 466);
            this.label_shop.Name = "label_shop";
            this.label_shop.Size = new System.Drawing.Size(75, 75);
            this.label_shop.TabIndex = 0;
            this.label_shop.Click += new System.EventHandler(this.label_shop_Click);
            // 
            // lable_setting
            // 
            this.lable_setting.BackColor = System.Drawing.Color.Transparent;
            this.lable_setting.Location = new System.Drawing.Point(460, 466);
            this.lable_setting.Name = "lable_setting";
            this.lable_setting.Size = new System.Drawing.Size(75, 75);
            this.lable_setting.TabIndex = 0;
            this.lable_setting.Click += new System.EventHandler(this.lable_setting_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Diamond_Crush.Properties.Resources.wooden_sign_150x140;
            this.label1.Location = new System.Drawing.Point(551, 401);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 40, 0, 0);
            this.label1.Size = new System.Drawing.Size(150, 140);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_welcom
            // 
            this.lab_welcom.BackColor = System.Drawing.Color.Transparent;
            this.lab_welcom.Font = new System.Drawing.Font("SketchFlow Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_welcom.Location = new System.Drawing.Point(308, 102);
            this.lab_welcom.Name = "lab_welcom";
            this.lab_welcom.Size = new System.Drawing.Size(217, 37);
            this.lab_welcom.TabIndex = 2;
            this.lab_welcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Diamond_Crush.Properties.Resources.main_menu_mine_780x640;
            this.ClientSize = new System.Drawing.Size(760, 598);
            this.ControlBox = false;
            this.Controls.Add(this.lab_welcom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable_setting);
            this.Controls.Add(this.label_shop);
            this.Controls.Add(this.label_playy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(780, 640);
            this.MinimumSize = new System.Drawing.Size(780, 640);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diamond Crush";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_playy;
        private System.Windows.Forms.Label label_shop;
        private System.Windows.Forms.Label lable_setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_welcom;
    }
}

