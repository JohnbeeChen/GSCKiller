using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Johnbee
{
    public class GSCSerialPort: IPortWriteReceive
    {
        SerialPort MySerialPort = new SerialPort();
        bool CRLS_Flag = false;//回车换行标志  
        public bool IsOpen { get { return _isopen; }}
        bool _isopen = false;
        //public delegate void ComDataChangeDelegate(string s);
        //public event ComDataChangeDelegate ComDataReceivedEvent;/*串口接收完成事件*/
        public event PortReceivedString PortReceiveEvent;

        public GSCSerialPort()
        {
            MySerialPort.DataReceived += MySerialPort_DataReceived;
        }

        /// <summary>
        /// initiallize the port with @myParameter
        /// </summary>
        /// <param name="myParameter"></param>
        public void GSCSerialPortInit(SerialParameter myParameter)
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
        }
        ~ GSCSerialPort()
        {
            MySerialPort.DataReceived -= MySerialPort_DataReceived;
        }
        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {        
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            PortReceiveEvent(indata);
        }


        //public void GSC_Write(string cmd)
        //{
        //    if (!MySerialPort.IsOpen)
        //    {
        //        MessageBox.Show("Serial Part is closed!");
        //        return;
        //    }
        //    string s = cmd;
        //    if (CRLS_Flag) {s = cmd + "\r\n";}
        //    //cmd = "H:1-\r\n";
        //    MySerialPort.Write(s);
        //}
        //public void GSC_Write(byte[] cmd)
        //{
        //    if (!MySerialPort.IsOpen)
        //    {
        //        MessageBox.Show("Serial Part is closed!");
        //        return;
        //    }
        //    var len = cmd.Length;
        //    byte[] s = cmd;
        //    if (CRLS_Flag)
        //    {
        //        s[len + 1] = (byte)'\r';
        //        s[len + 2] = (byte)'\n';
        //        MySerialPort.Write(s,0,len+2);
        //    }
        //}

        public int SerialPort_Open()
        {
            if (MySerialPort.IsOpen)
            {
                _isopen = true;
                return 1;
            }
            try
            {
                MySerialPort.Open();
                if (MySerialPort.IsOpen)
                {
                    _isopen = true;
                    return 1;
                }
            }
            catch
            {
                MessageBox.Show("Open fiale!");
            }
            _isopen = false;
            return 0;
        }
        public int SerialPort_Close()
        {
            try { MySerialPort.Close(); _isopen = false; return 1; }
            catch
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Closed Failed!!!", "ERROR");
            }
            return 0;
        }

        public void WriteString(string cmd)
        {
            if (!MySerialPort.IsOpen)
            {
                MessageBox.Show("Serial Part is closed!");
                return;
            }
            string s = cmd;
            if (CRLS_Flag) { s = cmd + "\r\n"; }
            //cmd = "H:1-\r\n";
            MySerialPort.Write(s);
        }
        public void WriteByteArray(byte[] cmd)
        {
            if (!MySerialPort.IsOpen)
            {
                MessageBox.Show("Serial Part is closed!");
                return;
            }
            var len = cmd.Length;
            byte[] s = cmd;
            if (CRLS_Flag)
            {
                s[len + 1] = (byte)'\r';
                s[len + 2] = (byte)'\n';
                MySerialPort.Write(s, 0, len + 2);
            }
        }
    }
}
