namespace SalesSystemJupiterSoft
{
    partial class EnterArticleForm
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
            this.BackToMenuFromArticleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ArticleNameTextBox = new System.Windows.Forms.TextBox();
            this.ArticleNameLabel = new System.Windows.Forms.Label();
            this.ArticlePriceTextBox = new System.Windows.Forms.TextBox();
            this.ArticlePriceLabel = new System.Windows.Forms.Label();
            this.ArticleCodeTextBox = new System.Windows.Forms.TextBox();
            this.ArticleCodeLabel = new System.Windows.Forms.Label();
            this.CreateArticleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToMenuFromArticleBtn
            // 
            this.BackToMenuFromArticleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.BackToMenuFromArticleBtn.ForeColor = System.Drawing.Color.Red;
            this.BackToMenuFromArticleBtn.Location = new System.Drawing.Point(294, 399);
            this.BackToMenuFromArticleBtn.Name = "BackToMenuFromArticleBtn";
            this.BackToMenuFromArticleBtn.Size = new System.Drawing.Size(150, 40);
            this.BackToMenuFromArticleBtn.TabIndex = 0;
            this.BackToMenuFromArticleBtn.Text = "Back to menu";
            this.BackToMenuFromArticleBtn.UseVisualStyleBackColor = false;
            this.BackToMenuFromArticleBtn.Click += new System.EventHandler(this.BackToMenuFormBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create new article";
            // 
            // ArticleNameTextBox
            // 
            this.ArticleNameTextBox.Location = new System.Drawing.Point(112, 98);
            this.ArticleNameTextBox.Name = "ArticleNameTextBox";
            this.ArticleNameTextBox.Size = new System.Drawing.Size(539, 23);
            this.ArticleNameTextBox.TabIndex = 2;
            // 
            // ArticleNameLabel
            // 
            this.ArticleNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArticleNameLabel.Location = new System.Drawing.Point(285, 72);
            this.ArticleNameLabel.Name = "ArticleNameLabel";
            this.ArticleNameLabel.Size = new System.Drawing.Size(172, 23);
            this.ArticleNameLabel.TabIndex = 3;
            this.ArticleNameLabel.Text = "Enter Article Name";
            // 
            // ArticlePriceTextBox
            // 
            this.ArticlePriceTextBox.Location = new System.Drawing.Point(112, 182);
            this.ArticlePriceTextBox.Name = "ArticlePriceTextBox";
            this.ArticlePriceTextBox.Size = new System.Drawing.Size(127, 23);
            this.ArticlePriceTextBox.TabIndex = 4;
            // 
            // ArticlePriceLabel
            // 
            this.ArticlePriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArticlePriceLabel.Location = new System.Drawing.Point(112, 156);
            this.ArticlePriceLabel.Name = "ArticlePriceLabel";
            this.ArticlePriceLabel.Size = new System.Drawing.Size(127, 23);
            this.ArticlePriceLabel.TabIndex = 5;
            this.ArticlePriceLabel.Text = "Article price";
            // 
            // ArticleCodeTextBox
            // 
            this.ArticleCodeTextBox.Location = new System.Drawing.Point(294, 182);
            this.ArticleCodeTextBox.Name = "ArticleCodeTextBox";
            this.ArticleCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.ArticleCodeTextBox.TabIndex = 6;
            // 
            // ArticleCodeLabel
            // 
            this.ArticleCodeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArticleCodeLabel.Location = new System.Drawing.Point(294, 156);
            this.ArticleCodeLabel.Name = "ArticleCodeLabel";
            this.ArticleCodeLabel.Size = new System.Drawing.Size(100, 23);
            this.ArticleCodeLabel.TabIndex = 7;
            this.ArticleCodeLabel.Text = "Code";
            // 
            // CreateArticleBtn
            // 
            this.CreateArticleBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.CreateArticleBtn.Location = new System.Drawing.Point(294, 328);
            this.CreateArticleBtn.Name = "CreateArticleBtn";
            this.CreateArticleBtn.Size = new System.Drawing.Size(150, 52);
            this.CreateArticleBtn.TabIndex = 8;
            this.CreateArticleBtn.Text = "Create new Article";
            this.CreateArticleBtn.UseVisualStyleBackColor = true;
            this.CreateArticleBtn.Click += new System.EventHandler(this.CreateArticleBtn_Click);
            // 
            // EnterArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.CreateArticleBtn);
            this.Controls.Add(this.ArticleCodeLabel);
            this.Controls.Add(this.ArticleCodeTextBox);
            this.Controls.Add(this.ArticlePriceLabel);
            this.Controls.Add(this.ArticlePriceTextBox);
            this.Controls.Add(this.ArticleNameLabel);
            this.Controls.Add(this.ArticleNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToMenuFromArticleBtn);
            this.Name = "EnterArticleForm";
            this.Text = "EnterArticleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuFromArticleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArticleNameTextBox;
        private System.Windows.Forms.Label ArticleNameLabel;
        private System.Windows.Forms.TextBox ArticlePriceTextBox;
        private System.Windows.Forms.Label ArticlePriceLabel;
        private System.Windows.Forms.TextBox ArticleCodeTextBox;
        private System.Windows.Forms.Label ArticleCodeLabel;
        private System.Windows.Forms.Button CreateArticleBtn;
    }
}