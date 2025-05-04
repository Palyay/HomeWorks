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
        int _yearBuilt;
        public double BuildingAge { get; set; }

        public virtual void CalculateTax()
        {
            double p = _area * 1000;
            Console.WriteLine($"налог: {p}");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"адрес здания {_address}, площадь в квадратных метрах {_area} , год постройки {_yearBuilt} "); 
        }
    }
    class MultiBuilding() : Building
    {
        MultiBuilding()
        : base()
        {
            int _floors;
            bool _hasElevator;
            public double AreaPerFloor { get;}

        }
    }
}

