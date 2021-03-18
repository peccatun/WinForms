
namespace MotorcycleMaintenance
{
    partial class EnterMotorcycleInfoForm
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
            this.MotorcycleInfoLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.KilometersLabel = new System.Windows.Forms.Label();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.KilometersTextBox = new System.Windows.Forms.TextBox();
            this.EnterInfoBtn = new System.Windows.Forms.Button();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // MotorcycleInfoLabel
            // 
            this.MotorcycleInfoLabel.AutoSize = true;
            this.MotorcycleInfoLabel.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorcycleInfoLabel.Location = new System.Drawing.Point(1, 9);
            this.MotorcycleInfoLabel.Name = "MotorcycleInfoLabel";
            this.MotorcycleInfoLabel.Size = new System.Drawing.Size(275, 34);
            this.MotorcycleInfoLabel.TabIndex = 0;
            this.MotorcycleInfoLabel.Text = "Enter Motorcycle Info";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeLabel.Location = new System.Drawing.Point(111, 68);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(48, 20);
            this.MakeLabel.TabIndex = 1;
            this.MakeLabel.Text = "Make";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(107, 114);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Model";
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationDateLabel.Location = new System.Drawing.Point(86, 206);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(108, 20);
            this.CreationDateLabel.TabIndex = 3;
            this.CreationDateLabel.Text = "Creation Date";
            // 
            // KilometersLabel
            // 
            this.KilometersLabel.AutoSize = true;
            this.KilometersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilometersLabel.Location = new System.Drawing.Point(76, 160);
            this.KilometersLabel.Name = "KilometersLabel";
            this.KilometersLabel.Size = new System.Drawing.Size(140, 20);
            this.KilometersLabel.TabIndex = 4;
            this.KilometersLabel.Text = "Current Kilometers";
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(49, 91);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(174, 20);
            this.MakeTextBox.TabIndex = 5;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(49, 137);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(174, 20);
            this.ModelTextBox.TabIndex = 6;
            // 
            // KilometersTextBox
            // 
            this.KilometersTextBox.Location = new System.Drawing.Point(49, 183);
            this.KilometersTextBox.Name = "KilometersTextBox";
            this.KilometersTextBox.Size = new System.Drawing.Size(174, 20);
            this.KilometersTextBox.TabIndex = 7;
            // 
            // EnterInfoBtn
            // 
            this.EnterInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterInfoBtn.Location = new System.Drawing.Point(71, 299);
            this.EnterInfoBtn.Name = "EnterInfoBtn";
            this.EnterInfoBtn.Size = new System.Drawing.Size(123, 44);
            this.EnterInfoBtn.TabIndex = 9;
            this.EnterInfoBtn.Text = "Enter Info";
            this.EnterInfoBtn.UseVisualStyleBackColor = true;
            this.EnterInfoBtn.Click += new System.EventHandler(this.EnterInfoBtn_Click);
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(36, 229);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(200, 20);
            this.CreationDate.TabIndex = 10;
            // 
            // EnterMotorcycleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 377);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.EnterInfoBtn);
            this.Controls.Add(this.KilometersTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.MakeTextBox);
            this.Controls.Add(this.KilometersLabel);
            this.Controls.Add(this.CreationDateLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.MakeLabel);
            this.Controls.Add(this.MotorcycleInfoLabel);
            this.Name = "EnterMotorcycleInfoForm";
            this.Text = "EnterMotorcycleInfoForm";
            this.Load += new System.EventHandler(this.EnterMotorcycleInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MotorcycleInfoLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label CreationDateLabel;
        private System.Windows.Forms.Label KilometersLabel;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox KilometersTextBox;
        private System.Windows.Forms.Button EnterInfoBtn;
        private System.Windows.Forms.DateTimePicker CreationDate;
    }
}