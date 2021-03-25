using System;
using System.Threading;

namespace HomeWork44
{
    class Clock
    {
        Time time = new Time();
        Time alerm = new Time();

        public void Run(Object state)
        {
            bool flagMinute = false;
            bool flagSecond = false;
            time.Second += 1;

            if (time.Second >= 60)
            {
                flagSecond = true;
            }
            time.Second = time.Second % 60;
            if (flagSecond == true)
            {
                time.Minute += 1;
                if (time.Minute>= 60)
                {
                    flagMinute = true;
                }
                time.Minute = time.Minute % 60;
            }
            if (flagMinute == true)
            {
                time.Hour += 1;
                time.Hour = time.Hour % 24;
            }
            if (time.Hour==alerm.Hour&& time.Minute==alerm.Minute && time.Second==alerm.Second )
            {
                DiDiDi();
            }
            //Console.WriteLine($"{time.Hour}+{time.Minute}+{time.Second}");
        }
        
        public void SetClock(int a,int b,int c)
        {
            time.SetTime(a, b, c);
        }
        public void SetAlerm(int a, int b, int c)
        {
            alerm.SetTime(a, b, c);
        }
        public void DiDiDi()
        {
            Console.WriteLine("嘀嘀嘀");
        }

    }

    
    class Time
    {
        private int hour=0;
        private int minute=0;
        private int second=0;
        public int Hour { get=>hour; set=>hour=value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }
        public void SetTime(int hour,int minute,int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.SetAlerm(0, 0, 10);
            //Thread thread = new Thread(new ThreadStart(clock.Run));
            //thread.Start();
            //while (true)
            //{
            //    Thread.Sleep(1000);
            //}
            System.Threading.Timer threadTimer = new System.Threading.Timer(new System.Threading.TimerCallback(clock.Run), null, 0, 1000);
        while (true)
        {
            Thread.Sleep(1000);
        }
        }
    }
}
