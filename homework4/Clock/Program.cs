using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        public delegate void ClockHandler();
        public class Clock
        {
            public event ClockHandler Tick;
            public event ClockHandler Alarm;
            public DateTime ClockTime{ get; set; }
            public void ClockEvent(DateTime alarmTime)
            {
                DateTime Temp2 = DateTime.Parse(alarmTime.ToString("yyyy-MM-dd HH:mm:ss"));
                while (true)
                {
                    DateTime Temp1 = DateTime.Parse(this.ClockTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    if (Temp1 == Temp2) Alarm();
                    else Tick();
                }
            }
        }
        public class Form
        {
            public Clock MyClock = new Clock();
            public void SetMyClock(DateTime MyClockTime)
            {
                MyClock.ClockTime = MyClockTime;
            }
            public Form()
            {
                MyClock.Tick += Tick;
                MyClock.Alarm += Alarm;
            }
            void Tick()
            {
                Console.WriteLine("嘀嗒……");
                MyClock.ClockTime = MyClock.ClockTime.AddSeconds(1);
                System.Threading.Thread.Sleep(1000);
            }
            void Alarm()
            {
                Console.WriteLine("叮零零零零……");
                MyClock.ClockTime = MyClock.ClockTime.AddSeconds(1);
                System.Threading.Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Form form1 = new Form();
            Console.WriteLine("请设置时钟初始时间(若输入格式错误则默认为当前系统时间)：");
            string Time=Console.ReadLine();
            DateTime InputTime;
            if (DateTime.TryParse(Time, out InputTime))
            {
                InputTime = DateTime.Parse(Time);
                form1.SetMyClock(InputTime);
                Console.WriteLine($"初始时钟时间为：{form1.MyClock.ClockTime}");
            }
            else
            {
                form1.SetMyClock(DateTime.Now);
                Console.WriteLine($"初始时钟时间为：{form1.MyClock.ClockTime}");
            }
            while (true)
            {
                Console.WriteLine("请设置闹钟时间：");
                string AlarmTime = Console.ReadLine();
                DateTime InPutAlarmTime;
                if (DateTime.TryParse(AlarmTime, out InPutAlarmTime))
                {
                    InPutAlarmTime = DateTime.Parse(AlarmTime);
                    form1.MyClock.ClockEvent(InPutAlarmTime);
                }
                else
                {
                    Console.WriteLine("输入有误，请按任意键重新输入：");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}
