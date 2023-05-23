namespace Library_Management_System.Forms
{
    partial class UpdateBookForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.copiesText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cidText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ISBNText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.bNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(261, 415);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(165, 58);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(449, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(165, 58);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "No. of Copies:";
            // 
            // copiesText
            // 
            this.copiesText.Location = new System.Drawing.Point(218, 332);
            this.copiesText.Name = "copiesText";
            this.copiesText.Size = new System.Drawing.Size(396, 35);
            this.copiesText.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Category ID:";
            // 
            // cidText
            // 
            this.cidText.Location = new System.Drawing.Point(218, 280);
            this.cidText.Name = "cidText";
            this.cidText.Size = new System.Drawing.Size(396, 35);
            this.cidText.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Publication Year:";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(218, 230);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(396, 35);
            this.yearText.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Author:";
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(218, 180);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(396, 35);
            this.authorText.TabIndex = 34;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(51, 133);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(142, 29);
            this.passwordLabel.TabIndex = 33;
            this.passwordLabel.Text = "Book Name:";
            // 
            // ISBNText
            // 
            this.ISBNText.Location = new System.Drawing.Point(218, 80);
            this.ISBNText.Name = "ISBNText";
            this.ISBNText.ReadOnly = true;
            this.ISBNText.Size = new System.Drawing.Size(396, 35);
            this.ISBNText.TabIndex = 31;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(58, 86);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(135, 29);
            this.usernameLabel.TabIndex = 32;
            this.usernameLabel.Text = "Book ISBN:";
            // 
            // bNameText
            // 
            this.bNameText.Location = new System.Drawing.Point(218, 130);
            this.bNameText.Name = "bNameText";
            this.bNameText.Size = new System.Drawing.Size(396, 35);
            this.bNameText.TabIndex = 30;
            // 
            // UpdateBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(710, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.copiesText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cidText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.ISBNText);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.bNameText);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Arial Nova", 13.8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(130)))), ((int)(((byte)(40)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateBookForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox copiesText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cidText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox ISBNText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox bNameText;
    }
}