using Caliburn.Micro;
using MVVM_TestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_TestApp.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public BindableCollection<Device> Devices { get; set; }
        public ShellViewModel()
        {
            SafetyData safetyData = new SafetyData();
            Devices = new BindableCollection<Device>(safetyData.GetDevicesAndSafetyDevices(400,10));
        }
    }
}
