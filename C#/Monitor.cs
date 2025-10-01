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
        {
            if (resolution.HasValue)
                Resolution = resolution.Value;

            if (refreshRate.HasValue)
                RefreshRate = refreshRate.Value;

            if (screenSize.HasValue)
                ScreenSize = screenSize.Value;

            Manufacturer = manufacturer;
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