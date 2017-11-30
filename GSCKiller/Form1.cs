using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Johnbee;
using GSCKiller.Forms;

namespace GSCKiller
{
    public partial class MainForm : Form
    {
        SerialParameter MyParmeter = new SerialParameter();
        GSCSerialPort MyGSCPortPlane = new GSCSerialPort();
        GSCSerialPort MyGSCPortRotation = new GSCSerialPort();

        public MainForm()
        {
            InitializeComponent();
            MyParmeter.RtsEnable = true;
            MyParmeter.CrlsEnable = true;
            MyParmeter.StopBits = StopBits.One;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Comb_Bps.Items.Add("9600");
            Comb_Bps.Items.Add("115200");
            Comb_Bps.Text = "9600";

            btn_Refresh_Click(sender, e);
            MyParmeter.PortName = Comb_Port1.Text;
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            if(btn.Text == "Open")
            {
                MyParmeter.PortName = Comb_Port1.Text;
                if (MyParmeter.PortName == "")
                {               
                    MessageBox.Show(this,"Port Name is NULL!","ERROR");
                    return;
                }
                MyParmeter.BaudRate = Convert.ToInt32(Comb_Bps.Text);

                MyGSCPortPlane.GSCSerialPortInit(MyParmeter);              

                if(MyGSCPortPlane.SerialPort_Open()== 1)
                {
                    btn.Text = "Close";
                    serial_open_disable_UI();
                    MyGSCPortPlane.PortReceiveEvent += MyGSCPort_ComDataReceivedEvent;
                }
            }
            else if(btn.Text == "Close")
            {
                if(MyGSCPortPlane.SerialPort_Close() == 1)
                {
                    btn.Text = "Open";
                    serial_close_enable_UI();
                    MyGSCPortPlane.PortReceiveEvent -= MyGSCPort_ComDataReceivedEvent;
                }
            }
        }
        private void btn_open2_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            if (btn.Text == "Open")
            {
                MyParmeter.PortName = Comb_Port2.Text;
                if (MyParmeter.PortName == "")
                {
                    MessageBox.Show(this, "Port Name is NULL!", "ERROR");
                    return;
                }
                MyParmeter.BaudRate = Convert.ToInt32(Comb_Bps.Text);

                MyGSCPortRotation.GSCSerialPortInit(MyParmeter);

                if (MyGSCPortRotation.SerialPort_Open() == 1)
                {
                    btn.Text = "Close";
                    serial_open_disable_UI();
                    MyGSCPortRotation.PortReceiveEvent += MyGSCPort_ComDataReceivedEvent;
                }
            }
            else if (btn.Text == "Close")
            {
                if (MyGSCPortRotation.SerialPort_Close() == 1)
                {
                    btn.Text = "Open";
                    serial_close_enable_UI();
                    MyGSCPortRotation.PortReceiveEvent -= MyGSCPort_ComDataReceivedEvent;
                }
            }
        }
        private void MyGSCPort_ComDataReceivedEvent(string s)
        {
            string received_str = s;
        }

        /// <summary>
        /// disable some UI when serial port have opened
        /// </summary>
        private void serial_open_disable_UI()
        {
            if(MyGSCPortPlane.IsOpen)
            {
                Comb_Port1.Enabled = false;
            }
            if (MyGSCPortRotation.IsOpen)
            {
                Comb_Port2.Enabled = false;
            }
            Comb_Bps.Enabled = false;

            btn_Refresh.Enabled = false;
            MoreSetting.Enabled = false;
        }
        /// <summary>
        /// enable some UI when serial port have closed
        /// </summary>
        private void serial_close_enable_UI()
        {
            if (!MyGSCPortPlane.IsOpen)
            {
                Comb_Port1.Enabled = true;
            }
            if (!MyGSCPortRotation.IsOpen)
            {
                Comb_Port2.Enabled = true;
            }
            if (MyGSCPortPlane.IsOpen == false && MyGSCPortRotation.IsOpen == false)
            {
                Comb_Bps.Enabled = true;
                btn_Refresh.Enabled = true;
                MoreSetting.Enabled = true;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string[] coms = SerialPort.GetPortNames();
            Set_ComboBoxIntem(Comb_Port1, coms);
            Set_ComboBoxIntem(Comb_Port2, coms);
        }
        private void Set_ComboBoxIntem(ToolStripComboBox myBox,string[] myIntems)
        {
            myBox.Items.Clear();
            foreach (string item in myIntems)
            {
                myBox.Items.Add(item);
                myBox.Text = item;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MyGSCPortPlane != null)
            {
                MyGSCPortPlane.SerialPort_Close();                
            }
            if (MyGSCPortRotation != null)
            {
                MyGSCPortRotation.SerialPort_Close();
            }
        }
        private void serial_setting_Click(object sender, EventArgs e)
        {
            PortDetailSeting detail_form = new PortDetailSeting(MyParmeter);
            detail_form.ShowDialog();
        }
        private void GSCControllerMenu_Click(object sender, EventArgs e)
        {
            var MyContorller = new GSC_Controller();
            MyContorller.MdiParent = this;
            MyContorller.SendCommandEvent += GSC_contorller_SendCommand;
            MyContorller.Show();
        }
        private void GSC_contorller_SendCommand(string myCmd, Controller myController)
        {
            if (myController == Controller.PlaneController)
            {
                MyGSCPortPlane.WriteString(myCmd);
            }
            else if (myController == Controller.RotationController)
            {
                MyGSCPortRotation.WriteString(myCmd);
            }
        }
    }
}
