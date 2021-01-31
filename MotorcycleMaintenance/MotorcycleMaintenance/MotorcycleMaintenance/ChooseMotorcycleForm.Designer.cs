
namespace MotorcycleMaintenance
{
    partial class ChooseMotorcycleForm
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
            this.MotorcycleDgv = new System.Windows.Forms.DataGridView();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotorcycleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseMotorcycleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MotorcycleDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MotorcycleDgv
            // 
            this.MotorcycleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MotorcycleDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Make,
            this.Model,
            this.MotorcycleId});
            this.MotorcycleDgv.Location = new System.Drawing.Point(1, 112);
            this.MotorcycleDgv.Name = "MotorcycleDgv";
            this.MotorcycleDgv.Size = new System.Drawing.Size(385, 350);
            this.MotorcycleDgv.TabIndex = 0;
            this.MotorcycleDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MotorcycleDgv_CellDoubleClick);
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            this.Make.Width = 150;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.Width = 200;
            // 
            // MotorcycleId
            // 
            this.MotorcycleId.HeaderText = "MotorcyceId";
            this.MotorcycleId.Name = "MotorcycleId";
            this.MotorcycleId.Visible = false;
            // 
            // ChooseMotorcycleLabel
            // 
            this.ChooseMotorcycleLabel.AutoSize = true;
            this.ChooseMotorcycleLabel.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseMotorcycleLabel.Location = new System.Drawing.Point(12, 9);
            this.ChooseMotorcycleLabel.Name = "ChooseMotorcycleLabel";
            this.ChooseMotorcycleLabel.Size = new System.Drawing.Size(354, 36);
            this.ChooseMotorcycleLabel.TabIndex = 1;
            this.ChooseMotorcycleLabel.Text = "Choose Motorcycle";
            // 
            // ChooseMotorcycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.ChooseMotorcycleLabel);
            this.Controls.Add(this.MotorcycleDgv);
            this.Name = "ChooseMotorcycleForm";
            this.Text = "ChooseMotorcycleForm";
            this.Load += new System.EventHandler(this.ChooseMotorcycleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MotorcycleDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MotorcycleDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotorcycleId;
        private System.Windows.Forms.Label ChooseMotorcycleLabel;
    }
}