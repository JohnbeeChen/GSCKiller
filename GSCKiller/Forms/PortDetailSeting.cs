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

namespace GSCKiller.Forms
{
    public partial class PortDetailSeting : Form
    {
        SerialParameter MyParameter;
        public PortDetailSeting()
        {
            InitializeComponent();
        }
        public PortDetailSeting(SerialParameter myParameter)
        {
            this.MyParameter = myParameter;
            InitializeComponent();
            comb_databit.Text = MyParameter.DataBits.ToString();
            comb_stopbit.SelectedIndex = (int)MyParameter.StopBits;
            comb_parity.SelectedIndex = (int)MyParameter.Parity;

            cBox_Crlf.Checked = MyParameter.CrlsEnable;
            cBox_RTS.Checked = MyParameter.RtsEnable;
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            MyParameter.DataBits = Convert.ToInt16(comb_databit.Text);
            MyParameter.StopBits = (StopBits)comb_stopbit.SelectedIndex;
            MyParameter.Parity = (Parity)comb_parity.SelectedIndex;

            MyParameter.CrlsEnable = cBox_Crlf.Checked;
            MyParameter.RtsEnable = cBox_RTS.Checked;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
