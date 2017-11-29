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
using GSCkiller.Forms;

namespace GSCKiller
{
    public partial class Form1 : Form
    {
        SerialParameter MyParmeter = new SerialParameter();
        GSCSerialPort MyGSCPort1 = new GSCSerialPort();
        GSCSerialPort MyGSCPort2 = new GSCSerialPort();

        public Form1()
        {
            InitializeComponent();
            MyParmeter.RtsEnable = true;
            MyParmeter.CrlsEnable = true;
            MyParmeter.StopBits = System.IO.Ports.StopBits.One;            
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

                MyGSCPort1.GSCSerialPortInit(MyParmeter);              

                if(MyGSCPort1.SerialPort_Open()== 1)
                {
                    btn.Text = "Close";
                    serial_open_disable_UI();
                    MyGSCPort1.PortReceiveEvent += MyGSCPort_ComDataReceivedEvent;
                }
            }
            else if(btn.Text == "Close")
            {
                if(MyGSCPort1.SerialPort_Close() == 1)
                {
                    btn.Text = "Open";
                    serial_close_enable_UI();
                    MyGSCPort1.PortReceiveEvent -= MyGSCPort_ComDataReceivedEvent;
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

                MyGSCPort2.GSCSerialPortInit(MyParmeter);

                if (MyGSCPort2.SerialPort_Open() == 1)
                {
                    btn.Text = "Close";
                    serial_open_disable_UI();
                    MyGSCPort2.PortReceiveEvent += MyGSCPort_ComDataReceivedEvent;
                }
            }
            else if (btn.Text == "Close")
            {
                if (MyGSCPort2.SerialPort_Close() == 1)
                {
                    btn.Text = "Open";
                    serial_close_enable_UI();
                    MyGSCPort2.PortReceiveEvent -= MyGSCPort_ComDataReceivedEvent;
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
            if(MyGSCPort1.IsOpen)
            {
                Comb_Port1.Enabled = false;
            }
            if (MyGSCPort2.IsOpen)
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
            if (!MyGSCPort1.IsOpen)
            {
                Comb_Port1.Enabled = true;
            }
            if (!MyGSCPort2.IsOpen)
            {
                Comb_Port2.Enabled = true;
            }
            if (MyGSCPort1.IsOpen == false && MyGSCPort2.IsOpen == false)
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
        private void Comb_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyParmeter.PortName = Comb_Port1.Text;

        }
        private void Comb_Bps_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyParmeter.BaudRate = Convert.ToInt16(Comb_Bps.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MyGSCPort1 != null)
            {
                MyGSCPort1.SerialPort_Close();                
            }
            if (MyGSCPort2 != null)
            {
                MyGSCPort2.SerialPort_Close();
            }
        }

        private void serial_setting_Click(object sender, EventArgs e)
        {
            PortDetailSeting detail_form = new PortDetailSeting(MyParmeter);
            detail_form.ShowDialog();
        }

        /// <summary>
        /// just for debugging
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    //string s = "Q";
        //    //MyGSCPort1.WriteString(s);
        //    Forms.Kenesis tem = new Forms.Kenesis(MyParmeter);
        //    tem.MdiParent = this;
        //    tem.Show();
        //}

        private void GSCControllerMenu_Click(object sender, EventArgs e)
        {
            Forms.GSC_Controller gsc_contorller = new Forms.GSC_Controller(MyGSCPort1);
            gsc_contorller.MdiParent = this;
            gsc_contorller.Show();
        }
    }
}
