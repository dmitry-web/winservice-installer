using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallService.Helpers
{
    public class ServiceHelper
    {
        public static List<ServiceData> GetServices(string search = "")
        {
            try
            {
                var data = new List<ServiceData>();

                var services = ServiceController.GetServices();
                if(services!=null)
                {
                    if (!string.IsNullOrEmpty(search))
                        services = services.Where(s => s.ServiceName.ToLower().Contains(search.ToLower()) || s.DisplayName.ToLower().Contains(search.ToLower())).ToArray();
                    
                    foreach(var service in services)
                    {
                        data.Add(new ServiceData() { ServiceDisplayName = service.DisplayName, ServiceName = service.ServiceName, Status = service.Status.ToString() });
                    }
                }

                return data;
                
            }

            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return new List<ServiceData>();
            }

            
        }

        public static AppService GetServiceByName(string name)
        {
            try
            {
                var scServices = ServiceController.GetServices();

                if (scServices != null && !string.IsNullOrEmpty(name))
                {
                    var _service = scServices.FirstOrDefault(s => s.ServiceName == name);
                    if (_service != null)
                    {
                        var service = new AppService();
                        service.DisplayName = _service.DisplayName;
                        service.Name = _service.ServiceName;
                        service.Status = _service.Status.ToString();
                        service.Path = GetPathOfService(name);

                        return service;
                    }
                }



                return null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

        public static string GetPathOfService(string serviceName)
        {
            try
            {
                WqlObjectQuery wqlObjectQuery = new WqlObjectQuery(string.Format("SELECT * FROM Win32_Service WHERE Name = '{0}'", serviceName));
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(wqlObjectQuery);
                ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();

                foreach (ManagementObject managementObject in managementObjectCollection)
                {
                    return managementObject.GetPropertyValue("PathName").ToString();
                }

                return string.Empty;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return string.Empty;
            }

        }

        [System.Obsolete("UnInstallService is deprecated, please use Helpers.ServiceInstaller.Uninstall instead.")]
        public static void UnInstallService(string ServiceProgramPath)
        {

            string NetFrameWorkPath = "C:/Windows/Microsoft.NET/Framework/v4.0.30319/";

            NetFrameWorkPath = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory();

            var process = Process.Start(NetFrameWorkPath + "InstallUtil.exe", "-u \"" + ServiceProgramPath + "\"");

        }

        public static void InstallService(string utilPath, string servicePath)
        {
            if(!string.IsNullOrEmpty(utilPath) && !string.IsNullOrEmpty(servicePath))
            {
                Process.Start(utilPath, "\"" + servicePath + "\"");
            }
            else
            {
                MessageBox.Show("Paths are required");
            }

        }

    }


    public class ServiceData
    {
        public string ServiceName { get; set; }
        public string ServiceDisplayName { get; set; }
        public string Status { get; set; }
    }

    public class AppService
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Status { get; set; }
        public string Path { get; set; }
    }
}
