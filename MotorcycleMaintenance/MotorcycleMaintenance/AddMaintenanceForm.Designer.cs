
namespace MotorcycleMaintenance
{
    partial class AddMaintenanceForm
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
            this.MaintenanceControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.KilometersOnChangeTextBox = new System.Windows.Forms.TextBox();
            this.KiloetersOnChangeLabel = new System.Windows.Forms.Label();
            this.AddMaintenanceBtn = new System.Windows.Forms.Button();
            this.ChangeDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ChangeDateLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaintenanceBox = new System.Windows.Forms.ComboBox();
            this.ReviewTab = new System.Windows.Forms.TabPage();
            this.NewReviwGroup = new System.Windows.Forms.GroupBox();
            this.InsuranceAngecyCombo = new System.Windows.Forms.ComboBox();
            this.InsuranceAngencyLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FourRadio = new System.Windows.Forms.RadioButton();
            this.ThreeRadio = new System.Windows.Forms.RadioButton();
            this.TwoRadio = new System.Windows.Forms.RadioButton();
            this.OneRadio = new System.Windows.Forms.RadioButton();
            this.MounthsLabel = new System.Windows.Forms.Label();
            this.MounthsCombo = new System.Windows.Forms.ComboBox();
            this.ReviewMounthsCountLabel = new System.Windows.Forms.Label();
            this.Leva2Label = new System.Windows.Forms.Label();
            this.ReviewPriceTextBox = new System.Windows.Forms.TextBox();
            this.ReviewPriceLabel = new System.Windows.Forms.Label();
            this.ReviewStartDateLabel = new System.Windows.Forms.Label();
            this.ReviewStartDate = new System.Windows.Forms.DateTimePicker();
            this.AddReviewButton = new System.Windows.Forms.Button();
            this.AddContributionGroup = new System.Windows.Forms.GroupBox();
            this.LevaLabel = new System.Windows.Forms.Label();
            this.ContribuionPriceTextBox = new System.Windows.Forms.TextBox();
            this.ContributionPriceLabel = new System.Windows.Forms.Label();
            this.ContribuionDateLabel = new System.Windows.Forms.Label();
            this.ContributionDate = new System.Windows.Forms.DateTimePicker();
            this.ReviewNumberComboBox = new System.Windows.Forms.ComboBox();
            this.AddContributionButton = new System.Windows.Forms.Button();
            this.ReviewNumberLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.MaintenanceControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ReviewTab.SuspendLayout();
            this.NewReviwGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AddContributionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaintenanceControl
            // 
            this.MaintenanceControl.Controls.Add(this.tabPage1);
            this.MaintenanceControl.Controls.Add(this.ReviewTab);
            this.MaintenanceControl.Controls.Add(this.tabPage3);
            this.MaintenanceControl.Location = new System.Drawing.Point(13, 13);
            this.MaintenanceControl.Name = "MaintenanceControl";
            this.MaintenanceControl.SelectedIndex = 0;
            this.MaintenanceControl.Size = new System.Drawing.Size(510, 448);
            this.MaintenanceControl.TabIndex = 0;
            this.MaintenanceControl.SelectedIndexChanged += new System.EventHandler(this.MaintenanceControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.KilometersOnChangeTextBox);
            this.tabPage1.Controls.Add(this.KiloetersOnChangeLabel);
            this.tabPage1.Controls.Add(this.AddMaintenanceBtn);
            this.tabPage1.Controls.Add(this.ChangeDateDatePicker);
            this.tabPage1.Controls.Add(this.MakeTextBox);
            this.tabPage1.Controls.Add(this.PriceTextBox);
            this.tabPage1.Controls.Add(this.ChangeDateLabel);
            this.tabPage1.Controls.Add(this.MakeLabel);
            this.tabPage1.Controls.Add(this.PriceLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.MaintenanceBox);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantainance";
            // 
            // KilometersOnChangeTextBox
            // 
            this.KilometersOnChangeTextBox.Location = new System.Drawing.Point(9, 192);
            this.KilometersOnChangeTextBox.Name = "KilometersOnChangeTextBox";
            this.KilometersOnChangeTextBox.Size = new System.Drawing.Size(184, 20);
            this.KilometersOnChangeTextBox.TabIndex = 10;
            // 
            // KiloetersOnChangeLabel
            // 
            this.KiloetersOnChangeLabel.AutoSize = true;
            this.KiloetersOnChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KiloetersOnChangeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KiloetersOnChangeLabel.Location = new System.Drawing.Point(6, 173);
            this.KiloetersOnChangeLabel.Name = "KiloetersOnChangeLabel";
            this.KiloetersOnChangeLabel.Size = new System.Drawing.Size(137, 16);
            this.KiloetersOnChangeLabel.TabIndex = 9;
            this.KiloetersOnChangeLabel.Text = "Kilometers on change";
            // 
            // AddMaintenanceBtn
            // 
            this.AddMaintenanceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMaintenanceBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddMaintenanceBtn.Location = new System.Drawing.Point(40, 300);
            this.AddMaintenanceBtn.Name = "AddMaintenanceBtn";
            this.AddMaintenanceBtn.Size = new System.Drawing.Size(100, 43);
            this.AddMaintenanceBtn.TabIndex = 8;
            this.AddMaintenanceBtn.Text = "Add Maintenance";
            this.AddMaintenanceBtn.UseVisualStyleBackColor = true;
            this.AddMaintenanceBtn.Click += new System.EventHandler(this.AddMaintenanceBtn_Click);
            // 
            // ChangeDateDatePicker
            // 
            this.ChangeDateDatePicker.Location = new System.Drawing.Point(6, 256);
            this.ChangeDateDatePicker.Name = "ChangeDateDatePicker";
            this.ChangeDateDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ChangeDateDatePicker.TabIndex = 7;
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(6, 142);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(184, 20);
            this.MakeTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(6, 91);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(104, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // ChangeDateLabel
            // 
            this.ChangeDateLabel.AutoSize = true;
            this.ChangeDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeDateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeDateLabel.Location = new System.Drawing.Point(10, 215);
            this.ChangeDateLabel.Name = "ChangeDateLabel";
            this.ChangeDateLabel.Size = new System.Drawing.Size(85, 16);
            this.ChangeDateLabel.TabIndex = 4;
            this.ChangeDateLabel.Text = "Change date";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MakeLabel.Location = new System.Drawing.Point(10, 119);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(42, 16);
            this.MakeLabel.TabIndex = 3;
            this.MakeLabel.Text = "Make";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PriceLabel.Location = new System.Drawing.Point(6, 72);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(39, 16);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantainance";
            // 
            // MaintenanceBox
            // 
            this.MaintenanceBox.FormattingEnabled = true;
            this.MaintenanceBox.Location = new System.Drawing.Point(6, 25);
            this.MaintenanceBox.Name = "MaintenanceBox";
            this.MaintenanceBox.Size = new System.Drawing.Size(184, 21);
            this.MaintenanceBox.TabIndex = 0;
            // 
            // ReviewTab
            // 
            this.ReviewTab.BackColor = System.Drawing.Color.Gainsboro;
            this.ReviewTab.Controls.Add(this.InformationLabel);
            this.ReviewTab.Controls.Add(this.NewReviwGroup);
            this.ReviewTab.Controls.Add(this.AddContributionGroup);
            this.ReviewTab.Location = new System.Drawing.Point(4, 22);
            this.ReviewTab.Name = "ReviewTab";
            this.ReviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReviewTab.Size = new System.Drawing.Size(502, 422);
            this.ReviewTab.TabIndex = 1;
            this.ReviewTab.Text = "Застраховка";
            // 
            // NewReviwGroup
            // 
            this.NewReviwGroup.BackColor = System.Drawing.Color.LightGray;
            this.NewReviwGroup.Controls.Add(this.InsuranceAngecyCombo);
            this.NewReviwGroup.Controls.Add(this.InsuranceAngencyLabel);
            this.NewReviwGroup.Controls.Add(this.groupBox1);
            this.NewReviwGroup.Controls.Add(this.MounthsLabel);
            this.NewReviwGroup.Controls.Add(this.MounthsCombo);
            this.NewReviwGroup.Controls.Add(this.ReviewMounthsCountLabel);
            this.NewReviwGroup.Controls.Add(this.Leva2Label);
            this.NewReviwGroup.Controls.Add(this.ReviewPriceTextBox);
            this.NewReviwGroup.Controls.Add(this.ReviewPriceLabel);
            this.NewReviwGroup.Controls.Add(this.ReviewStartDateLabel);
            this.NewReviwGroup.Controls.Add(this.ReviewStartDate);
            this.NewReviwGroup.Controls.Add(this.AddReviewButton);
            this.NewReviwGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReviwGroup.Location = new System.Drawing.Point(12, 117);
            this.NewReviwGroup.Name = "NewReviwGroup";
            this.NewReviwGroup.Size = new System.Drawing.Size(484, 299);
            this.NewReviwGroup.TabIndex = 4;
            this.NewReviwGroup.TabStop = false;
            this.NewReviwGroup.Text = "Нова застраховка";
            // 
            // InsuranceAngecyCombo
            // 
            this.InsuranceAngecyCombo.FormattingEnabled = true;
            this.InsuranceAngecyCombo.Location = new System.Drawing.Point(191, 34);
            this.InsuranceAngecyCombo.Name = "InsuranceAngecyCombo";
            this.InsuranceAngecyCombo.Size = new System.Drawing.Size(272, 26);
            this.InsuranceAngecyCombo.TabIndex = 11;
            // 
            // InsuranceAngencyLabel
            // 
            this.InsuranceAngencyLabel.AutoSize = true;
            this.InsuranceAngencyLabel.Location = new System.Drawing.Point(275, 13);
            this.InsuranceAngencyLabel.Name = "InsuranceAngencyLabel";
            this.InsuranceAngencyLabel.Size = new System.Drawing.Size(188, 18);
            this.InsuranceAngencyLabel.TabIndex = 10;
            this.InsuranceAngencyLabel.Text = "Застрахователна Агенция";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FourRadio);
            this.groupBox1.Controls.Add(this.ThreeRadio);
            this.groupBox1.Controls.Add(this.TwoRadio);
            this.groupBox1.Controls.Add(this.OneRadio);
            this.groupBox1.Location = new System.Drawing.Point(6, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вноски";
            // 
            // FourRadio
            // 
            this.FourRadio.AutoSize = true;
            this.FourRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourRadio.Location = new System.Drawing.Point(6, 113);
            this.FourRadio.Name = "FourRadio";
            this.FourRadio.Size = new System.Drawing.Size(83, 20);
            this.FourRadio.TabIndex = 3;
            this.FourRadio.TabStop = true;
            this.FourRadio.Text = "4 Вноски";
            this.FourRadio.UseVisualStyleBackColor = true;
            // 
            // ThreeRadio
            // 
            this.ThreeRadio.AutoSize = true;
            this.ThreeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeRadio.Location = new System.Drawing.Point(6, 87);
            this.ThreeRadio.Name = "ThreeRadio";
            this.ThreeRadio.Size = new System.Drawing.Size(83, 20);
            this.ThreeRadio.TabIndex = 2;
            this.ThreeRadio.TabStop = true;
            this.ThreeRadio.Text = "3 Вноски";
            this.ThreeRadio.UseVisualStyleBackColor = true;
            // 
            // TwoRadio
            // 
            this.TwoRadio.AutoSize = true;
            this.TwoRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoRadio.Location = new System.Drawing.Point(6, 61);
            this.TwoRadio.Name = "TwoRadio";
            this.TwoRadio.Size = new System.Drawing.Size(83, 20);
            this.TwoRadio.TabIndex = 1;
            this.TwoRadio.TabStop = true;
            this.TwoRadio.Text = "2 Вноски";
            this.TwoRadio.UseVisualStyleBackColor = true;
            // 
            // OneRadio
            // 
            this.OneRadio.AutoSize = true;
            this.OneRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneRadio.Location = new System.Drawing.Point(7, 33);
            this.OneRadio.Name = "OneRadio";
            this.OneRadio.Size = new System.Drawing.Size(83, 20);
            this.OneRadio.TabIndex = 0;
            this.OneRadio.TabStop = true;
            this.OneRadio.Text = "1 Вноска";
            this.OneRadio.UseVisualStyleBackColor = true;
            // 
            // MounthsLabel
            // 
            this.MounthsLabel.AutoSize = true;
            this.MounthsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MounthsLabel.Location = new System.Drawing.Point(408, 195);
            this.MounthsLabel.Name = "MounthsLabel";
            this.MounthsLabel.Size = new System.Drawing.Size(58, 16);
            this.MounthsLabel.TabIndex = 8;
            this.MounthsLabel.Text = "Месеца";
            // 
            // MounthsCombo
            // 
            this.MounthsCombo.FormattingEnabled = true;
            this.MounthsCombo.Location = new System.Drawing.Point(359, 185);
            this.MounthsCombo.Name = "MounthsCombo";
            this.MounthsCombo.Size = new System.Drawing.Size(43, 26);
            this.MounthsCombo.TabIndex = 7;
            // 
            // ReviewMounthsCountLabel
            // 
            this.ReviewMounthsCountLabel.AutoSize = true;
            this.ReviewMounthsCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReviewMounthsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewMounthsCountLabel.Location = new System.Drawing.Point(221, 179);
            this.ReviewMounthsCountLabel.Name = "ReviewMounthsCountLabel";
            this.ReviewMounthsCountLabel.Size = new System.Drawing.Size(132, 32);
            this.ReviewMounthsCountLabel.TabIndex = 6;
            this.ReviewMounthsCountLabel.Text = "Продължителност \r\nна застраховката";
            this.ReviewMounthsCountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Leva2Label
            // 
            this.Leva2Label.AutoSize = true;
            this.Leva2Label.Location = new System.Drawing.Point(408, 145);
            this.Leva2Label.Name = "Leva2Label";
            this.Leva2Label.Size = new System.Drawing.Size(29, 18);
            this.Leva2Label.TabIndex = 5;
            this.Leva2Label.Text = "лв.";
            // 
            // ReviewPriceTextBox
            // 
            this.ReviewPriceTextBox.Location = new System.Drawing.Point(359, 145);
            this.ReviewPriceTextBox.Name = "ReviewPriceTextBox";
            this.ReviewPriceTextBox.Size = new System.Drawing.Size(43, 24);
            this.ReviewPriceTextBox.TabIndex = 4;
            // 
            // ReviewPriceLabel
            // 
            this.ReviewPriceLabel.AutoSize = true;
            this.ReviewPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewPriceLabel.Location = new System.Drawing.Point(251, 137);
            this.ReviewPriceLabel.Name = "ReviewPriceLabel";
            this.ReviewPriceLabel.Size = new System.Drawing.Size(102, 32);
            this.ReviewPriceLabel.TabIndex = 3;
            this.ReviewPriceLabel.Text = "              Цена на\r\n затраховката";
            // 
            // ReviewStartDateLabel
            // 
            this.ReviewStartDateLabel.AutoSize = true;
            this.ReviewStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewStartDateLabel.Location = new System.Drawing.Point(152, 104);
            this.ReviewStartDateLabel.Name = "ReviewStartDateLabel";
            this.ReviewStartDateLabel.Size = new System.Drawing.Size(102, 16);
            this.ReviewStartDateLabel.TabIndex = 2;
            this.ReviewStartDateLabel.Text = "Започната на:";
            // 
            // ReviewStartDate
            // 
            this.ReviewStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewStartDate.Location = new System.Drawing.Point(260, 99);
            this.ReviewStartDate.Name = "ReviewStartDate";
            this.ReviewStartDate.Size = new System.Drawing.Size(218, 22);
            this.ReviewStartDate.TabIndex = 1;
            // 
            // AddReviewButton
            // 
            this.AddReviewButton.BackColor = System.Drawing.Color.LightGray;
            this.AddReviewButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReviewButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.AddReviewButton.Location = new System.Drawing.Point(349, 259);
            this.AddReviewButton.Name = "AddReviewButton";
            this.AddReviewButton.Size = new System.Drawing.Size(129, 40);
            this.AddReviewButton.TabIndex = 0;
            this.AddReviewButton.Text = "Добави вноска";
            this.AddReviewButton.UseVisualStyleBackColor = false;
            this.AddReviewButton.Click += new System.EventHandler(this.AddReviewButton_Click);
            // 
            // AddContributionGroup
            // 
            this.AddContributionGroup.BackColor = System.Drawing.Color.LightGray;
            this.AddContributionGroup.Controls.Add(this.LevaLabel);
            this.AddContributionGroup.Controls.Add(this.ContribuionPriceTextBox);
            this.AddContributionGroup.Controls.Add(this.ContributionPriceLabel);
            this.AddContributionGroup.Controls.Add(this.ContribuionDateLabel);
            this.AddContributionGroup.Controls.Add(this.ContributionDate);
            this.AddContributionGroup.Controls.Add(this.ReviewNumberComboBox);
            this.AddContributionGroup.Controls.Add(this.AddContributionButton);
            this.AddContributionGroup.Controls.Add(this.ReviewNumberLabel);
            this.AddContributionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContributionGroup.Location = new System.Drawing.Point(6, 6);
            this.AddContributionGroup.Name = "AddContributionGroup";
            this.AddContributionGroup.Size = new System.Drawing.Size(490, 84);
            this.AddContributionGroup.TabIndex = 3;
            this.AddContributionGroup.TabStop = false;
            this.AddContributionGroup.Text = "Вноска";
            // 
            // LevaLabel
            // 
            this.LevaLabel.AutoSize = true;
            this.LevaLabel.Location = new System.Drawing.Point(431, 60);
            this.LevaLabel.Name = "LevaLabel";
            this.LevaLabel.Size = new System.Drawing.Size(29, 18);
            this.LevaLabel.TabIndex = 7;
            this.LevaLabel.Text = "лв.";
            // 
            // ContribuionPriceTextBox
            // 
            this.ContribuionPriceTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ContribuionPriceTextBox.Location = new System.Drawing.Point(382, 56);
            this.ContribuionPriceTextBox.Name = "ContribuionPriceTextBox";
            this.ContribuionPriceTextBox.Size = new System.Drawing.Size(43, 24);
            this.ContribuionPriceTextBox.TabIndex = 6;
            // 
            // ContributionPriceLabel
            // 
            this.ContributionPriceLabel.AutoSize = true;
            this.ContributionPriceLabel.Location = new System.Drawing.Point(327, 60);
            this.ContributionPriceLabel.Name = "ContributionPriceLabel";
            this.ContributionPriceLabel.Size = new System.Drawing.Size(49, 18);
            this.ContributionPriceLabel.TabIndex = 5;
            this.ContributionPriceLabel.Text = "Сума:";
            // 
            // ContribuionDateLabel
            // 
            this.ContribuionDateLabel.AutoSize = true;
            this.ContribuionDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContribuionDateLabel.Location = new System.Drawing.Point(194, 0);
            this.ContribuionDateLabel.Name = "ContribuionDateLabel";
            this.ContribuionDateLabel.Size = new System.Drawing.Size(165, 16);
            this.ContribuionDateLabel.TabIndex = 4;
            this.ContribuionDateLabel.Text = "Направена вноска дата";
            // 
            // ContributionDate
            // 
            this.ContributionDate.Location = new System.Drawing.Point(197, 24);
            this.ContributionDate.Name = "ContributionDate";
            this.ContributionDate.Size = new System.Drawing.Size(239, 24);
            this.ContributionDate.TabIndex = 3;
            // 
            // ReviewNumberComboBox
            // 
            this.ReviewNumberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewNumberComboBox.FormattingEnabled = true;
            this.ReviewNumberComboBox.Location = new System.Drawing.Point(6, 54);
            this.ReviewNumberComboBox.Name = "ReviewNumberComboBox";
            this.ReviewNumberComboBox.Size = new System.Drawing.Size(185, 24);
            this.ReviewNumberComboBox.TabIndex = 0;
            // 
            // AddContributionButton
            // 
            this.AddContributionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContributionButton.Location = new System.Drawing.Point(197, 52);
            this.AddContributionButton.Name = "AddContributionButton";
            this.AddContributionButton.Size = new System.Drawing.Size(75, 26);
            this.AddContributionButton.TabIndex = 2;
            this.AddContributionButton.Text = "Вноска";
            this.AddContributionButton.UseVisualStyleBackColor = true;
            // 
            // ReviewNumberLabel
            // 
            this.ReviewNumberLabel.AutoSize = true;
            this.ReviewNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewNumberLabel.Location = new System.Drawing.Point(3, 35);
            this.ReviewNumberLabel.Name = "ReviewNumberLabel";
            this.ReviewNumberLabel.Size = new System.Drawing.Size(136, 16);
            this.ReviewNumberLabel.TabIndex = 1;
            this.ReviewNumberLabel.Text = "Застраховка номер";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(502, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLabel.Location = new System.Drawing.Point(1, 87);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(15, 32);
            this.InformationLabel.TabIndex = 5;
            this.InformationLabel.Text = "\r\n";
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 473);
            this.Controls.Add(this.MaintenanceControl);
            this.Name = "AddMaintenanceForm";
            this.Text = "AddMaintenanceForm";
            this.Load += new System.EventHandler(this.AddMaintenanceForm_Load);
            this.MaintenanceControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ReviewTab.ResumeLayout(false);
            this.ReviewTab.PerformLayout();
            this.NewReviwGroup.ResumeLayout(false);
            this.NewReviwGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AddContributionGroup.ResumeLayout(false);
            this.AddContributionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MaintenanceControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage ReviewTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker ChangeDateDatePicker;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label ChangeDateLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaintenanceBox;
        private System.Windows.Forms.Button AddMaintenanceBtn;
        private System.Windows.Forms.TextBox KilometersOnChangeTextBox;
        private System.Windows.Forms.Label KiloetersOnChangeLabel;
        private System.Windows.Forms.GroupBox AddContributionGroup;
        private System.Windows.Forms.ComboBox ReviewNumberComboBox;
        private System.Windows.Forms.Label ReviewNumberLabel;
        private System.Windows.Forms.Button AddContributionButton;
        private System.Windows.Forms.DateTimePicker ContributionDate;
        private System.Windows.Forms.TextBox ContribuionPriceTextBox;
        private System.Windows.Forms.Label ContributionPriceLabel;
        private System.Windows.Forms.Label ContribuionDateLabel;
        private System.Windows.Forms.GroupBox NewReviwGroup;
        private System.Windows.Forms.Button AddReviewButton;
        private System.Windows.Forms.Label LevaLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FourRadio;
        private System.Windows.Forms.RadioButton ThreeRadio;
        private System.Windows.Forms.RadioButton TwoRadio;
        private System.Windows.Forms.RadioButton OneRadio;
        private System.Windows.Forms.Label MounthsLabel;
        private System.Windows.Forms.ComboBox MounthsCombo;
        private System.Windows.Forms.Label ReviewMounthsCountLabel;
        private System.Windows.Forms.Label Leva2Label;
        private System.Windows.Forms.TextBox ReviewPriceTextBox;
        private System.Windows.Forms.Label ReviewPriceLabel;
        private System.Windows.Forms.Label ReviewStartDateLabel;
        private System.Windows.Forms.DateTimePicker ReviewStartDate;
        private System.Windows.Forms.Label InsuranceAngencyLabel;
        private System.Windows.Forms.ComboBox InsuranceAngecyCombo;
        private System.Windows.Forms.Label InformationLabel;
    }
}