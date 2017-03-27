namespace InstallService
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.unistallBtn = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.loadingPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.btnKill = new MetroFramework.Controls.MetroButton();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(123, 255);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(71, 40);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseSelectable = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // unistallBtn
            // 
            this.unistallBtn.Enabled = false;
            this.unistallBtn.Location = new System.Drawing.Point(200, 255);
            this.unistallBtn.Name = "unistallBtn";
            this.unistallBtn.Size = new System.Drawing.Size(73, 40);
            this.unistallBtn.TabIndex = 9;
            this.unistallBtn.Text = "Unistall";
            this.unistallBtn.UseSelectable = true;
            this.unistallBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(43, 255);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 40);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(31, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Name:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(31, 114);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Status:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(31, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Path:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(93, 147);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(363, 71);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLb.Location = new System.Drawing.Point(90, 119);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(20, 16);
            this.statusLb.TabIndex = 18;
            this.statusLb.Text = "---";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.Location = new System.Drawing.Point(90, 91);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(20, 16);
            this.nameLb.TabIndex = 19;
            this.nameLb.Text = "---";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(360, 255);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(72, 40);
            this.metroButton3.TabIndex = 20;
            this.metroButton3.Text = "Close";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(140, 28);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(78, 73);
            this.metroProgressSpinner1.Speed = 2F;
            this.metroProgressSpinner1.TabIndex = 21;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 25;
            this.metroProgressSpinner1.Visible = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.metroProgressSpinner1);
            this.loadingPanel.HorizontalScrollbarBarColor = true;
            this.loadingPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.loadingPanel.HorizontalScrollbarSize = 10;
            this.loadingPanel.Location = new System.Drawing.Point(31, 63);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(401, 144);
            this.loadingPanel.TabIndex = 22;
            this.loadingPanel.VerticalScrollbarBarColor = true;
            this.loadingPanel.VerticalScrollbarHighlightOnWheel = false;
            this.loadingPanel.VerticalScrollbarSize = 10;
            this.loadingPanel.Visible = false;
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroLink1.Location = new System.Drawing.Point(394, 5);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(23, 23);
            this.metroLink1.TabIndex = 23;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(279, 255);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(75, 40);
            this.btnKill.TabIndex = 25;
            this.btnKill.Text = "Kill";
            this.btnKill.UseSelectable = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 318);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.unistallBtn);
            this.Controls.Add(this.btnStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServiceForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.loadingPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton unistallBtn;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label statusLb;
        private System.Windows.Forms.Label nameLb;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroPanel loadingPanel;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton btnKill;
    }
}