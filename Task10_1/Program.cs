namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building triangle = new Building();

            Console.ReadKey();
        }
    }
    class Building
    {
        string _address;
        double _area;
        int yearBuilt;
        public double BuildingAge { get; set; }

        public virtual double CalculateTax()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public virtual double DisplayInfo()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    class MultiBuilding() : Building
    {
        MultiBuilding()
        : base()
        {

            int _floors;
            bool _hasElevator;
        }
    }
}

