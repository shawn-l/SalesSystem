namespace SalesSystem
{
    partial class PurchaseForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.purchasePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.purchaseInsert = new System.Windows.Forms.Button();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.supplierListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "买入价格";
            // 
            // purchasePrice
            // 
            this.purchasePrice.Location = new System.Drawing.Point(150, 61);
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.Size = new System.Drawing.Size(100, 21);
            this.purchasePrice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "数量";
            // 
            // purchaseQuantity
            // 
            this.purchaseQuantity.Location = new System.Drawing.Point(150, 99);
            this.purchaseQuantity.Name = "purchaseQuantity";
            this.purchaseQuantity.Size = new System.Drawing.Size(79, 21);
            this.purchaseQuantity.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "商品";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "供应商";
            // 
            // purchaseInsert
            // 
            this.purchaseInsert.Location = new System.Drawing.Point(117, 205);
            this.purchaseInsert.Name = "purchaseInsert";
            this.purchaseInsert.Size = new System.Drawing.Size(75, 23);
            this.purchaseInsert.TabIndex = 11;
            this.purchaseInsert.Text = "添加";
            this.purchaseInsert.UseVisualStyleBackColor = true;
            this.purchaseInsert.Click += new System.EventHandler(this.purchaseInsert_Click);
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 12;
            this.productListBox.Location = new System.Drawing.Point(150, 20);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(120, 28);
            this.productListBox.TabIndex = 12;
            // 
            // supplierListBox
            // 
            this.supplierListBox.FormattingEnabled = true;
            this.supplierListBox.ItemHeight = 12;
            this.supplierListBox.Location = new System.Drawing.Point(150, 140);
            this.supplierListBox.Name = "supplierListBox";
            this.supplierListBox.Size = new System.Drawing.Size(120, 28);
            this.supplierListBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.supplierListBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.productListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.purchaseInsert);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.purchaseQuantity);
            this.groupBox1.Controls.Add(this.purchasePrice);
            this.groupBox1.Location = new System.Drawing.Point(19, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 247);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进货单";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseListForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox purchasePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox purchaseQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button purchaseInsert;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.ListBox supplierListBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}