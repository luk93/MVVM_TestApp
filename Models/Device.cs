using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_TestApp.Models
{
    public class Device
    {
        public string Name { get; set; }
        private int Row { get; set; }
        public ObservableCollection<SafetyDevice> SafetyDevices { get; set; } 
        public Device(int row)
        {
            Row = row;
            Name = $"Device {row.ToString()}";
        }
    }
}
