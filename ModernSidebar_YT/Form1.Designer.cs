namespace ModernSidebar_YT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Topbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient_SidebarPanel1 = new ModernSidebar_YT.Gradient_SidebarPanel();
            this.Settings = new ModernSidebar_YT.ucMenu();
            this.About = new ModernSidebar_YT.ucMenu();
            this.Home = new ModernSidebar_YT.ucMenu();
            this.Topbar.SuspendLayout();
            this.gradient_SidebarPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topbar
            // 
            this.Topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Topbar.Controls.Add(this.label1);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(1163, 30);
            this.Topbar.TabIndex = 0;
            this.Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.Topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.Topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modern Sidebar";
            // 
            // gradient_SidebarPanel1
            // 
            this.gradient_SidebarPanel1.Controls.Add(this.Settings);
            this.gradient_SidebarPanel1.Controls.Add(this.About);
            this.gradient_SidebarPanel1.Controls.Add(this.Home);
            this.gradient_SidebarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradient_SidebarPanel1.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.gradient_SidebarPanel1.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(48)))));
            this.gradient_SidebarPanel1.Location = new System.Drawing.Point(0, 30);
            this.gradient_SidebarPanel1.Name = "gradient_SidebarPanel1";
            this.gradient_SidebarPanel1.Size = new System.Drawing.Size(92, 644);
            this.gradient_SidebarPanel1.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BorderColor = System.Drawing.Color.Transparent;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Icon = ((System.Drawing.Image)(resources.GetObject("Settings.Icon")));
            this.Settings.Location = new System.Drawing.Point(0, 175);
            this.Settings.Menu = "Settings";
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(94, 52);
            this.Settings.TabIndex = 2;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.BorderColor = System.Drawing.Color.Transparent;
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.Icon = ((System.Drawing.Image)(resources.GetObject("About.Icon")));
            this.About.Location = new System.Drawing.Point(0, 114);
            this.About.Menu = "About";
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 52);
            this.About.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BorderColor = System.Drawing.Color.Transparent;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Icon = ((System.Drawing.Image)(resources.GetObject("Home.Icon")));
            this.Home.Location = new System.Drawing.Point(0, 56);
            this.Home.Menu = "Home";
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(94, 52);
            this.Home.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 674);
            this.Controls.Add(this.gradient_SidebarPanel1);
            this.Controls.Add(this.Topbar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Topbar.ResumeLayout(false);
            this.Topbar.PerformLayout();
            this.gradient_SidebarPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label label1;
        private Gradient_SidebarPanel gradient_SidebarPanel1;
        private ucMenu Settings;
        private ucMenu About;
        private ucMenu Home;
    }
}

