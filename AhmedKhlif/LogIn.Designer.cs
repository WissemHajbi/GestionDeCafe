﻿namespace AhmedKhlif
{
    partial class LogIn
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
            this.nomLabel = new System.Windows.Forms.Label();
            this.MdpLabel = new System.Windows.Forms.Label();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.mdpTextBox = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(65, 46);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(71, 16);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nomhhhhh";
            this.nomLabel.Click += new System.EventHandler(this.nomLabel_Click);
            // 
            // MdpLabel
            // 
            this.MdpLabel.AutoSize = true;
            this.MdpLabel.Location = new System.Drawing.Point(65, 74);
            this.MdpLabel.Name = "MdpLabel";
            this.MdpLabel.Size = new System.Drawing.Size(89, 16);
            this.MdpLabel.TabIndex = 1;
            this.MdpLabel.Text = "Mot de passe";
            // 
            // nomTextBox
            // 
            this.nomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomTextBox.Location = new System.Drawing.Point(210, 46);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(184, 22);
            this.nomTextBox.TabIndex = 2;
            this.nomTextBox.Text = "wissem";
            // 
            // mdpTextBox
            // 
            this.mdpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdpTextBox.Location = new System.Drawing.Point(210, 83);
            this.mdpTextBox.Name = "mdpTextBox";
            this.mdpTextBox.Size = new System.Drawing.Size(184, 22);
            this.mdpTextBox.TabIndex = 3;
            this.mdpTextBox.Text = "wissem123";
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logInBtn.Location = new System.Drawing.Point(319, 154);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 38);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Login";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerBtn.Location = new System.Drawing.Point(400, 154);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 38);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 248);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.mdpTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.MdpLabel);
            this.Controls.Add(this.nomLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label MdpLabel;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox mdpTextBox;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button registerBtn;
    }
}