using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjects
{
    public class Console
    {
        private Synchronizer NewSynchronizer;
        public Console()
        {
            NewSynchronizer = new Synchronizer();
            System.Console.WriteLine("Application started at {0:HH:mm:ss.fff}", DateTime.Now);
        }
    }
}
