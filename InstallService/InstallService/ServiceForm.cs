using InstallService.Helpers;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallService
{
    public partial class ServiceForm : MetroForm
    {
        public string ServiceName { get; set; }
        public Main mainForm { get; set; }

        public ServiceForm(string name, Main mainForm)
        {
            InitializeComponent();
            this.ServiceName = name;
            this.mainForm = mainForm;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            LoadService();
        }

        #region Load Service

        private void LoadService()
        {
            var service = ServiceHelper.GetServiceByName(ServiceName);
            if (service != null)
            {
                Text = service.DisplayName;
                nameLb.Text = service.Name;
                richTextBox1.Text = service.Path;
                statusLb.Text = service.Status.ToString();

                if (service.Status == ServiceControllerStatus.Stopped.ToString())
                    statusLb.BackColor = Color.SandyBrown;

                if (service.Status == ServiceControllerStatus.Running.ToString())
                    statusLb.BackColor = Color.LightGreen;

                btnStart.Enabled = service.Status != ServiceControllerStatus.Running.ToString();
                btnStop.Enabled = service.Status != ServiceControllerStatus.Stopped.ToString();

                if (service.Path.Contains(Properties.Settings.Default.AllowedUnistallName))
                    unistallBtn.Enabled = true;

            }
        }

        #endregion

        #region StartService

        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Loader(true);
                Task<bool> task = Task.Run(() => StartService());

                var result = await task;

                Loader();
                LoadService();

            }

            catch (Exception ex)
            {
                Loader();
                MessageBox.Show(ex.Message);
            }

        }

        private bool StartService()
        {
            try
            {
                var serviceController = new ServiceController(ServiceName);
                serviceController.Start();
                Thread.Sleep(3000);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        #endregion

        #region StopService

        private async void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                Loader(true);
                Task<bool> task = Task.Run(() => StopService());

                var result = await task;

                Loader();
                LoadService();
            }

            catch (Exception ex)
            {
                Loader();
                MessageBox.Show(ex.Message);
            }
        }

        private bool StopService()
        {
            try
            {
                var serviceController = new ServiceController(ServiceName);
                serviceController.Stop();
                Thread.Sleep(3000);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        #endregion

        #region UnistallService

        private async void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Loader(true);
                Task<bool> task = Task.Run(() => UnistallService());
                var result = await task;
                Loader();
                Close();
                MessageBox.Show("Service unistalled !");
                mainForm.LoadServices();
            }

            catch (Exception ex)
            {
                Loader();
                MessageBox.Show(ex.Message);
            }

        }

        private bool UnistallService()
        {
            try
            {
                Helpers.ServiceInstaller.Uninstall(ServiceName);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        #endregion

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loader(bool start = false)
        {
            loadingPanel.Visible = start;
            metroProgressSpinner1.Visible = start;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            LoadService();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            try
            {
                var proc = Process.GetProcessesByName(ServiceName);
                if (proc != null)
                {
                    proc.First().Kill();
                    LoadService();
                    MessageBox.Show($"Successfully killed {ServiceName} Id:{proc.First().Id}");
                }
            }
            catch
            {
                MessageBox.Show("Unable to kill process");
            }

        }
    }
}
