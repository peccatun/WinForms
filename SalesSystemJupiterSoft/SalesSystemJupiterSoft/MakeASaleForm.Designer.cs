namespace SalesSystemJupiterSoft
{
    partial class MakeASaleForm
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
            this.BackToMenuFromSalesBtn = new System.Windows.Forms.Button();
            this.MakeASaleLabel = new System.Windows.Forms.Label();
            this.ArticleComboBox = new System.Windows.Forms.ComboBox();
            this.ArticleComboBoxLabel = new System.Windows.Forms.Label();
            this.ArticleQuantityTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.AddSaleBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMenuFromSalesBtn
            // 
            this.BackToMenuFromSalesBtn.ForeColor = System.Drawing.Color.Red;
            this.BackToMenuFromSalesBtn.Location = new System.Drawing.Point(300, 399);
            this.BackToMenuFromSalesBtn.Name = "BackToMenuFromSalesBtn";
            this.BackToMenuFromSalesBtn.Size = new System.Drawing.Size(150, 40);
            this.BackToMenuFromSalesBtn.TabIndex = 0;
            this.BackToMenuFromSalesBtn.Text = "Back to menu";
            this.BackToMenuFromSalesBtn.UseVisualStyleBackColor = true;
            this.BackToMenuFromSalesBtn.Click += new System.EventHandler(this.BackToMenuFromSalesBtn_Click);
            // 
            // MakeASaleLabel
            // 
            this.MakeASaleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeASaleLabel.Location = new System.Drawing.Point(300, 9);
            this.MakeASaleLabel.Name = "MakeASaleLabel";
            this.MakeASaleLabel.Size = new System.Drawing.Size(150, 40);
            this.MakeASaleLabel.TabIndex = 1;
            this.MakeASaleLabel.Text = "Make a sale";
            // 
            // ArticleComboBox
            // 
            this.ArticleComboBox.FormattingEnabled = true;
            this.ArticleComboBox.Location = new System.Drawing.Point(33, 84);
            this.ArticleComboBox.Name = "ArticleComboBox";
            this.ArticleComboBox.Size = new System.Drawing.Size(183, 23);
            this.ArticleComboBox.TabIndex = 2;
            // 
            // ArticleComboBoxLabel
            // 
            this.ArticleComboBoxLabel.AutoSize = true;
            this.ArticleComboBoxLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArticleComboBoxLabel.Location = new System.Drawing.Point(33, 56);
            this.ArticleComboBoxLabel.Name = "ArticleComboBoxLabel";
            this.ArticleComboBoxLabel.Size = new System.Drawing.Size(66, 25);
            this.ArticleComboBoxLabel.TabIndex = 3;
            this.ArticleComboBoxLabel.Text = "Article";
            // 
            // ArticleQuantityTextBox
            // 
            this.ArticleQuantityTextBox.Location = new System.Drawing.Point(276, 84);
            this.ArticleQuantityTextBox.Name = "ArticleQuantityTextBox";
            this.ArticleQuantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.ArticleQuantityTextBox.TabIndex = 4;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.Location = new System.Drawing.Point(276, 56);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(84, 25);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity";
            // 
            // AddSaleBtn
            // 
            this.AddSaleBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.AddSaleBtn.Location = new System.Drawing.Point(466, 80);
            this.AddSaleBtn.Name = "AddSaleBtn";
            this.AddSaleBtn.Size = new System.Drawing.Size(126, 28);
            this.AddSaleBtn.TabIndex = 6;
            this.AddSaleBtn.Text = "Make Sale";
            this.AddSaleBtn.UseVisualStyleBackColor = true;
            this.AddSaleBtn.Click += new System.EventHandler(this.AddSaleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 150);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // MakeASaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.AddSaleBtn);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ArticleQuantityTextBox);
            this.Controls.Add(this.ArticleComboBoxLabel);
            this.Controls.Add(this.ArticleComboBox);
            this.Controls.Add(this.MakeASaleLabel);
            this.Controls.Add(this.BackToMenuFromSalesBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MakeASaleForm";
            this.Text = "MakeASaleForm";
            this.Load += new System.EventHandler(this.MakeASaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuFromSalesBtn;
        private System.Windows.Forms.Label MakeASaleLabel;
        private System.Windows.Forms.ComboBox ArticleComboBox;
        private System.Windows.Forms.Label ArticleComboBoxLabel;
        private System.Windows.Forms.TextBox ArticleQuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button AddSaleBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}