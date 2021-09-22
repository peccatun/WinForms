
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
            this.groupItemInfo = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAddPrice = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.groupSellInfo = new System.Windows.Forms.GroupBox();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.labelStore = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonNewStore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupItemInfo.SuspendLayout();
            this.groupSellInfo.SuspendLayout();
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
            this.labelUser.Location = new System.Drawing.Point(11, 40);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(30, 15);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User";
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(47, 34);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(121, 23);
            this.comboUser.TabIndex = 2;
            // 
            // dateSaleDate
            // 
            this.dateSaleDate.Location = new System.Drawing.Point(12, 29);
            this.dateSaleDate.Name = "dateSaleDate";
            this.dateSaleDate.Size = new System.Drawing.Size(200, 23);
            this.dateSaleDate.TabIndex = 3;
            // 
            // labelSaleDate
            // 
            this.labelSaleDate.AutoSize = true;
            this.labelSaleDate.Location = new System.Drawing.Point(12, 11);
            this.labelSaleDate.Name = "labelSaleDate";
            this.labelSaleDate.Size = new System.Drawing.Size(31, 15);
            this.labelSaleDate.TabIndex = 4;
            this.labelSaleDate.Text = "Data";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(6, 19);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(31, 15);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Item";
            // 
            // comboArtikuls
            // 
            this.comboArtikuls.FormattingEnabled = true;
            this.comboArtikuls.Location = new System.Drawing.Point(6, 37);
            this.comboArtikuls.Name = "comboArtikuls";
            this.comboArtikuls.Size = new System.Drawing.Size(158, 23);
            this.comboArtikuls.TabIndex = 6;
            // 
            // btnAddArtikul
            // 
            this.btnAddArtikul.Location = new System.Drawing.Point(103, 12);
            this.btnAddArtikul.Name = "btnAddArtikul";
            this.btnAddArtikul.Size = new System.Drawing.Size(74, 23);
            this.btnAddArtikul.TabIndex = 7;
            this.btnAddArtikul.Text = "New item";
            this.btnAddArtikul.UseVisualStyleBackColor = true;
            this.btnAddArtikul.Click += new System.EventHandler(this.btnAddArtikul_Click);
            // 
            // btnAddToData
            // 
            this.btnAddToData.Location = new System.Drawing.Point(12, 81);
            this.btnAddToData.Name = "btnAddToData";
            this.btnAddToData.Size = new System.Drawing.Size(75, 23);
            this.btnAddToData.TabIndex = 8;
            this.btnAddToData.Text = "Add";
            this.btnAddToData.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromData
            // 
            this.btnRemoveFromData.Location = new System.Drawing.Point(93, 81);
            this.btnRemoveFromData.Name = "btnRemoveFromData";
            this.btnRemoveFromData.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromData.TabIndex = 9;
            this.btnRemoveFromData.Text = "Remove";
            this.btnRemoveFromData.UseVisualStyleBackColor = true;
            // 
            // groupItemInfo
            // 
            this.groupItemInfo.Controls.Add(this.textQuantity);
            this.groupItemInfo.Controls.Add(this.labelQuantity);
            this.groupItemInfo.Controls.Add(this.buttonAddPrice);
            this.groupItemInfo.Controls.Add(this.comboBox1);
            this.groupItemInfo.Controls.Add(this.labelPrice);
            this.groupItemInfo.Controls.Add(this.labelStock);
            this.groupItemInfo.Controls.Add(this.comboArtikuls);
            this.groupItemInfo.Controls.Add(this.btnAddArtikul);
            this.groupItemInfo.Location = new System.Drawing.Point(501, 11);
            this.groupItemInfo.Name = "groupItemInfo";
            this.groupItemInfo.Size = new System.Drawing.Size(287, 100);
            this.groupItemInfo.TabIndex = 10;
            this.groupItemInfo.TabStop = false;
            this.groupItemInfo.Text = "Item info";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(7, 78);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // buttonAddPrice
            // 
            this.buttonAddPrice.Location = new System.Drawing.Point(103, 71);
            this.buttonAddPrice.Name = "buttonAddPrice";
            this.buttonAddPrice.Size = new System.Drawing.Size(74, 23);
            this.buttonAddPrice.TabIndex = 10;
            this.buttonAddPrice.Text = "New price";
            this.buttonAddPrice.UseVisualStyleBackColor = true;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(203, 16);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(53, 15);
            this.labelQuantity.TabIndex = 11;
            this.labelQuantity.Text = "Quantity";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(203, 34);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(74, 23);
            this.textQuantity.TabIndex = 12;
            // 
            // groupSellInfo
            // 
            this.groupSellInfo.Controls.Add(this.buttonNewStore);
            this.groupSellInfo.Controls.Add(this.comboBox2);
            this.groupSellInfo.Controls.Add(this.labelStore);
            this.groupSellInfo.Controls.Add(this.buttonNewUser);
            this.groupSellInfo.Controls.Add(this.labelUser);
            this.groupSellInfo.Controls.Add(this.comboUser);
            this.groupSellInfo.Location = new System.Drawing.Point(231, 11);
            this.groupSellInfo.Name = "groupSellInfo";
            this.groupSellInfo.Size = new System.Drawing.Size(264, 93);
            this.groupSellInfo.TabIndex = 11;
            this.groupSellInfo.TabStop = false;
            this.groupSellInfo.Text = "Sell info";
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(174, 33);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(64, 22);
            this.buttonNewUser.TabIndex = 3;
            this.buttonNewUser.Text = "new user";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Location = new System.Drawing.Point(7, 68);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(34, 15);
            this.labelStore.TabIndex = 4;
            this.labelStore.Text = "Store";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(47, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 5;
            // 
            // buttonNewStore
            // 
            this.buttonNewStore.Location = new System.Drawing.Point(174, 63);
            this.buttonNewStore.Name = "buttonNewStore";
            this.buttonNewStore.Size = new System.Drawing.Size(74, 22);
            this.buttonNewStore.TabIndex = 6;
            this.buttonNewStore.Text = "new store";
            this.buttonNewStore.UseVisualStyleBackColor = true;
            // 
            // AddSellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupSellInfo);
            this.Controls.Add(this.groupItemInfo);
            this.Controls.Add(this.btnRemoveFromData);
            this.Controls.Add(this.btnAddToData);
            this.Controls.Add(this.labelSaleDate);
            this.Controls.Add(this.dateSaleDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddSellForm";
            this.Text = "AddSellFormcs";
            this.Load += new System.EventHandler(this.AddSellForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupItemInfo.ResumeLayout(false);
            this.groupItemInfo.PerformLayout();
            this.groupSellInfo.ResumeLayout(false);
            this.groupSellInfo.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupItemInfo;
        private System.Windows.Forms.Button buttonAddPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.GroupBox groupSellInfo;
        private System.Windows.Forms.Button buttonNewStore;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Button buttonNewUser;
    }
}