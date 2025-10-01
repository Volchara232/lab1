using Virtual;
using System.Drawing;
using System.Reflection.Metadata;
namespace Monitor
{
    class Monitor : Periphery
    {
        private Size Resolution
        { get; set; } = new Size(1920, 1080);
        private int RefreshRate
        { get; set; } = 60;
        private double ScreenSize
        { get; set; } = 23.8;
        public Monitor(
            Size? resolution = null,
            int? refreshRate = null,
            double? screenSize = null,
            string manufacturer = "null")
            : base(manufacturer)
        {
            var res = resolution ?? new Size(1920, 1080);
            if (res.Width < 800 || res.Height < 600 || res.Width > 7680 || res.Height > 4320)
                throw new ArgumentException("Resolution must be between 800x600 and 7680x4320");
            Resolution = res;
            var refresh = refreshRate ?? 60;
            if (refresh < 55 || refresh > 500)
                throw new ArgumentException("Refresh rate must be between 55 and 500 Hz.");
            RefreshRate = refresh;
            var size = screenSize ?? 23.8;
            if (size < 10 || size > 150)
                throw new ArgumentException("The screen diagonal must be between 10 and 150 inches.");
            ScreenSize = size;
        
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Resolution: {Resolution.Width}x{Resolution.Height}");
            Console.WriteLine($"Refresh Rate: {RefreshRate} Hz");
            Console.WriteLine($"Screen Size: {ScreenSize} inches");
        }

    }
}