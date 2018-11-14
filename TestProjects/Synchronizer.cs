using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjects
{
    public class Synchronizer
    {
        private LightController NewLightController;
        private Timer NewTimer;

        public Synchronizer()
        {
            NewLightController = new LightController();
            NewTimer = new Timer(5);
        }

        public bool createThreads()
        {

        }


        public bool sync()
        {
            NewTimer.start();
            while (NewTimer.isActive())
            {
                System.Threading.Thread.Sleep(1000);
            }

            if (!NewTimer.isActive())
            {

                return true;
            }

            return false;
        }

        private bool toggle()
        {

        }

        private bool stop()
        {

        }
        
    }
}
