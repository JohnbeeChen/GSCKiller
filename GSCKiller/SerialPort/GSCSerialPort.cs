using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Johnbee
{
    class GSCSerialPort
    {
        SerialPort MySerialPort = new SerialPort();
        bool CRLS_Flag = false;//回车换行标志

        public GSCSerialPort()
        {
            MySerialPort.DataReceived += MySerialPort_DataReceived;
        }

        public GSCSerialPort(SerialParameter myParameter)
        {
            CRLS_Flag = myParameter.CrlsEnable;

            MySerialPort.PortName = myParameter.PortName;
            MySerialPort.BaudRate = myParameter.BaudRate;
            MySerialPort.StopBits = myParameter.StopBits;
            MySerialPort.DataBits = myParameter.DataBits;
            MySerialPort.RtsEnable = myParameter.RtsEnable;

            MySerialPort.ReadBufferSize = 500000;
            MySerialPort.ReadTimeout = 50;
            MySerialPort.WriteBufferSize = 50000;
            MySerialPort.DataReceived += MySerialPort_DataReceived;
        }
        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            int t = 1;
        }


        public void GSC_Write(string cmd)
        {
            //char[] s = cmd.ToCharArray();
            byte[] s = { 0x71, 0x0d, 0x0a };
            cmd = "H:1-\r\n";
            MySerialPort.Write(cmd);
        }
        public int SerialPort_Open()
        {
            if (MySerialPort.IsOpen){return 1;}
            try
            {
                MySerialPort.Open();
                if (MySerialPort.IsOpen) { return 1; }
            }
            catch
            {
                MessageBox.Show("Open fiale!");
            }
            return 0;
        }
        public int SerialPort_Close()
        {
            try { MySerialPort.Close(); return 1; }
            catch
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Closed Failed!!!", "ERROR");
            }
            return 0;
        }
    }
}
