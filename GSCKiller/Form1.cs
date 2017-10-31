using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Johnbee;

namespace GSCKiller
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //this.Text = "MainForm    TopId = 0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Comb_Bps.Items.Add("9600");
            Comb_Bps.Items.Add("115200");
            Comb_Bps.Text = "9600";
            string[] coms = JohnbeeSerialPort.SerialPort_Search();
            foreach(string com in coms)
            {
                Comb_Port.Items.Add(com);
                Comb_Port.Text = com;
            }
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            if(btn_open.Text == "Open")
            {
                JohnbeeSerialPort.SerialPort_Init(Comb_Port.Text,Comb_Bps.Text);
                if (JohnbeeSerialPort.SerialPort_Open() == 0)
                {
                    btn_open.Text = "Colse";
                    Comb_Bps.Enabled = false;
                    Comb_Port.Enabled = false;
                    btn_Refresh.Enabled = false;
                }
            }
            else if(btn_open.Text == "Colse")
            {
                if(JohnbeeSerialPort.SerialPort_Close() == 0)
                {
                    btn_open.Text = "Open";
                    Comb_Bps.Enabled = true;
                    Comb_Port.Enabled = true;
                    btn_Refresh.Enabled = true;
                }
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Comb_Port.Items.Clear();
            JohnbeeSerialPort.SerialPort_Search();
            string[] coms = JohnbeeSerialPort.SerialPort_Search();
            foreach (string com in coms)
            {
                Comb_Port.Items.Add(com);
                Comb_Port.Text = com;
            }
        }

        private void Comb_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JohnbeeSerialPort.SerialPort_Close() == 0)
            {
                btn_open.Text = "Open";
                JohnbeeSerialPort.Set_PortName(Comb_Port.Text);
            }
        }
        private void Comb_Bps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JohnbeeSerialPort.SerialPort_Close() == 0)
            {
                btn_open.Text = "Open";
                JohnbeeSerialPort.Set_PortBps(Comb_Bps.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(JohnbeeSerialPort.MySerialPort.IsOpen)
            {
                JohnbeeSerialPort.SerialPort_Close();
            }
        }
    }
}
