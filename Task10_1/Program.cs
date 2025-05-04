using System;
using System.Net;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building triangle = new Building("Сливовая", 190.15, 1857);
            MultiBuilding triangle1 = new MultiBuilding("Каштановая", 2851.52, 2003, 9, true);
            Building triangle2 = triangle;
            MultiBuilding triangle3 = (MultiBuilding)triangle;
            triangle2.CalculateTax();
            triangle2.DisplayInfo();
            triangle3.CalculateTax();
            triangle3.DisplayInfo();
            Console.ReadKey();
        }
    }
    class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;
        public double BuildingAge { get; set; }
        //  Конструктор базового класса
        public Building(string ad, double ar, int ye)
        {
            _address = ad;
            _area = ar;
            _yearBuilt = ye;
            BuildingAge = 2015 - _yearBuilt;
        }
        public virtual void CalculateTax()  // рассчитывает налог (базовая формула: площадь × 1000)
        {
            double n = _area * 1000;
            Console.WriteLine($"налог: {n}");
        }
        public virtual void DisplayInfo()  //выводит информацию о здании
        {
            Console.WriteLine($"адрес здания {_address}, площадь в квадратных метрах {_area} , год постройки {_yearBuilt} ");
        }
    }
    sealed class MultiBuilding : Building
    {
        int _floors;
        bool _hasElevator;
        public double AreaPerFloor { get; }
        //  Конструктор класса-наследника
        public MultiBuilding(string ad, double ar, int ye, int fl, bool Elevator)
             : base(ad, ar, ye)
        {
            _floors = fl;
            _hasElevator = Elevator;
            AreaPerFloor = _area / _floors;
        }
        public override void CalculateTax()  // рассчитывает налог (1 + (_floors - 1) * 0.05)
        {
            double n;
            if (_hasElevator == true)
            {
                n = _area * 1000 * (1 + (_floors - 1) * 0.05) + 5000;
            }
            else
            {
                n = _area * 1000 * (1 + (_floors - 1) * 0.05);
            }
            Console.WriteLine($"налог: {n}");
        }
        public override void DisplayInfo()  //выводит информацию о многоэтажном здании
        {
            Console.WriteLine($"адрес здания : {_address}, площадь в квадратных метрах - {_area} , год постройки - {_yearBuilt}, количество этажей - {_floors}, средняя площадь на этаж - {AreaPerFloor}, наличие лифта - {_hasElevator}");
        }
    }
}


