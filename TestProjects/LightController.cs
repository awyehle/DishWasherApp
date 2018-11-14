using System;

namespace TestProjects
{
    public class LightController
    {
        private GreenLight NewGreenLight;
        private RedLight NewRedLight;
        private YellowLight NewYellowLight;
        private char CurrentLight;
        private int State;

        public LightController()
        {
            NewGreenLight = new GreenLight();
            NewRedLight = new RedLight();
            NewYellowLight = new YellowLight();
        }

        public bool on()
        {
            NewGreenLight.activate();
            CurrentLight = 'G';
            State = 1;
            return true;
        }

        public bool toggle()
        {
            if (isOn())
            {
                switch (CurrentLight)
                {
                    case 'G':
                        NewGreenLight.deactivate();
                        NewYellowLight.activate();
                        CurrentLight = 'Y';
                        break;
                    case 'Y':
                        NewYellowLight.deactivate();
                        NewRedLight.activate();
                        CurrentLight = 'Y';
                        break;
                    case 'R':
                        off();
                        break;
                }

                return true;
            }

            return false;
        }

        public bool reset()
        {
            NewGreenLight.deactivate();
            NewYellowLight.deactivate();
            NewRedLight.deactivate();
            NewGreenLight.activate();
            State = 1;
            return true;
        }

        public bool off()
        {
            NewGreenLight.deactivate();
            NewYellowLight.deactivate();
            NewRedLight.deactivate();
            State = 0;
            return true;
        }

        public bool isOn()
        {
            return (State == 1) ? true : false;
        }

    }
}