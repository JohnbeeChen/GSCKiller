using Johnbee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSCkiller.Forms;
using Johnbee;

namespace GSCKiller.Forms
{
    public partial class GSC_Controller : Form
    {
        IPortWriteReceive MySerialPort;
        
        void MyWriteMethod(string s)
        {
            MySerialPort.WriteString(s);
        }

        public GSC_Controller(IPortWriteReceive myPort)
        {
            MySerialPort = myPort;
            InitializeComponent();
            MySerialPort.PortReceiveEvent += MyPort_ComDataReceivedEvent;
        }
        ~GSC_Controller()
        {
            MySerialPort.PortReceiveEvent -= MyPort_ComDataReceivedEvent;
        }
        private void MyPort_ComDataReceivedEvent(string s)
        {
         //   throw new NotImplementedException();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            string cmd = "H:W--";
            MyWriteMethod(cmd);
        }
    }
}
