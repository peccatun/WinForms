namespace SalesSystemJupiterSoft
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuTextLabel = new System.Windows.Forms.Label();
            this.EnterArticleBtn = new System.Windows.Forms.Button();
            this.MakeSaleBtn = new System.Windows.Forms.Button();
            this.SalesReferenceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuTextLabel
            // 
            this.MenuTextLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuTextLabel.Location = new System.Drawing.Point(247, 24);
            this.MenuTextLabel.Name = "MenuTextLabel";
            this.MenuTextLabel.Size = new System.Drawing.Size(231, 49);
            this.MenuTextLabel.TabIndex = 0;
            this.MenuTextLabel.Text = "Sales System Menu";
            // 
            // EnterArticleBtn
            // 
            this.EnterArticleBtn.Location = new System.Drawing.Point(262, 113);
            this.EnterArticleBtn.Name = "EnterArticleBtn";
            this.EnterArticleBtn.Size = new System.Drawing.Size(180, 60);
            this.EnterArticleBtn.TabIndex = 1;
            this.EnterArticleBtn.Text = "Enter Article";
            this.EnterArticleBtn.UseVisualStyleBackColor = true;
            this.EnterArticleBtn.Click += new System.EventHandler(this.EnterArticleBtn_Click);
            // 
            // MakeSaleBtn
            // 
            this.MakeSaleBtn.Location = new System.Drawing.Point(262, 179);
            this.MakeSaleBtn.Name = "MakeSaleBtn";
            this.MakeSaleBtn.Size = new System.Drawing.Size(180, 60);
            this.MakeSaleBtn.TabIndex = 2;
            this.MakeSaleBtn.Text = "Make a Sale";
            this.MakeSaleBtn.UseVisualStyleBackColor = true;
            this.MakeSaleBtn.Click += new System.EventHandler(this.MakeSaleBtn_Click);
            // 
            // SalesReferenceBtn
            // 
            this.SalesReferenceBtn.Location = new System.Drawing.Point(262, 245);
            this.SalesReferenceBtn.Name = "SalesReferenceBtn";
            this.SalesReferenceBtn.Size = new System.Drawing.Size(180, 60);
            this.SalesReferenceBtn.TabIndex = 3;
            this.SalesReferenceBtn.Text = "Sales Reference";
            this.SalesReferenceBtn.UseVisualStyleBackColor = true;
            this.SalesReferenceBtn.Click += new System.EventHandler(this.SalesReferenceBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.SalesReferenceBtn);
            this.Controls.Add(this.MakeSaleBtn);
            this.Controls.Add(this.EnterArticleBtn);
            this.Controls.Add(this.MenuTextLabel);
            this.Name = "MenuForm";
            this.Text = "Sales System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MenuTextLabel;
        private System.Windows.Forms.Button EnterArticleBtn;
        private System.Windows.Forms.Button MakeSaleBtn;
        private System.Windows.Forms.Button SalesReferenceBtn;
    }
}

