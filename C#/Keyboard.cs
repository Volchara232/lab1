using Virtual;
namespace Keyboard
{
    public enum Key
    {
        None, Membrane, Mechanical, Optical
    }
    public enum Connection
    {
        None, Wired, Wireless
    }
    class Keyboard : Periphery
    {
        private string Color { get; set; } = "Unknown";
        private Key KeysType { get; set; } = Key.None;
        private Connection ConnectionType { get; set; } = Connection.None;
        private bool HasBacklight { get; set; } = false;
        public Keyboard(
            string color = "null",
            Key? keys_type = null,
            Connection? connection_type = null,
            bool? has_backlight = null,
            string manufacturer = "null")
            : base(manufacturer)
        {
            if (string.IsNullOrWhiteSpace(color) || color.Trim().Length < 3)
                throw new ArgumentException("The color must contain at least 3 characters.");
            Color = color.Trim();         
            KeysType = keys_type ?? Key.None;
            ConnectionType = connection_type ?? Connection.None;
            HasBacklight = has_backlight ?? false;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Keys type: {KeysType}");
            Console.WriteLine($"Connection type: {ConnectionType}");
            Console.WriteLine($"Has backlight: {HasBacklight}");
        }

    }


}
