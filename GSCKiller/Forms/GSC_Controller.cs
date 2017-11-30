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
using GSCKiller.Forms;
using GSCKiller.GSC;

namespace GSCKiller.Forms
{
    public enum Controller { PlaneController, RotationController};
    public partial class GSC_Controller : Form
    {
        public event Action<string, Controller> SendCommandEvent;       
        public GSC_Controller()
        {
            InitializeComponent();
        }

        private void SendCommand(string cmd, Controller myController)
        {
            try
            {
                SendCommandEvent(cmd, myController);
            }
            catch { }
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            string cmd = GSC_Command.HomeCommand(Axis.Axis1,MoveDirection.Backward);
            SendCommand(cmd, Controller.PlaneController);
        }
        private void btn_HomeY_Click(object sender, EventArgs e)
        {
            string cmd = GSC_Command.HomeCommand(Axis.Axis2, MoveDirection.Backward);
            SendCommand(cmd, Controller.PlaneController);
        }
        private void btn_HomeR_Click(object sender, EventArgs e)
        {
            string cmd = GSC_Command.HomeCommand(Axis.Axis1, MoveDirection.Foreward);
            SendCommand(cmd, Controller.RotationController);
        }

        private void btn_JogX_Click(object sender, EventArgs e)
        {
            string cmd = GSC_Command.JogCommand(Axis.Axis1, MoveDirection.Foreward);
            SendCommand(cmd, Controller.PlaneController);
            cmd = GSC_Command.GoCommand();
            SendCommand(cmd, Controller.PlaneController);
        }

        private void btn_JogY_Click(object sender, EventArgs e)
        {
            string cmd = GSC_Command.JogCommand(Axis.Axis2, MoveDirection.Foreward);
            SendCommand(cmd, Controller.PlaneController);
            cmd = GSC_Command.GoCommand();
            SendCommand(cmd, Controller.PlaneController);
        }

        private void btn_JogR_Click(object sender, EventArgs e)
        {
            string cmd = GSC_Command.JogCommand(Axis.Axis1, MoveDirection.Foreward);
            SendCommand(cmd, Controller.RotationController);
            cmd = GSC_Command.GoCommand();
            SendCommand(cmd, Controller.RotationController);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = GSC_Command.StopCommand(Axis.BothAxis);
            SendCommand(cmd, Controller.RotationController);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cmd = GSC_Command.StopCommand(Axis.Axis1);
            SendCommand(cmd, Controller.PlaneController);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmd = GSC_Command.StopCommand(Axis.Axis2);
            SendCommand(cmd, Controller.PlaneController);
        }
    }
}
