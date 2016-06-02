using System.Windows.Forms;
using ClassLibrary1;

namespace Diamond_Crush
{
    partial class SignIn
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
                CUser._staticUsername = "";
                CUser._staticPassword = "";
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.lifeGenerateCount = new Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(299, 178);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(167, 20);
            this.Username.TabIndex = 0;
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameEnter_Press);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(299, 248);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(167, 20);
            this.Password.TabIndex = 1;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordEnter_Press);

            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Diamond_Crush.Properties.Resources.Sign_In_But_110;
            this.pictureBox2.Location = new System.Drawing.Point(170, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 47);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Diamond_Crush.Properties.Resources.Sign_Up_But_110;
            this.pictureBox3.Location = new System.Drawing.Point(342, 355);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 45);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // picBox Exit 
            // 
            this.picBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.picBoxExit.BackgroundImage = Properties.Resources.but_exit_75x75;
            this.picBoxExit.Location = new System.Drawing.Point(0,0);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(75, 75);
            this.picBoxExit.TabIndex = 5;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Click += new System.EventHandler(this.exit_Click);
            this.picBoxExit.BorderStyle = BorderStyle.None;
            this.picBoxExit.BringToFront();
            this.picBoxExit.TabIndex = 0;
            this.picBoxExit.TabStop = false;
            //
            //Life generate timer
            //
            this.lifeGenerateCount.Enabled = false;
            this.lifeGenerateCount.Interval = 1000;
            this.lifeGenerateCount.Tick += new System.EventHandler(this.timer_generateLifeCount);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diamond_Crush.Properties.Resources.Sign_In;
            this.ClientSize = new System.Drawing.Size(624, 473);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBoxExit);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "SignIn";
            this.Text = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.Load += new System.EventHandler(this.sign_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer lifeGenerateCount;
        private System.Windows.Forms.PictureBox picBoxExit;
    }
}