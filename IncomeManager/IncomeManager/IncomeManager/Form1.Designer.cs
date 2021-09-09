
namespace IncomeManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(27, 32);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(112, 75);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 438);
            this.Controls.Add(this.AddUser);
            this.Name = "Form1";
            this.Text = "Income manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUser;
    }
}

