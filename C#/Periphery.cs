namespace Virual
{
    class Periphery
    {
        protected string manufacturer = "Undefined";
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public virtual void Print()
        {
            Console.WriteLine("Manufacturer:", manufacturer);
        }
    }
}