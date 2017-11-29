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

namespace GSCKiller
{
    public partial class PortForm : Form
    {
        SerialParameter MyParameter = new SerialParameter();
        public PortForm(SerialParameter myParameter)
        {
            InitializeComponent();
            MyParameter = myParameter;
        }

        private void PortForm_Load(object sender, EventArgs e)
        {
            btn_refresh_Click(sender, e);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string[] coms = SerialPort.GetPortNames();
            Set_ComboBoxIntem(Comb_Port, coms);
        }
        private void Set_ComboBoxIntem(ComboBox myBox, string[] myIntems)
        {
            myBox.Items.Clear();
            foreach (string item in myIntems)
            {
                myBox.Items.Add(item);
                myBox.Text = item;
            }
        }
        private void btn_open_Click(object sender, EventArgs e)
        {

        }
    }
}
