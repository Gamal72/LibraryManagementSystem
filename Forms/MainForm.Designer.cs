namespace Library_Management_System
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.logoutBtnDashboard = new System.Windows.Forms.Button();
            this.profileBtnDashboard = new System.Windows.Forms.Button();
            this.borrowalsBtnDashboard = new System.Windows.Forms.Button();
            this.browseBtnDashboard = new System.Windows.Forms.Button();
            this.registerBtnDashboard = new System.Windows.Forms.Button();
            this.loginBtnDashboard = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.picPanel = new System.Windows.Forms.Panel();
            this.reportButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.picPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(202, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(710, 164);
            this.topPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(129, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 93);
            this.label2.TabIndex = 0;
            this.label2.Text = "FCAI Library";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dashboardPanel.AutoScroll = true;
            this.dashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.dashboardPanel.Controls.Add(this.reportButton);
            this.dashboardPanel.Controls.Add(this.logoutBtnDashboard);
            this.dashboardPanel.Controls.Add(this.profileBtnDashboard);
            this.dashboardPanel.Controls.Add(this.borrowalsBtnDashboard);
            this.dashboardPanel.Controls.Add(this.browseBtnDashboard);
            this.dashboardPanel.Controls.Add(this.registerBtnDashboard);
            this.dashboardPanel.Controls.Add(this.loginBtnDashboard);
            this.dashboardPanel.Location = new System.Drawing.Point(0, 163);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(202, 540);
            this.dashboardPanel.TabIndex = 0;
            // 
            // logoutBtnDashboard
            // 
            this.logoutBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.logoutBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.logoutBtnDashboard.Location = new System.Drawing.Point(0, 356);
            this.logoutBtnDashboard.Name = "logoutBtnDashboard";
            this.logoutBtnDashboard.Size = new System.Drawing.Size(202, 72);
            this.logoutBtnDashboard.TabIndex = 8;
            this.logoutBtnDashboard.Text = "Logout";
            this.logoutBtnDashboard.UseVisualStyleBackColor = false;
            this.logoutBtnDashboard.Click += new System.EventHandler(this.logoutBtnDashboard_Click);
            // 
            // profileBtnDashboard
            // 
            this.profileBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.profileBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.profileBtnDashboard.Location = new System.Drawing.Point(0, 284);
            this.profileBtnDashboard.Name = "profileBtnDashboard";
            this.profileBtnDashboard.Size = new System.Drawing.Size(202, 72);
            this.profileBtnDashboard.TabIndex = 7;
            this.profileBtnDashboard.Text = "Profile";
            this.profileBtnDashboard.UseVisualStyleBackColor = false;
            this.profileBtnDashboard.Click += new System.EventHandler(this.profileBtnDashboard_Click);
            // 
            // borrowalsBtnDashboard
            // 
            this.borrowalsBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.borrowalsBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.borrowalsBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowalsBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.borrowalsBtnDashboard.Location = new System.Drawing.Point(0, 214);
            this.borrowalsBtnDashboard.Name = "borrowalsBtnDashboard";
            this.borrowalsBtnDashboard.Size = new System.Drawing.Size(202, 70);
            this.borrowalsBtnDashboard.TabIndex = 4;
            this.borrowalsBtnDashboard.Text = "Past Borrowals";
            this.borrowalsBtnDashboard.UseVisualStyleBackColor = false;
            this.borrowalsBtnDashboard.Click += new System.EventHandler(this.borrowalsBtnDashboard_Click);
            // 
            // browseBtnDashboard
            // 
            this.browseBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.browseBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.browseBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.browseBtnDashboard.Location = new System.Drawing.Point(0, 144);
            this.browseBtnDashboard.Name = "browseBtnDashboard";
            this.browseBtnDashboard.Size = new System.Drawing.Size(202, 70);
            this.browseBtnDashboard.TabIndex = 3;
            this.browseBtnDashboard.Text = "Browse Books";
            this.browseBtnDashboard.UseVisualStyleBackColor = false;
            this.browseBtnDashboard.Click += new System.EventHandler(this.browseBtnDashboard_Click);
            // 
            // registerBtnDashboard
            // 
            this.registerBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.registerBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.registerBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.registerBtnDashboard.Location = new System.Drawing.Point(0, 74);
            this.registerBtnDashboard.Name = "registerBtnDashboard";
            this.registerBtnDashboard.Size = new System.Drawing.Size(202, 70);
            this.registerBtnDashboard.TabIndex = 2;
            this.registerBtnDashboard.Text = "Register";
            this.registerBtnDashboard.UseVisualStyleBackColor = false;
            this.registerBtnDashboard.Click += new System.EventHandler(this.Register_Click);
            // 
            // loginBtnDashboard
            // 
            this.loginBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.loginBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginBtnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.loginBtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.loginBtnDashboard.Name = "loginBtnDashboard";
            this.loginBtnDashboard.Size = new System.Drawing.Size(202, 74);
            this.loginBtnDashboard.TabIndex = 1;
            this.loginBtnDashboard.Text = "Login";
            this.loginBtnDashboard.UseVisualStyleBackColor = false;
            this.loginBtnDashboard.Click += new System.EventHandler(this.Login_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.childFormPanel);
            this.MainPanel.Controls.Add(this.topPanel);
            this.MainPanel.Controls.Add(this.picPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(912, 703);
            this.MainPanel.TabIndex = 8;
            // 
            // childFormPanel
            // 
            this.childFormPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(202, 164);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(710, 539);
            this.childFormPanel.TabIndex = 9;
            // 
            // picPanel
            // 
            this.picPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.picPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPanel.BackgroundImage")));
            this.picPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPanel.Controls.Add(this.dashboardPanel);
            this.picPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.picPanel.Location = new System.Drawing.Point(0, 0);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(202, 703);
            this.picPanel.TabIndex = 8;
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.ForeColor = System.Drawing.Color.White;
            this.reportButton.Location = new System.Drawing.Point(0, 428);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(202, 72);
            this.reportButton.TabIndex = 9;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(912, 703);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Arial Nova", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(930, 750);
            this.MinimumSize = new System.Drawing.Size(930, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCAI Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.picPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Button registerBtnDashboard;
        private System.Windows.Forms.Button loginBtnDashboard;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.Button profileBtnDashboard;
        private System.Windows.Forms.Button borrowalsBtnDashboard;
        private System.Windows.Forms.Button browseBtnDashboard;
        private System.Windows.Forms.Button logoutBtnDashboard;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Button reportButton;
    }
}

