namespace InstallService
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.utilPathTb = new MetroFramework.Controls.MetroTextBox();
            this.servicePathTb = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.utilFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.serviceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.aboutLnk = new MetroFramework.Controls.MetroLink();
            this.installBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serviceInstallerRb = new MetroFramework.Controls.MetroRadioButton();
            this.installUtilRb = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Services = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.StartStop = new System.Windows.Forms.DataGridViewImageColumn();
            this.Restart = new System.Windows.Forms.DataGridViewImageColumn();
            this.Manage = new System.Windows.Forms.DataGridViewImageColumn();
            this.notifierTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsLnk = new MetroFramework.Controls.MetroLink();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // utilPathTb
            // 
            // 
            // 
            // 
            this.utilPathTb.CustomButton.BackColor = System.Drawing.Color.Gainsboro;
            this.utilPathTb.CustomButton.Image = null;
            this.utilPathTb.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.utilPathTb.CustomButton.Name = "";
            this.utilPathTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.utilPathTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.utilPathTb.CustomButton.TabIndex = 1;
            this.utilPathTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.utilPathTb.CustomButton.UseSelectable = true;
            this.utilPathTb.CustomButton.UseVisualStyleBackColor = false;
            this.utilPathTb.CustomButton.Visible = false;
            this.utilPathTb.Lines = new string[0];
            this.utilPathTb.Location = new System.Drawing.Point(109, 47);
            this.utilPathTb.MaxLength = 32767;
            this.utilPathTb.Name = "utilPathTb";
            this.utilPathTb.PasswordChar = '\0';
            this.utilPathTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.utilPathTb.SelectedText = "";
            this.utilPathTb.SelectionLength = 0;
            this.utilPathTb.SelectionStart = 0;
            this.utilPathTb.Size = new System.Drawing.Size(303, 23);
            this.utilPathTb.Style = MetroFramework.MetroColorStyle.Lime;
            this.utilPathTb.TabIndex = 0;
            this.utilPathTb.UseSelectable = true;
            this.utilPathTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.utilPathTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // servicePathTb
            // 
            // 
            // 
            // 
            this.servicePathTb.CustomButton.BackColor = System.Drawing.Color.White;
            this.servicePathTb.CustomButton.Image = null;
            this.servicePathTb.CustomButton.Location = new System.Drawing.Point(381, 1);
            this.servicePathTb.CustomButton.Name = "";
            this.servicePathTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.servicePathTb.CustomButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.servicePathTb.CustomButton.TabIndex = 1;
            this.servicePathTb.CustomButton.Text = "jhk";
            this.servicePathTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.servicePathTb.CustomButton.UseCustomBackColor = true;
            this.servicePathTb.CustomButton.UseSelectable = true;
            this.servicePathTb.CustomButton.UseVisualStyleBackColor = false;
            this.servicePathTb.CustomButton.Visible = false;
            this.servicePathTb.Lines = new string[0];
            this.servicePathTb.Location = new System.Drawing.Point(9, 95);
            this.servicePathTb.MaxLength = 32767;
            this.servicePathTb.Name = "servicePathTb";
            this.servicePathTb.PasswordChar = '\0';
            this.servicePathTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.servicePathTb.SelectedText = "";
            this.servicePathTb.SelectionLength = 0;
            this.servicePathTb.SelectionStart = 0;
            this.servicePathTb.Size = new System.Drawing.Size(403, 23);
            this.servicePathTb.Style = MetroFramework.MetroColorStyle.Lime;
            this.servicePathTb.TabIndex = 1;
            this.servicePathTb.UseCustomBackColor = true;
            this.servicePathTb.UseSelectable = true;
            this.servicePathTb.UseStyleColors = true;
            this.servicePathTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.servicePathTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Path to Service";
            // 
            // aboutLnk
            // 
            this.aboutLnk.Location = new System.Drawing.Point(946, 6);
            this.aboutLnk.Name = "aboutLnk";
            this.aboutLnk.Size = new System.Drawing.Size(52, 23);
            this.aboutLnk.TabIndex = 9;
            this.aboutLnk.Text = "about";
            this.aboutLnk.UseSelectable = true;
            // 
            // installBtn
            // 
            this.installBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.installBtn.Location = new System.Drawing.Point(362, 217);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(89, 40);
            this.installBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.installBtn.TabIndex = 6;
            this.installBtn.Text = "Install";
            this.installBtn.UseSelectable = true;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serviceInstallerRb);
            this.groupBox1.Controls.Add(this.installUtilRb);
            this.groupBox1.Controls.Add(this.servicePathTb);
            this.groupBox1.Controls.Add(this.installBtn);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.utilPathTb);
            this.groupBox1.Location = new System.Drawing.Point(20, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 272);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // serviceInstallerRb
            // 
            this.serviceInstallerRb.AutoSize = true;
            this.serviceInstallerRb.Location = new System.Drawing.Point(9, 26);
            this.serviceInstallerRb.Name = "serviceInstallerRb";
            this.serviceInstallerRb.Size = new System.Drawing.Size(137, 15);
            this.serviceInstallerRb.Style = MetroFramework.MetroColorStyle.Green;
            this.serviceInstallerRb.TabIndex = 8;
            this.serviceInstallerRb.Text = "Use AssemblyInstaller";
            this.serviceInstallerRb.UseSelectable = true;
            this.serviceInstallerRb.CheckedChanged += new System.EventHandler(this.serviceInstallerRb_CheckedChanged);
            // 
            // installUtilRb
            // 
            this.installUtilRb.AutoSize = true;
            this.installUtilRb.Checked = true;
            this.installUtilRb.Location = new System.Drawing.Point(9, 51);
            this.installUtilRb.Name = "installUtilRb";
            this.installUtilRb.Size = new System.Drawing.Size(94, 15);
            this.installUtilRb.Style = MetroFramework.MetroColorStyle.Green;
            this.installUtilRb.TabIndex = 7;
            this.installUtilRb.TabStop = true;
            this.installUtilRb.Text = "Use InstallUtil";
            this.installUtilRb.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(418, 95);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(33, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(418, 47);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(33, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(20, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 228);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(11, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(415, 159);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Services
            // 
            this.Services.Controls.Add(this.button2);
            this.Services.Controls.Add(this.button1);
            this.Services.Controls.Add(this.metroTextBox1);
            this.Services.Controls.Add(this.metroGrid1);
            this.Services.Location = new System.Drawing.Point(499, 77);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(502, 506);
            this.Services.TabIndex = 22;
            this.Services.TabStop = false;
            this.Services.Text = "Services";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::InstallService.Properties.Resources.Search;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(413, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 25);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(454, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.BackColor = System.Drawing.Color.White;
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(381, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseCustomBackColor = true;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.UseVisualStyleBackColor = false;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(9, 22);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(403, 23);
            this.metroTextBox1.TabIndex = 22;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartStop,
            this.Restart,
            this.Manage});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(6, 52);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(493, 451);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 21;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellDoubleClick);
            // 
            // StartStop
            // 
            this.StartStop.HeaderText = "";
            this.StartStop.Image = global::InstallService.Properties.Resources.start_icon;
            this.StartStop.Name = "StartStop";
            this.StartStop.ReadOnly = true;
            // 
            // Restart
            // 
            this.Restart.HeaderText = "";
            this.Restart.Image = global::InstallService.Properties.Resources.restart_icon;
            this.Restart.Name = "Restart";
            this.Restart.ReadOnly = true;
            // 
            // Manage
            // 
            this.Manage.HeaderText = "";
            this.Manage.Image = global::InstallService.Properties.Resources.settings_icon;
            this.Manage.Name = "Manage";
            this.Manage.ReadOnly = true;
            this.Manage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Manage.Width = 60;
            // 
            // notifierTimer
            // 
            this.notifierTimer.Interval = 3000;
            this.notifierTimer.Tick += new System.EventHandler(this.notifierTimer_Tick);
            // 
            // settingsLnk
            // 
            this.settingsLnk.Image = global::InstallService.Properties.Resources.settings_icon;
            this.settingsLnk.Location = new System.Drawing.Point(927, 6);
            this.settingsLnk.Name = "settingsLnk";
            this.settingsLnk.Size = new System.Drawing.Size(22, 23);
            this.settingsLnk.TabIndex = 23;
            this.settingsLnk.UseSelectable = true;
            this.settingsLnk.Click += new System.EventHandler(this.settingsLnk_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 598);
            this.Controls.Add(this.settingsLnk);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aboutLnk);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Service Installer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.Services.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox utilPathTb;
        private MetroFramework.Controls.MetroTextBox servicePathTb;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton installBtn;
        private System.Windows.Forms.OpenFileDialog utilFileDialog;
        private System.Windows.Forms.OpenFileDialog serviceFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink aboutLnk;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton serviceInstallerRb;
        private MetroFramework.Controls.MetroRadioButton installUtilRb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewImageColumn StartStop;
        private System.Windows.Forms.DataGridViewImageColumn Restart;
        private System.Windows.Forms.DataGridViewImageColumn Manage;
        private System.Windows.Forms.Timer notifierTimer;
        private MetroFramework.Controls.MetroLink settingsLnk;
    }
}

