using Virual;
using System.Drawing;
using System.Reflection.Metadata;
namespace Monitor
{
    class Monitor : Periphery
    {
        private Size resolution = new Size(1920, 1080);
        private int refresh_rate = 60;
        public Size Resolution
        {
            get { return resolution; }
            set { Resolution = value; }
        }
        public int RefreshRate
        {
            get { return refresh_rate; }
            set { refresh_rate = value; }
        }
        private double screen_size = 23.8;
        public double ScreenSize
        {
            get { return screen_size; }
            set { ScreenSize = value; }
        }
        public Monitor()
        {}

    }
}