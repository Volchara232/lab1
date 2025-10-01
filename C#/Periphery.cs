namespace Virtual
{
    class Periphery
    {
        private protected string Manufacturer { get; set; }  = "Undefined";
        public virtual void Print()
        {
            Console.WriteLine("Manufacturer:", Manufacturer);
        }
    }
}