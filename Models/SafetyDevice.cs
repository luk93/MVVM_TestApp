using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_TestApp.Models
{
    public class SafetyDevice
    {
        public string Name { get; set; }
        public int Column { get; set; }
        public SafetyDevice(int column)
        {
            Column = column;
            Name = $"Name {column.ToString()}";
        }
    }
}
