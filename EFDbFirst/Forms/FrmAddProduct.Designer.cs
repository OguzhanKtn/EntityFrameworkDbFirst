namespace EFDbFirst
{
    partial class FrmAddProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtStock = new TextBox();
            txtUnitPrice = new TextBox();
            cmbCategories = new ComboBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 28);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Categories :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 83);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 137);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Stock :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 200);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Unit Price :";
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(184, 137);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(174, 27);
            txtStock.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(185, 199);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(173, 27);
            txtUnitPrice.TabIndex = 6;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(185, 22);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(173, 28);
            cmbCategories.TabIndex = 7;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(264, 286);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 450);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategories);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtStock);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddProduct";
            Text = "FrmAddProduct";
            Load += FrmAddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtStock;
        private TextBox txtUnitPrice;
        private ComboBox cmbCategories;
        private Button btnAdd;
    }
}