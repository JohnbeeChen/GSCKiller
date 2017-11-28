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
        GSCSerialPort MyGSCPort = new GSCSerialPort();
        

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
            MyParmeter.PortName = Comb_Port.Text;
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            if(btn_open.Text == "Open")
            {
                MyParmeter.PortName = Comb_Port.Text;
                if (MyParmeter.PortName == "")
                {               
                    MessageBox.Show(this,"Port Name is NULL!","ERROR");
                    return;
                }
                MyParmeter.BaudRate = Convert.ToInt32(Comb_Bps.Text);

                MyGSCPort.GSCSerialPortInit(MyParmeter);              

                if(MyGSCPort.SerialPort_Open()== 1)
                {
                    btn_open.Text = "Close";
                    serial_open_disable_UI();
                    MyGSCPort.PortReceiveEvent += MyGSCPort_ComDataReceivedEvent;
                }
            }
            else if(btn_open.Text == "Close")
            {
                if(MyGSCPort.SerialPort_Close() == 1)
                {
                    btn_open.Text = "Open";
                    serial_close_enable_UI();
                    MyGSCPort.PortReceiveEvent -= MyGSCPort_ComDataReceivedEvent;
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
            Comb_Bps.Enabled = false;
            Comb_Port.Enabled = false;
            btn_Refresh.Enabled = false;
            MoreSetting.Enabled = false;


        }
        /// <summary>
        /// enable some UI when serial port have closed
        /// </summary>
        private void serial_close_enable_UI()
        {
            Comb_Bps.Enabled = true;
            Comb_Port.Enabled = true;
            btn_Refresh.Enabled = true;
            MoreSetting.Enabled = true;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string[] coms = SerialPort.GetPortNames();
            Set_ComboBoxIntem(Comb_Port, coms);
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
            MyParmeter.PortName = Comb_Port.Text;

        }
        private void Comb_Bps_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyParmeter.BaudRate = Convert.ToInt16(Comb_Bps.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MyGSCPort != null)
            {
                MyGSCPort.SerialPort_Close();                
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //string s = "Q";
            //MyGSCPort.WriteString(s);
            Forms.Kenesis tem = new Forms.Kenesis(MyParmeter);
            tem.MdiParent = this;
            tem.Show();
        }

        private void GSCControllerMenu_Click(object sender, EventArgs e)
        {
            Forms.GSC_Controller gsc_contorller = new Forms.GSC_Controller(MyGSCPort);
            gsc_contorller.MdiParent = this;
            gsc_contorller.Show();
        }
    }
}
