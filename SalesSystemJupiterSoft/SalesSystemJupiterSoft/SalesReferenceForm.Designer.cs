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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToMenuFromReferencesBtn
            // 
            this.BackToMenuFromReferencesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackToMenuFromReferencesBtn.ForeColor = System.Drawing.Color.Red;
            this.BackToMenuFromReferencesBtn.Location = new System.Drawing.Point(269, 390);
            this.BackToMenuFromReferencesBtn.Name = "BackToMenuFromReferencesBtn";
            this.BackToMenuFromReferencesBtn.Size = new System.Drawing.Size(149, 40);
            this.BackToMenuFromReferencesBtn.TabIndex = 0;
            this.BackToMenuFromReferencesBtn.Text = "Back to menu";
            this.BackToMenuFromReferencesBtn.UseVisualStyleBackColor = true;
            this.BackToMenuFromReferencesBtn.Click += new System.EventHandler(this.BackToMenuFromReferencesBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(269, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales References";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(392, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(212, 25);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromDateLabel.Location = new System.Drawing.Point(165, 69);
            this.FromDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(83, 21);
            this.FromDateLabel.TabIndex = 4;
            this.FromDateLabel.Text = "From Date";
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.AutoSize = true;
            this.ToDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToDateLabel.Location = new System.Drawing.Point(470, 69);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(61, 21);
            this.ToDateLabel.TabIndex = 5;
            this.ToDateLabel.Text = "To Date";
            // 
            // SalesReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToMenuFromReferencesBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalesReferenceForm";
            this.Text = "SalesReferenceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuFromReferencesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label ToDateLabel;
    }
}