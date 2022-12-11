namespace AhmedKhlif
{
    partial class Buy
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
            this.buyDataGridView = new System.Windows.Forms.DataGridView();
            this.qteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteBuyBtn = new System.Windows.Forms.Button();
            this.ModifyBuyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.BuyProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buyDataGridView
            // 
            this.buyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyDataGridView.Location = new System.Drawing.Point(55, 147);
            this.buyDataGridView.Name = "buyDataGridView";
            this.buyDataGridView.RowHeadersWidth = 51;
            this.buyDataGridView.RowTemplate.Height = 24;
            this.buyDataGridView.Size = new System.Drawing.Size(695, 269);
            this.buyDataGridView.TabIndex = 0;
            this.buyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buyDataGridView_CellContentClick);
            // 
            // qteTextBox
            // 
            this.qteTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qteTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.qteTextBox.Location = new System.Drawing.Point(424, 85);
            this.qteTextBox.Name = "qteTextBox";
            this.qteTextBox.Size = new System.Drawing.Size(100, 22);
            this.qteTextBox.TabIndex = 19;
            // 
            // DeleteBuyBtn
            // 
            this.DeleteBuyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteBuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBuyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBuyBtn.Location = new System.Drawing.Point(207, 71);
            this.DeleteBuyBtn.Name = "DeleteBuyBtn";
            this.DeleteBuyBtn.Size = new System.Drawing.Size(127, 42);
            this.DeleteBuyBtn.TabIndex = 18;
            this.DeleteBuyBtn.Text = "Delete";
            this.DeleteBuyBtn.UseVisualStyleBackColor = false;
            this.DeleteBuyBtn.Click += new System.EventHandler(this.DeleteBuyBtn_Click);
            // 
            // ModifyBuyBtn
            // 
            this.ModifyBuyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModifyBuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyBuyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyBuyBtn.Location = new System.Drawing.Point(56, 71);
            this.ModifyBuyBtn.Name = "ModifyBuyBtn";
            this.ModifyBuyBtn.Size = new System.Drawing.Size(127, 42);
            this.ModifyBuyBtn.TabIndex = 17;
            this.ModifyBuyBtn.Text = "Modify";
            this.ModifyBuyBtn.UseVisualStyleBackColor = false;
            this.ModifyBuyBtn.Click += new System.EventHandler(this.ModifyBuyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantity";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(650, 12);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalTextBox.TabIndex = 21;
            this.totalTextBox.Text = "total : ";
            // 
            // BuyProductBtn
            // 
            this.BuyProductBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuyProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyProductBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuyProductBtn.Location = new System.Drawing.Point(498, 12);
            this.BuyProductBtn.Name = "BuyProductBtn";
            this.BuyProductBtn.Size = new System.Drawing.Size(127, 42);
            this.BuyProductBtn.TabIndex = 22;
            this.BuyProductBtn.Text = "Buy";
            this.BuyProductBtn.UseVisualStyleBackColor = false;
            this.BuyProductBtn.Click += new System.EventHandler(this.BuyProductBtn_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BuyProductBtn);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qteTextBox);
            this.Controls.Add(this.DeleteBuyBtn);
            this.Controls.Add(this.ModifyBuyBtn);
            this.Controls.Add(this.buyDataGridView);
            this.Name = "Buy";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Buy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView buyDataGridView;
        private System.Windows.Forms.TextBox qteTextBox;
        private System.Windows.Forms.Button DeleteBuyBtn;
        private System.Windows.Forms.Button ModifyBuyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button BuyProductBtn;
    }
}