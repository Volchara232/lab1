using Virtual;
namespace Keyboard
{
    enum Key
    {
        None, Membrane, Mechanical, Optical
    }
    enum Connection
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
            bool? has_black_light = null,
            string manufacturer = "null")
        {
            Color = color;
            if (keys_type.HasValue) KeysType = keys_type.Value;
            if (connection_type.HasValue) ConnectionType = connection_type.Value;
            if (has_black_light.HasValue) HasBacklight = has_black_light.Value;
            Manufacturer = manufacturer;
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
