using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        public class MyEventArgs: EventArgs
        {
            public string s;
        }
        public delegate void ReceivedHandle(object sender, MyEventArgs e);
        public interface IWriter
        {
            void Writer(string s);
            event ReceivedHandle ReceivedEvent;
        }
        public class MyWriter : IWriter
        {
            public event ReceivedHandle ReceivedEvent;

            public void Writer(string s)
            {
                Console.WriteLine(s);
                MyEventArgs myArgs = new MyEventArgs();
                myArgs.s = s;
                ReceivedEvent(this, myArgs);
            }
        }
        public enum SpeedRange { LowSpeed = 1, HighSpeed };
        static void Main(string[] args)
        {
            string s = ((int)SpeedRange.HighSpeed).ToString();

            IWriter writer1 = new MyWriter();
            writer1.ReceivedEvent += Writer1_ReceivedEvent;
            writer1.Writer("nmb,I want to write something!");
            while (true);
        }

        private static void Writer1_ReceivedEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine("Recievd:");
            Console.WriteLine(e.s);
        }
    }
}
