
namespace IncomeManager
{
    partial class AddSellForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.dateSaleDate = new System.Windows.Forms.DateTimePicker();
            this.labelSaleDate = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.comboArtikuls = new System.Windows.Forms.ComboBox();
            this.btnAddArtikul = new System.Windows.Forms.Button();
            this.btnAddToData = new System.Windows.Forms.Button();
            this.btnRemoveFromData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(786, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(13, 11);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(30, 15);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User";
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(12, 29);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(121, 23);
            this.comboUser.TabIndex = 2;
            // 
            // dateSaleDate
            // 
            this.dateSaleDate.Location = new System.Drawing.Point(13, 73);
            this.dateSaleDate.Name = "dateSaleDate";
            this.dateSaleDate.Size = new System.Drawing.Size(200, 23);
            this.dateSaleDate.TabIndex = 3;
            // 
            // labelSaleDate
            // 
            this.labelSaleDate.AutoSize = true;
            this.labelSaleDate.Location = new System.Drawing.Point(13, 55);
            this.labelSaleDate.Name = "labelSaleDate";
            this.labelSaleDate.Size = new System.Drawing.Size(31, 15);
            this.labelSaleDate.TabIndex = 4;
            this.labelSaleDate.Text = "Data";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(573, 11);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(42, 15);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Artikul";
            // 
            // comboArtikuls
            // 
            this.comboArtikuls.FormattingEnabled = true;
            this.comboArtikuls.Location = new System.Drawing.Point(573, 29);
            this.comboArtikuls.Name = "comboArtikuls";
            this.comboArtikuls.Size = new System.Drawing.Size(158, 23);
            this.comboArtikuls.TabIndex = 6;
            // 
            // btnAddArtikul
            // 
            this.btnAddArtikul.Location = new System.Drawing.Point(738, 28);
            this.btnAddArtikul.Name = "btnAddArtikul";
            this.btnAddArtikul.Size = new System.Drawing.Size(40, 23);
            this.btnAddArtikul.TabIndex = 7;
            this.btnAddArtikul.Text = "new";
            this.btnAddArtikul.UseVisualStyleBackColor = true;
            this.btnAddArtikul.Click += new System.EventHandler(this.btnAddArtikul_Click);
            // 
            // btnAddToData
            // 
            this.btnAddToData.Location = new System.Drawing.Point(632, 89);
            this.btnAddToData.Name = "btnAddToData";
            this.btnAddToData.Size = new System.Drawing.Size(75, 23);
            this.btnAddToData.TabIndex = 8;
            this.btnAddToData.Text = "Add";
            this.btnAddToData.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromData
            // 
            this.btnRemoveFromData.Location = new System.Drawing.Point(713, 89);
            this.btnRemoveFromData.Name = "btnRemoveFromData";
            this.btnRemoveFromData.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromData.TabIndex = 9;
            this.btnRemoveFromData.Text = "Remove";
            this.btnRemoveFromData.UseVisualStyleBackColor = true;
            // 
            // AddSellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveFromData);
            this.Controls.Add(this.btnAddToData);
            this.Controls.Add(this.btnAddArtikul);
            this.Controls.Add(this.comboArtikuls);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelSaleDate);
            this.Controls.Add(this.dateSaleDate);
            this.Controls.Add(this.comboUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddSellForm";
            this.Text = "AddSellFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.DateTimePicker dateSaleDate;
        private System.Windows.Forms.Label labelSaleDate;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.ComboBox comboArtikuls;
        private System.Windows.Forms.Button btnAddArtikul;
        private System.Windows.Forms.Button btnAddToData;
        private System.Windows.Forms.Button btnRemoveFromData;
    }
}