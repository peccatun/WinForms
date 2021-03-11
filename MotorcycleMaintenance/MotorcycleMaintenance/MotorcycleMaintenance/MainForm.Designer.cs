namespace MotorcycleMaintenance
{
    partial class MainForm
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
            this.MotorcycleMaintenanceLabel = new System.Windows.Forms.Label();
            this.MotorcycleInfoButton = new System.Windows.Forms.Button();
            this.MotorcycleMakeDisplayLabel = new System.Windows.Forms.Label();
            this.MotorcycleMakeLabel = new System.Windows.Forms.Label();
            this.MotorcycleModelLabel = new System.Windows.Forms.Label();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.OutBtn = new System.Windows.Forms.Button();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.AddMaintenanceButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MotorcycleMaintenanceLabel
            // 
            this.MotorcycleMaintenanceLabel.AutoSize = true;
            this.MotorcycleMaintenanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorcycleMaintenanceLabel.Location = new System.Drawing.Point(115, 9);
            this.MotorcycleMaintenanceLabel.Name = "MotorcycleMaintenanceLabel";
            this.MotorcycleMaintenanceLabel.Size = new System.Drawing.Size(353, 33);
            this.MotorcycleMaintenanceLabel.TabIndex = 0;
            this.MotorcycleMaintenanceLabel.Text = "Motorcycle Maintenance";
            // 
            // MotorcycleInfoButton
            // 
            this.MotorcycleInfoButton.Location = new System.Drawing.Point(296, 45);
            this.MotorcycleInfoButton.Name = "MotorcycleInfoButton";
            this.MotorcycleInfoButton.Size = new System.Drawing.Size(172, 22);
            this.MotorcycleInfoButton.TabIndex = 1;
            this.MotorcycleInfoButton.Text = "Enter motorcycle info";
            this.MotorcycleInfoButton.UseVisualStyleBackColor = true;
            this.MotorcycleInfoButton.Click += new System.EventHandler(this.MotorcycleInfoButton_Click);
            // 
            // MotorcycleMakeDisplayLabel
            // 
            this.MotorcycleMakeDisplayLabel.AutoSize = true;
            this.MotorcycleMakeDisplayLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorcycleMakeDisplayLabel.Location = new System.Drawing.Point(12, 7);
            this.MotorcycleMakeDisplayLabel.Name = "MotorcycleMakeDisplayLabel";
            this.MotorcycleMakeDisplayLabel.Size = new System.Drawing.Size(0, 16);
            this.MotorcycleMakeDisplayLabel.TabIndex = 2;
            // 
            // MotorcycleMakeLabel
            // 
            this.MotorcycleMakeLabel.AutoSize = true;
            this.MotorcycleMakeLabel.Location = new System.Drawing.Point(0, 0);
            this.MotorcycleMakeLabel.Name = "MotorcycleMakeLabel";
            this.MotorcycleMakeLabel.Size = new System.Drawing.Size(0, 13);
            this.MotorcycleMakeLabel.TabIndex = 3;
            // 
            // MotorcycleModelLabel
            // 
            this.MotorcycleModelLabel.AutoSize = true;
            this.MotorcycleModelLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorcycleModelLabel.Location = new System.Drawing.Point(11, 25);
            this.MotorcycleModelLabel.Name = "MotorcycleModelLabel";
            this.MotorcycleModelLabel.Size = new System.Drawing.Size(0, 19);
            this.MotorcycleModelLabel.TabIndex = 4;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(562, 10);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(39, 22);
            this.CreateUserButton.TabIndex = 5;
            this.CreateUserButton.Text = "New";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(517, 10);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(39, 22);
            this.LogInButton.TabIndex = 6;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // OutBtn
            // 
            this.OutBtn.Location = new System.Drawing.Point(474, 11);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.Size = new System.Drawing.Size(39, 21);
            this.OutBtn.TabIndex = 7;
            this.OutBtn.Text = "Out";
            this.OutBtn.UseVisualStyleBackColor = true;
            this.OutBtn.Click += new System.EventHandler(this.OutBtn_Click);
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(209, 45);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(68, 23);
            this.ChooseBtn.TabIndex = 8;
            this.ChooseBtn.Text = "Choose";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // AddMaintenanceButton
            // 
            this.AddMaintenanceButton.Location = new System.Drawing.Point(198, 112);
            this.AddMaintenanceButton.Name = "AddMaintenanceButton";
            this.AddMaintenanceButton.Size = new System.Drawing.Size(178, 32);
            this.AddMaintenanceButton.TabIndex = 9;
            this.AddMaintenanceButton.Text = "Add Maintenance";
            this.AddMaintenanceButton.UseVisualStyleBackColor = true;
            this.AddMaintenanceButton.Click += new System.EventHandler(this.AddMaintenanceButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Location = new System.Drawing.Point(198, 150);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(178, 32);
            this.ReportsButton.TabIndex = 10;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 266);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.AddMaintenanceButton);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.OutBtn);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.MotorcycleModelLabel);
            this.Controls.Add(this.MotorcycleMakeLabel);
            this.Controls.Add(this.MotorcycleMakeDisplayLabel);
            this.Controls.Add(this.MotorcycleInfoButton);
            this.Controls.Add(this.MotorcycleMaintenanceLabel);
            this.Name = "MainForm";
            this.Text = "MotorcycleMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MotorcycleMaintenanceLabel;
        private System.Windows.Forms.Button MotorcycleInfoButton;
        private System.Windows.Forms.Label MotorcycleMakeDisplayLabel;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button OutBtn;
        private System.Windows.Forms.Button ChooseBtn;
        public System.Windows.Forms.Label MotorcycleMakeLabel;
        public System.Windows.Forms.Label MotorcycleModelLabel;
        private System.Windows.Forms.Button AddMaintenanceButton;
        private System.Windows.Forms.Button ReportsButton;
    }
}

