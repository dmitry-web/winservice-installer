using InstallService.Helpers;
using InstallService.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallService
{
    public partial class Main : MetroForm
    {
        List<ServiceNotifier> notifications = new List<ServiceNotifier>();
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.InstallType == 1)
            {
                installUtilRb.Checked = true;
            }
            else
            {
                serviceInstallerRb.Checked = true;
            }

            utilFileDialog.FileName = Properties.Settings.Default.UtilPath;
            utilPathTb.Text = Properties.Settings.Default.UtilPath;

            aboutLnk.Left = this.Width - 100;
            settingsLnk.Left = aboutLnk.Left - settingsLnk.Width;
            LoadServices();
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                metroGrid1.Columns["StartStop"].DisplayIndex = 5;
                metroGrid1.Columns["Restart"].DisplayIndex = 5;
                metroGrid1.Columns["Manage"].DisplayIndex = 5;
                metroGrid1.Columns["StartStop"].Width = 20;
                metroGrid1.Columns["Restart"].Width = 25;
                metroGrid1.Columns["Manage"].Width = 25;
            }
            catch
            {

            }

            LoadServices();

            LoadMachineInfo();
            ShowOptions();          
        }

        #region MachineInfo
        private void LoadMachineInfo()
        {


            richTextBox1.Text = String.Format("PC Name: {0}", Environment.MachineName)
                + Environment.NewLine + String.Format("CPU: {0}  ({1} cores)", HardwareInfo.GetProcessorInformation().ToString(), Environment.ProcessorCount)
                + Environment.NewLine + String.Format("OS: {0}", HardwareInfo.GetOSInformation().ToString())
                + Environment.NewLine + String.Format("RAM: {0}", HardwareInfo.GetPhysicalMemory().ToString());

            MakeBold("PC Name:", richTextBox1, 8);
            MakeBold("CPU:", richTextBox1, 9);
            MakeBold("OS:", richTextBox1, 9);
            MakeBold("RAM:", richTextBox1, 9);
        }


        public static void MakeBold(string textToMark, RichTextBox richTextBox, int startIndex)
        {
            if (startIndex < 0 || startIndex > textToMark.Length - 1) startIndex = 0;

            System.Drawing.Font newFont = new Font("Verdana", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178, false);
            try
            {

                foreach (string line in richTextBox.Lines)
                {

                    if (line.Contains(textToMark))
                    {
                        richTextBox.Select(startIndex, textToMark.Length);
                        richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold);
                    }
                    startIndex += line.Length + 1;
                }
            }
            catch
            { }
        }

        #endregion

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (utilFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.UtilPath = utilFileDialog.FileName;
                Properties.Settings.Default.Save();
                utilPathTb.Text = utilFileDialog.FileName;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (serviceFileDialog.ShowDialog() == DialogResult.OK)
                servicePathTb.Text = serviceFileDialog.FileName;
        }

        private void serviceInstallerRb_CheckedChanged(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void ShowOptions()
        {
            Properties.Settings.Default.InstallType = serviceInstallerRb.Checked ? 0 : 1;
            utilPathTb.Visible = !serviceInstallerRb.Checked;
            metroButton1.Visible = !serviceInstallerRb.Checked; 
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = ServiceHelper.GetServices(metroTextBox1.Text);
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = metroGrid1.CurrentRow.Cells["ServiceName"].Value.ToString();

            var serviceForm = new ServiceForm(name, this);
            serviceForm.ShowDialog();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void installBtn_Click(object sender, EventArgs e)
        {
            if (installUtilRb.Checked)
                ServiceHelper.InstallService(utilPathTb.Text, servicePathTb.Text);

            if (serviceInstallerRb.Checked)
            {
                System.Configuration.Install.AssemblyInstaller Installer = new System.Configuration.Install.AssemblyInstaller(servicePathTb.Text, null);
                Installer.UseNewContext = true;
                Installer.Install(null);
                Installer.Commit(null);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = metroGrid1.Rows[e.RowIndex];
                    var name = row.Cells["ServiceName"].Value.ToString();
                    var status = row.Cells["Status"].Value.ToString();

                    if (e.ColumnIndex == 0)
                    {
                        if (status == ServiceState.Running.ToString())
                        {
                            var serviceController = new ServiceController(name);
                            serviceController.Stop();

                            notifications.Add(new ServiceNotifier() { ServiceName = name, StatusToCheck = ServiceState.Stopped.ToString() });
                            notifierTimer.Enabled = true;
                        }
                        else if (status == ServiceState.Stopped.ToString())
                        {
                            var serviceController = new ServiceController(name);
                            serviceController.Start();

                            notifications.Add(new ServiceNotifier() { ServiceName = name, StatusToCheck = ServiceState.Running.ToString() });
                            notifierTimer.Enabled = true;
                        }
                        else
                            MessageBox.Show("Service is busy");                                                 

                        LoadServices();

                    }

                    if (e.ColumnIndex == 2)
                    {
                        var serviceForm = new ServiceForm(name, this);
                        serviceForm.ShowDialog();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void LoadServices()
        {
            metroGrid1.DataSource = ServiceHelper.GetServices(metroTextBox1.Text);

            try
            {
                foreach (var row in metroGrid1.Rows)
                {
                    var gridRow = (DataGridViewRow)row;

                    var status = gridRow.Cells["Status"].Value.ToString();

                    switch (status)
                    {
                        case "Running":
                            gridRow.Cells["StartStop"].Value = (System.Drawing.Image)Properties.Resources.stop_icon;
                            gridRow.Cells["Status"].Style.BackColor = Color.GreenYellow;
                            gridRow.Cells["StartStop"].ToolTipText = " Stop Service";
                            break;

                        case "Stopped":
                            gridRow.Cells["StartStop"].Value = (System.Drawing.Image)Properties.Resources.start_icon;
                            gridRow.Cells["StartStop"].ToolTipText = " Start Service";
                            break;

                        default:
                            gridRow.Cells["StartStop"].Value = (System.Drawing.Image)Properties.Resources.loading_icon;
                            gridRow.Cells["StartStop"].ToolTipText = " Loading";
                            break;
                    }


                }
            }

            catch (Exception e)
            {

            }

        }

        private void notifierTimer_Tick(object sender, EventArgs e)
        {
            if (notifications != null && notifications.Any())
            {
                foreach (var servNotification in notifications.ToList())
                {

                    var service = ServiceHelper.GetServiceByName(servNotification.ServiceName);
                    if (service != null)
                    {
                        if (service.Status == servNotification.StatusToCheck)
                        {
                            notifications.Remove(servNotification);
                            LoadServices();

                            var statusMsg = "processed";

                            switch (servNotification.StatusToCheck)
                            {

                                case "Running":
                                    statusMsg = "started";
                                    break;

                                case "Stopped":
                                    statusMsg = "stopped";
                                    break;

                            }

                            var msg = String.Format("{0} service was successfully {1}", service.DisplayName, statusMsg);
                            var notification = new Notification("Service notification", msg, 8, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                            notification.Show();
                        }
                    }
                    else
                        notifications.Remove(servNotification);

                }
            }
            else
            {
                notifierTimer.Enabled = false;
            }

        }

        private void settingsLnk_Click(object sender, EventArgs e)
        {
            var settingsFrm = new SettingsForm();
            settingsFrm.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }

   
}
