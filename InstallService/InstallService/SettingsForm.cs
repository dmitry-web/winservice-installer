using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallService
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            unistallNameTxb.Text = Properties.Settings.Default.AllowedUnistallName;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AllowedUnistallName = unistallNameTxb.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
