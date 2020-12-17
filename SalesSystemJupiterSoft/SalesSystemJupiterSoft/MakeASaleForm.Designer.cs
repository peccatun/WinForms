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
            this.SuspendLayout();
            // 
            // BackToMenuFromSalesBtn
            // 
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
            // MakeASaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.MakeASaleLabel);
            this.Controls.Add(this.BackToMenuFromSalesBtn);
            this.Name = "MakeASaleForm";
            this.Text = "MakeASaleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuFromSalesBtn;
        private System.Windows.Forms.Label MakeASaleLabel;
    }
}