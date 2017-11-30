using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSCKiller.GSC
{
    public enum Axis { Axis1 = 1, Axis2, BothAxis };
    public enum MoveDirection { Foreward,Backward };
    public enum SpeedRange { LowSpeed = 1, HighSpeed };

    public static class GSC_Command
    {
        /// <summary>
        /// Get the command of returning to the mechanical origin for one axis
        /// </summary>
        /// <param name="myAxis">select the axis to set</param>
        /// <param name="myDirection">the direction of the mechanical oringin </param>
        /// <returns> command string </returns>
        public static string HomeCommand(Axis myAxis, MoveDirection myDirection)
        {
            string cmd = NoParameterCmd("H:", myAxis, myDirection);
            return cmd;
        }
        /// <summary>
        /// Get the command of returning to the mechanical origin for two axis
        /// </summary>
        /// <param name="axis1Direction">the direction of the mechanical oringin for axis 1</param>
        /// <param name="axis2Direction">the direction of the mechanical oringin for axis 2</param>
        /// <returns> command string </returns>
        public static string HomeCommand(MoveDirection axis1Direction, MoveDirection axis2Direction)
        {
            string cmd = NoParameterCmd("H:W", axis1Direction, axis2Direction);
            return cmd;
        }

        /// <summary>
        /// Get the command of setting number of pulses for relative travel
        /// </summary>
        /// <param name="myAxis"> select the axis to set </param>
        /// <param name="travelNum"> the number of pulses, -16777214~16777214 </param>
        /// <returns> command string </returns>
        public static string MoveCommand(Axis myAxis, int travelNum)
        {
            string axis_name = ((int)myAxis).ToString();
            string dir = "-";
            if (travelNum >0)
            {
                dir = "+";
            }
            int num = Math.Abs(travelNum);
            string cmd = "M:" + axis_name + dir+ "P" + num.ToString();
            return cmd;
        }
        /// <summary>
        /// Get the command of setting number of pulses for relative travel
        /// </summary>
        /// <param name="travelNum1"> the number of pulses for axis1, -16777214~16777214 </param>
        /// <param name="travelNum2"> the number of pulses for axis1, -16777214~16777214 </param>
        /// <returns> command string </returns>
        public static string MoveCommand(int travelNum1, int travelNum2)
        {
            string dir1 = "-";
            string dir2 = "-";
            if (travelNum1>0)
            {
                dir1 = "+";
            }
            if (travelNum2 > 0)
            {
                dir2 = "+";
            }
            int num1 = Math.Abs(travelNum1);
            int num2 = Math.Abs(travelNum2);
            string cmd = "M:W" + dir1 + "P" + num1.ToString() + dir2 + "P" + num2.ToString();
            return cmd;
        }

        public static string JogCommand(Axis myAxis, MoveDirection myDirection)
        {
            string cmd = NoParameterCmd("J:",myAxis,myDirection);
            return cmd;
        }
        public static string JogCommand(MoveDirection axis1Direction, MoveDirection axis2Direction)
        {
            string cmd = NoParameterCmd("J:W", axis1Direction, axis2Direction);
            return cmd;
        }

        public static string StopCommand(Axis myAxis)
        {
            string cmd = SpecialCmd("L:",myAxis);
            return cmd;
        }
        /// <summary>
        /// The Go command is used after Move and Jog commands to start moving the stage
        /// </summary>
        /// <returns></returns>
        public static string GoCommand()
        {
            return "G";
        }

        public static string SetLogicalOrigin(Axis myAxis)
        {
            string cmd = SpecialCmd("R:", myAxis);
            return cmd;
        }

        /// <summary>
        /// Turn the motor on
        /// </summary>
        /// <param name="myAxis"></param>
        /// <returns></returns>
        public static string EnableMotor(Axis myAxis)
        {
            string cmd = SpecialCmd("C:", myAxis);
            return cmd + "1";
        }
        /// <summary>
        /// Turn the motor off, making it possible to move stages manually
        /// </summary>
        /// <param name="myAxis"></param>
        /// <returns></returns>
        public static string DisableMotor(Axis myAxis)
        {
            string cmd = SpecialCmd("C:", myAxis);
            return cmd + "0";
        }

        /// <summary>
        /// this command sets the minmim speed, maximum speed and acceleration/deceleration time.
        /// </summary>
        /// <param name="spdRange"> speed range, LowSpeed or HighSpeed</param>
        /// <param name="minSpd1">minimum speed,1-200PPS(Low range), 50-20000PPS(High range)</param>
        /// <param name="maxSpd1">maximum speed,1-200PPS(Low range), 50-20000PPS(High range)</param>
        /// <param name="accTime1">acceleration/deceleration, 0-1000ms</param>
        /// <returns>cmd string</returns>
        /// <notice>maxSpd should >= minSpd.if minSpd==maxSpd,or accTime=0,stage move at a constant speed</notice>
        public static string SetSpeed(SpeedRange spdRange,int minSpd1,int maxSpd1,int accTime1,int minSpd2,int maxSpd2,int accTime2)
        {
            Func<int, int, int, string> t = (int x, int y, int z) =>
            {
                return "S" + x.ToString() + "F" + y.ToString() + "R" + z.ToString();
            };
            string cmd = ((int)spdRange).ToString() + t(minSpd1,maxSpd1,accTime1)+t(minSpd2,maxSpd2,accTime2);
            return "D:"+ cmd;
        }

        /// <summary>
        /// inquire the coordinates for each axis and the current state of each stage.
        /// </summary>
        /// <returns> command string </returns>
        public static string InquireAllInfo()
        {
            return "Q:";
        }

        /// <summary>
        /// inquire the stage operating status
        /// </summary>
        /// <returns></returns>
        public static string InquireStatusInfo()
        {
            return "!:";
        }

        /// <summary>
        /// inquire teh internal ROM version from the controller
        /// </summary>
        /// <returns></returns>
        public static string InquireInternalInfo()
        {
            return "?:V";
        }


        private static string NoParameterCmd(string cmdChar, Axis myAxis, MoveDirection myDirection)
        {
            string axis_name = ((int)myAxis).ToString();
            string dir = "-";
            if (myDirection == MoveDirection.Foreward)
            {
                dir = "+";
            }
            string cmd = cmdChar + axis_name + dir;
            return cmd;
        }
        private static string NoParameterCmd(string cmdChar, MoveDirection axis1Direction, MoveDirection axis2Direction)
        {
            string dir1 = "-";
            string dir2 = "-";
            if (axis1Direction == MoveDirection.Foreward)
            {
                dir1 = "+";
            }
            if (axis2Direction == MoveDirection.Foreward)
            {
                dir2 = "+";
            }
            string cmd = cmdChar + dir1 + dir2;
            return cmd;
        }
        private static string SpecialCmd(string cmdChar,Axis myAxis)
        {
            string str;
            if (myAxis == Axis.Axis1 || myAxis == Axis.Axis2)
            {
                str = ((int)myAxis).ToString();
            }
            else
            {
                str = "W";
            }
            string cmd = cmdChar + str;
            return cmd;
        }

    }
}
