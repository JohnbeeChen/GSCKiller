using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Johnbee
{

    public class SerialParameter
    {
        public string PortName { get; set; }

        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        
		public StopBits StopBits { get; set; }
        
        public Parity Parity { get; set; }

        public bool RtsEnable { get; set; }
        public bool CrlsEnable { get; set; }

        public SerialParameter()
        {
            BaudRate = 9600;
            DataBits = 8;
            StopBits = StopBits.None;
            Parity = Parity.None;
            RtsEnable = false;
            CrlsEnable = false;
        }
    }
}
