namespace Virtual
{
    class Periphery
    {
        public string Manufacturer { get; set; }  = "Undefined";
        public virtual void Print()
        {
            Console.WriteLine("Manufacturer:", Manufacturer);
        }
    }
}