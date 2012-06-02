namespace SalesSystem
{
    partial class SupplierForm
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
            this.SupplierIdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierNameText = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.displayId = new System.Windows.Forms.TextBox();
            this.displayName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchIdText = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // SupplierIdText
            // 
            this.SupplierIdText.Location = new System.Drawing.Point(40, 34);
            this.SupplierIdText.Name = "SupplierIdText";
            this.SupplierIdText.Size = new System.Drawing.Size(83, 21);
            this.SupplierIdText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // SupplierNameText
            // 
            this.SupplierNameText.Location = new System.Drawing.Point(40, 77);
            this.SupplierNameText.Name = "SupplierNameText";
            this.SupplierNameText.Size = new System.Drawing.Size(83, 21);
            this.SupplierNameText.TabIndex = 4;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(23, 165);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 5;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Display";
            // 
            // displayId
            // 
            this.displayId.Location = new System.Drawing.Point(172, 32);
            this.displayId.Name = "displayId";
            this.displayId.Size = new System.Drawing.Size(100, 21);
            this.displayId.TabIndex = 7;
            // 
            // displayName
            // 
            this.displayName.Location = new System.Drawing.Point(172, 80);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(100, 21);
            this.displayName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "searchId";
            // 
            // searchIdText
            // 
            this.searchIdText.Location = new System.Drawing.Point(172, 125);
            this.searchIdText.Name = "searchIdText";
            this.searchIdText.Size = new System.Drawing.Size(100, 21);
            this.searchIdText.TabIndex = 10;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(185, 180);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 11;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchIdText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.displayId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.SupplierNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupplierIdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SupplierIdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplierNameText;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox displayId;
        private System.Windows.Forms.TextBox displayName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchIdText;
        private System.Windows.Forms.Button search;
    }
}