namespace TestProjects
{
    public abstract class LightBase
    {
        private int activated;

        public void activate()
        {
            this.activated = 1;
        }

        public void deactivate()
        {
            this.activated = 0;
        }
    }
}