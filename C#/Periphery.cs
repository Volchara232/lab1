namespace Virtual
{
    class Periphery
    {
        public string Manufacturer { get; private set; }  = "Undefined";
        public Periphery(string manufacturer = "Undefined")
        {
            
            if (string.IsNullOrWhiteSpace(manufacturer) || manufacturer.Trim().Length < 2)
                throw new ArgumentException("Manufacturer must be more than 2");
            Manufacturer = manufacturer.Trim();
        }
        public virtual void Print()
        {
            Console.WriteLine($"Manufacturer: {Manufacturer}");
        }
    }
}