using System;
using System.Timers;

namespace TestProjects
{
    public class Timer
    {
        private double ProcessLength;
        private System.Timers.Timer NewTimer;

        public Timer(double processLength)
        {
            this.ProcessLength = processLength;
            NewTimer = new System.Timers.Timer(ProcessLength);
            NewTimer.Elapsed += OnTimedEvent;
            NewTimer.AutoReset = false;
        }

        public bool set(double newProcessLength)
        {
            this.ProcessLength = newProcessLength;
            return true;
        }

        public double get()
        {
            return ProcessLength;
        }

        public bool start()
        {
            NewTimer.Start();
            return true;
        }

        public bool stop()
        {
            NewTimer.Stop();
            return true;
        }

        public bool isActive()
        {
            return NewTimer.Enabled;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            System.Console.WriteLine("Timer raised at {0:HH:mm:ss.fff}",
                e.SignalTime);
        }
    }
}