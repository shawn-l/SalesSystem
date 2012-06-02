namespace SalesSystem
{
    partial class PurchaseListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.purchasePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.purchaseQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.purchaseInsert = new System.Windows.Forms.Button();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.supplierListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // purchaseId
            // 
            this.purchaseId.Location = new System.Drawing.Point(41, 40);
            this.purchaseId.Name = "purchaseId";
            this.purchaseId.Size = new System.Drawing.Size(100, 21);
            this.purchaseId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "price";
            // 
            // purchasePrice
            // 
            this.purchasePrice.Location = new System.Drawing.Point(41, 70);
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.Size = new System.Drawing.Size(100, 21);
            this.purchasePrice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // purchaseQuantity
            // 
            this.purchaseQuantity.Location = new System.Drawing.Point(62, 108);
            this.purchaseQuantity.Name = "purchaseQuantity";
            this.purchaseQuantity.Size = new System.Drawing.Size(79, 21);
            this.purchaseQuantity.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "ProductId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "SupplierId";
            // 
            // purchaseInsert
            // 
            this.purchaseInsert.Location = new System.Drawing.Point(28, 182);
            this.purchaseInsert.Name = "purchaseInsert";
            this.purchaseInsert.Size = new System.Drawing.Size(75, 23);
            this.purchaseInsert.TabIndex = 11;
            this.purchaseInsert.Text = "Insert";
            this.purchaseInsert.UseVisualStyleBackColor = true;
            this.purchaseInsert.Click += new System.EventHandler(this.purchaseInsert_Click);
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 12;
            this.productListBox.Location = new System.Drawing.Point(152, 40);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(120, 64);
            this.productListBox.TabIndex = 12;
            // 
            // supplierListBox
            // 
            this.supplierListBox.FormattingEnabled = true;
            this.supplierListBox.ItemHeight = 12;
            this.supplierListBox.Location = new System.Drawing.Point(152, 129);
            this.supplierListBox.Name = "supplierListBox";
            this.supplierListBox.Size = new System.Drawing.Size(120, 76);
            this.supplierListBox.TabIndex = 13;
            // 
            // PurchaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.supplierListBox);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.purchaseInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.purchaseQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchasePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.purchaseId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseListForm";
            this.Text = "PurchaseListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox purchaseId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox purchasePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox purchaseQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button purchaseInsert;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.ListBox supplierListBox;
    }
}