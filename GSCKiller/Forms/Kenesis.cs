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
using Thorlabs.MotionControl.Controls;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.TCube.InertialMotor;
using Thorlabs.MotionControl.TCube.InertialMotorCLI;

namespace GSCKiller.Forms
{
    public partial class Kenesis : Form
    {
        //GenericDeviceHolder.GenericDevice _gennericDevice;
        TCubeInertialMotorControl MyMotorControl = new TCubeInertialMotorControl();
        public Kenesis(SerialParameter myParameter)
        {
            InitializeComponent();
            MyMotorControl.LargeView = true;
            MyMotorControl.SerialNumber = myParameter.PortName;
            MyMotorControl.ToggleSize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MyMotorControl.CreateDevice())
            {
                button1.Text = "nmb";
                TCubeInertialMotor device = MyMotorControl.Device;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MyMotorControl.IsConnected)
            {
                button2.Text = "connected";
            }
        }
    }
}
