using MVVM_TestApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_TestApp
{
    public class SafetyData
    {
        public List<Device> Devices { get; set; }
        public List<SafetyDevice> SafetyDevices { get; set; }
        public List<Device> GetDevicesAndSafetyDevices(int devicesAmount, int safetyDevicesAmount)
        {
            List<Device> output = new List<Device>();
            for (int i = 0; i < devicesAmount; i++)
            {
                output.Add(new Device(i+1));
                ObservableCollection<SafetyDevice> safetyDevices = new ObservableCollection<SafetyDevice>();
                for (int j = 0; j < safetyDevicesAmount; j++)
                {
                    safetyDevices.Add(new SafetyDevice(i + 1));
                }
                output.Last().SafetyDevices = safetyDevices;
            }
            return output;
        }
    }
}