namespace SalesSystemJupiterSoft
{
    partial class SalesReferenceForm
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
            this.BackToMenuFromReferencesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToMenuFromReferencesBtn
            // 
            this.BackToMenuFromReferencesBtn.Location = new System.Drawing.Point(301, 399);
            this.BackToMenuFromReferencesBtn.Name = "BackToMenuFromReferencesBtn";
            this.BackToMenuFromReferencesBtn.Size = new System.Drawing.Size(150, 40);
            this.BackToMenuFromReferencesBtn.TabIndex = 0;
            this.BackToMenuFromReferencesBtn.Text = "Back to menu";
            this.BackToMenuFromReferencesBtn.UseVisualStyleBackColor = true;
            this.BackToMenuFromReferencesBtn.Click += new System.EventHandler(this.BackToMenuFromReferencesBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales References";
            // 
            // SalesReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToMenuFromReferencesBtn);
            this.Name = "SalesReferenceForm";
            this.Text = "SalesReferenceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuFromReferencesBtn;
        private System.Windows.Forms.Label label1;
    }
}