namespace AhmedKhlif
{
    partial class Form2
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
            this.Delete = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.ModifyProductBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.nom_prTextBox = new System.Windows.Forms.TextBox();
            this.categ_prTextBox = new System.Windows.Forms.TextBox();
            this.prix_prTextBox = new System.Windows.Forms.TextBox();
            this.Id_prTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(394, -15);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 10);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Modify
            // 
            this.Modify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modify.Location = new System.Drawing.Point(172, -15);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(96, 10);
            this.Modify.TabIndex = 7;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(-50, -15);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(96, 10);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteProductBtn.Location = new System.Drawing.Point(325, 61);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(127, 42);
            this.DeleteProductBtn.TabIndex = 12;
            this.DeleteProductBtn.Text = "Delete";
            this.DeleteProductBtn.UseVisualStyleBackColor = false;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // ModifyProductBtn
            // 
            this.ModifyProductBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ModifyProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyProductBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyProductBtn.Location = new System.Drawing.Point(174, 61);
            this.ModifyProductBtn.Name = "ModifyProductBtn";
            this.ModifyProductBtn.Size = new System.Drawing.Size(127, 42);
            this.ModifyProductBtn.TabIndex = 11;
            this.ModifyProductBtn.Text = "Modify";
            this.ModifyProductBtn.UseVisualStyleBackColor = false;
            this.ModifyProductBtn.Click += new System.EventHandler(this.ModifyProductBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddProductBtn.Location = new System.Drawing.Point(23, 61);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(127, 42);
            this.AddProductBtn.TabIndex = 10;
            this.AddProductBtn.Text = "Add";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Location = new System.Drawing.Point(23, 166);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.RowHeadersWidth = 51;
            this.productsDataGrid.RowTemplate.Height = 24;
            this.productsDataGrid.Size = new System.Drawing.Size(603, 308);
            this.productsDataGrid.TabIndex = 9;
            this.productsDataGrid.DoubleClick += new System.EventHandler(this.productsDataGrid_DoubleClick);
            // 
            // nom_prTextBox
            // 
            this.nom_prTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nom_prTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_prTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.nom_prTextBox.Location = new System.Drawing.Point(526, 61);
            this.nom_prTextBox.Name = "nom_prTextBox";
            this.nom_prTextBox.Size = new System.Drawing.Size(100, 22);
            this.nom_prTextBox.TabIndex = 13;
            // 
            // categ_prTextBox
            // 
            this.categ_prTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categ_prTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categ_prTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.categ_prTextBox.Location = new System.Drawing.Point(526, 117);
            this.categ_prTextBox.Name = "categ_prTextBox";
            this.categ_prTextBox.Size = new System.Drawing.Size(100, 22);
            this.categ_prTextBox.TabIndex = 14;
            // 
            // prix_prTextBox
            // 
            this.prix_prTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prix_prTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prix_prTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.prix_prTextBox.Location = new System.Drawing.Point(526, 89);
            this.prix_prTextBox.Name = "prix_prTextBox";
            this.prix_prTextBox.Size = new System.Drawing.Size(100, 22);
            this.prix_prTextBox.TabIndex = 15;
            // 
            // Id_prTextBox
            // 
            this.Id_prTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Id_prTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Id_prTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Id_prTextBox.Location = new System.Drawing.Point(526, 33);
            this.Id_prTextBox.Name = "Id_prTextBox";
            this.Id_prTextBox.Size = new System.Drawing.Size(100, 22);
            this.Id_prTextBox.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(941, 573);
            this.ControlBox = false;
            this.Controls.Add(this.Id_prTextBox);
            this.Controls.Add(this.prix_prTextBox);
            this.Controls.Add(this.categ_prTextBox);
            this.Controls.Add(this.nom_prTextBox);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.ModifyProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Add);
            this.DisplayHeader = false;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button ModifyProductBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.TextBox nom_prTextBox;
        private System.Windows.Forms.TextBox categ_prTextBox;
        private System.Windows.Forms.TextBox prix_prTextBox;
        private System.Windows.Forms.TextBox Id_prTextBox;
    }
}