namespace SalesSystem
{
    partial class StatisticsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.sale_quantity = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品编号";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(82, 40);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 21);
            this.search.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "库存";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "销售总额";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "销售量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "单价";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(182, 245);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(0, 12);
            this.amount.TabIndex = 9;
            // 
            // sale_quantity
            // 
            this.sale_quantity.AutoSize = true;
            this.sale_quantity.Location = new System.Drawing.Point(182, 206);
            this.sale_quantity.Name = "sale_quantity";
            this.sale_quantity.Size = new System.Drawing.Size(0, 12);
            this.sale_quantity.TabIndex = 10;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(182, 169);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(0, 12);
            this.stock.TabIndex = 11;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(182, 131);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 12);
            this.price.TabIndex = 12;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(182, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 12);
            this.name.TabIndex = 13;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 283);
            this.Controls.Add(this.name);
            this.Controls.Add(this.price);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.sale_quantity);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label sale_quantity;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label name;

    }
}