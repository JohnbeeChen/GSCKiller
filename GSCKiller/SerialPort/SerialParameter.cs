using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnbee
{
    public class SerialParameter
    {
        public string com_name;
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public string PortName { get; set; }
        public StopBits StopBits { get; set; }
        public bool CtsHolding { get; }
        public SerialParameter()
        {

        }
        
    }
}
