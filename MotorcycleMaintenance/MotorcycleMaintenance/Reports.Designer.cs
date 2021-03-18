
namespace MotorcycleMaintenance
{
    partial class Reports
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
            this.MaintenanceInfoGrid = new System.Windows.Forms.DataGridView();
            this.ChooseMaintenanceLabel = new System.Windows.Forms.Label();
            this.MaintenanceType = new System.Windows.Forms.ComboBox();
            this.MakeReportBtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthsDriveWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KilometersDrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KilometersOnChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MaintenanceInfoGrid
            // 
            this.MaintenanceInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaintenanceInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ChangeDate,
            this.Price,
            this.Make,
            this.MonthsDriveWith,
            this.KilometersDrive,
            this.KilometersOnChange});
            this.MaintenanceInfoGrid.Location = new System.Drawing.Point(12, 165);
            this.MaintenanceInfoGrid.Name = "MaintenanceInfoGrid";
            this.MaintenanceInfoGrid.Size = new System.Drawing.Size(859, 290);
            this.MaintenanceInfoGrid.TabIndex = 0;
            // 
            // ChooseMaintenanceLabel
            // 
            this.ChooseMaintenanceLabel.AutoSize = true;
            this.ChooseMaintenanceLabel.Location = new System.Drawing.Point(12, 13);
            this.ChooseMaintenanceLabel.Name = "ChooseMaintenanceLabel";
            this.ChooseMaintenanceLabel.Size = new System.Drawing.Size(108, 13);
            this.ChooseMaintenanceLabel.TabIndex = 2;
            this.ChooseMaintenanceLabel.Text = "Choose Maintenance";
            // 
            // MaintenanceType
            // 
            this.MaintenanceType.FormattingEnabled = true;
            this.MaintenanceType.Location = new System.Drawing.Point(12, 41);
            this.MaintenanceType.Name = "MaintenanceType";
            this.MaintenanceType.Size = new System.Drawing.Size(197, 21);
            this.MaintenanceType.TabIndex = 3;
            // 
            // MakeReportBtn
            // 
            this.MakeReportBtn.Location = new System.Drawing.Point(239, 39);
            this.MakeReportBtn.Name = "MakeReportBtn";
            this.MakeReportBtn.Size = new System.Drawing.Size(75, 23);
            this.MakeReportBtn.TabIndex = 4;
            this.MakeReportBtn.Text = "MakeReport";
            this.MakeReportBtn.UseVisualStyleBackColor = true;
            this.MakeReportBtn.Click += new System.EventHandler(this.MakeReportBtn_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ChangeDate
            // 
            this.ChangeDate.HeaderText = "ChangeDate";
            this.ChangeDate.Name = "ChangeDate";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            // 
            // MonthsDriveWith
            // 
            this.MonthsDriveWith.HeaderText = "MonthsDriveWIth";
            this.MonthsDriveWith.Name = "MonthsDriveWith";
            // 
            // KilometersDrive
            // 
            this.KilometersDrive.HeaderText = "KilometersDriven";
            this.KilometersDrive.Name = "KilometersDrive";
            // 
            // KilometersOnChange
            // 
            this.KilometersOnChange.HeaderText = "KilometersOnChange";
            this.KilometersOnChange.Name = "KilometersOnChange";
            this.KilometersOnChange.Width = 120;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 467);
            this.Controls.Add(this.MakeReportBtn);
            this.Controls.Add(this.MaintenanceType);
            this.Controls.Add(this.ChooseMaintenanceLabel);
            this.Controls.Add(this.MaintenanceInfoGrid);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MaintenanceInfoGrid;
        private System.Windows.Forms.Label ChooseMaintenanceLabel;
        private System.Windows.Forms.ComboBox MaintenanceType;
        private System.Windows.Forms.Button MakeReportBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthsDriveWith;
        private System.Windows.Forms.DataGridViewTextBoxColumn KilometersDrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn KilometersOnChange;
    }
}