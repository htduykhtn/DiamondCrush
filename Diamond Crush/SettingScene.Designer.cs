namespace Diamond_Crush
{
    partial class SettingScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingScene));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.fb_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.BackColor = System.Drawing.Color.SandyBrown;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // fb_logout
            // 
            this.fb_logout.BackgroundImage = global::Diamond_Crush.Properties.Resources.logout_180x50;
            resources.ApplyResources(this.fb_logout, "fb_logout");
            this.fb_logout.Name = "fb_logout";
            this.fb_logout.UseVisualStyleBackColor = true;
            // 
            // SettingScene
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diamond_Crush.Properties.Resources.setting_background;
            this.ControlBox = false;
            this.Controls.Add(this.fb_logout);
            this.Controls.Add(this.trackBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingScene";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.SettingScene_Load);
            this.VisibleChanged += new System.EventHandler(this.SettingScene_VisibleChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SettingScene_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button fb_logout;
    }
}