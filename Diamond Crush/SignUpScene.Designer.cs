namespace Diamond_Crush
{
    partial class SignUp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Diamond_Crush.Properties.Resources.but_exit_75x75;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Diamond_Crush.Properties.Resources.Sign_Up_But_180;
            this.pictureBox2.Location = new System.Drawing.Point(231, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 72);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(292, 166);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(176, 20);
            this.Username.TabIndex = 2;
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_enter_Press);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(292, 231);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(176, 20);
            this.Password.TabIndex = 3;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_enter_Press);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(292, 290);
            this.Confirm.Name = "Confirm";
            this.Confirm.PasswordChar = '*';
            this.Confirm.Size = new System.Drawing.Size(176, 20);
            this.Confirm.TabIndex = 4;
            this.Confirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirm_enter_Press);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Diamond_Crush.Properties.Resources.Sign_Up;
            this.ClientSize = new System.Drawing.Size(624, 473);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Sign Up";
            this.ControlBox = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Confirm;
    }
}

