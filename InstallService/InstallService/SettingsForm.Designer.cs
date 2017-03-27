namespace InstallService
{
    partial class SettingsForm
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
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.unistallNameTxb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(328, 234);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(96, 39);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // unistallNameTxb
            // 
            // 
            // 
            // 
            this.unistallNameTxb.CustomButton.Image = null;
            this.unistallNameTxb.CustomButton.Location = new System.Drawing.Point(369, 1);
            this.unistallNameTxb.CustomButton.Name = "";
            this.unistallNameTxb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.unistallNameTxb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unistallNameTxb.CustomButton.TabIndex = 1;
            this.unistallNameTxb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unistallNameTxb.CustomButton.UseSelectable = true;
            this.unistallNameTxb.CustomButton.Visible = false;
            this.unistallNameTxb.Lines = new string[0];
            this.unistallNameTxb.Location = new System.Drawing.Point(33, 99);
            this.unistallNameTxb.MaxLength = 32767;
            this.unistallNameTxb.Name = "unistallNameTxb";
            this.unistallNameTxb.PasswordChar = '\0';
            this.unistallNameTxb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unistallNameTxb.SelectedText = "";
            this.unistallNameTxb.SelectionLength = 0;
            this.unistallNameTxb.SelectionStart = 0;
            this.unistallNameTxb.Size = new System.Drawing.Size(391, 23);
            this.unistallNameTxb.TabIndex = 1;
            this.unistallNameTxb.UseSelectable = true;
            this.unistallNameTxb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unistallNameTxb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(208, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Allow to unistall service with name";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 296);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.unistallNameTxb);
            this.Controls.Add(this.saveBtn);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Resizable = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroTextBox unistallNameTxb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}