using System;
using System.Net;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building triangle = new Building("Сливовая",2,3);
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
            _address = ad;
            _area = ar;
            _yearBuilt = ye;
            _floors = fl;
            _hasElevator = Elevator;
            AreaPerFloor = _area / _floors;
        }
        public override void CalculateTax()  // рассчитывает налог (1 + (_floors - 1) * 0.05)
        {
            double n = _area * 1000 * (1 + (_floors - 1) * 0.05);
            Console.WriteLine($"налог: {n}");
        }
        public override void DisplayInfo()  //выводит информацию о многоэтажном здании
        {
            Console.WriteLine($"адрес здания : {_address}, площадь в квадратных метрах - {_area} , год постройки - {_yearBuilt}, количество этажей - {_floors}, наличие лифта - {_hasElevator}");
        }
    }
}


