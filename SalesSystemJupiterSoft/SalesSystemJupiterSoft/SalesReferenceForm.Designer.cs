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
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MakeReferenceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMenuFromReferencesBtn
            // 
            this.BackToMenuFromReferencesBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackToMenuFromReferencesBtn.ForeColor = System.Drawing.Color.Red;
            this.BackToMenuFromReferencesBtn.Location = new System.Drawing.Point(298, 399);
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
            // FromDatePicker
            // 
            this.FromDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromDatePicker.Location = new System.Drawing.Point(68, 93);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(216, 25);
            this.FromDatePicker.TabIndex = 2;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToDatePicker.Location = new System.Drawing.Point(314, 93);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(212, 25);
            this.ToDatePicker.TabIndex = 3;
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromDateLabel.Location = new System.Drawing.Point(68, 69);
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
            this.ToDateLabel.Location = new System.Drawing.Point(314, 69);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(61, 21);
            this.ToDateLabel.TabIndex = 5;
            this.ToDateLabel.Text = "To Date";
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
            // MakeReferenceBtn
            // 
            this.MakeReferenceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MakeReferenceBtn.ForeColor = System.Drawing.Color.Green;
            this.MakeReferenceBtn.Location = new System.Drawing.Point(551, 93);
            this.MakeReferenceBtn.Name = "MakeReferenceBtn";
            this.MakeReferenceBtn.Size = new System.Drawing.Size(125, 27);
            this.MakeReferenceBtn.TabIndex = 6;
            this.MakeReferenceBtn.Text = "Make reference";
            this.MakeReferenceBtn.UseVisualStyleBackColor = true;
            this.MakeReferenceBtn.Click += new System.EventHandler(this.MakeReferenceBtn_Click);
            // 
            // SalesReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.MakeReferenceBtn);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToMenuFromReferencesBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalesReferenceForm";
            this.Text = "SalesReferenceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuFromReferencesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MakeReferenceBtn;
    }
}