using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johnbee
{
    public delegate void PortReceivedString(string s);
    
    public interface IPortWriteReceive
    {
        void WriteString(string s);
        void WriteByteArray(byte[] s);
        event PortReceivedString PortReceiveEvent;
    }

}
