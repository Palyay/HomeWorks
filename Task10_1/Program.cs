using System;
using System.Net;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building dom = new Building("Сливовая", 190.15, 1957);
            MultiBuilding dom1 = new MultiBuilding("Каштановая", 2851.52, 2003, 9, true);//Создание объектов обоих типов

            Building domUpcast = dom1;
            Console.WriteLine("\nПосле upcasting:");
            Console.WriteLine($"уникальное свойство производного класса - средняя площадь на этаж {dom1.AreaPerFloor:F2}");
            domUpcast.DisplayInfo();// Вызывается переопределенный метод
            domUpcast.CalculateTax();// Вызывается переопределенный метод
               // domUpcast.AreaPerFloor - свойство не доступно после Upcasting
               //MultiBuilding domDowncast = (MultiBuilding)dom; //-недопустимое преобразование

            if (dom1 is MultiBuilding)
            {
                MultiBuilding domDowncast = dom as MultiBuilding;
                if (domDowncast != null)
                {
                    Console.WriteLine("\nПосле downcasting:");
                    domDowncast.DisplayInfo();
                    domDowncast.CalculateTax();
                    Console.WriteLine(domDowncast.AreaPerFloor);
                }
            }
            Console.ReadKey();
        }
    }
    class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;
        public double BuildingAge { get; }
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
            Console.WriteLine($"Базовый налог: {n:F2}");
            Console.WriteLine($"-----------------------");
        }
        public virtual void DisplayInfo()  //выводит информацию о здании
        {
            Console.WriteLine($"-----------------------");
            Console.WriteLine($"Здание {_yearBuilt} года постройки");
            Console.WriteLine($"Адрес здания {_address}");
            Console.WriteLine($"Площадь в квадратных метрах {_area:F2} кв.м.");
            Console.WriteLine($"Возраст здания {BuildingAge}");
        }
    }
    sealed class MultiBuilding : Building
    {
        int _floors = 0;
        bool _hasElevator = true;
        public double AreaPerFloor
        {
            get
            {
                return _area / _floors;
            }
        }
        //  Конструктор класса-наследника
        public MultiBuilding(string ad, double ar, int ye, int fl, bool Elevator)
             : base(ad, ar, ye)
        {
            _floors = fl;
            _hasElevator = Elevator;
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
            Console.WriteLine($"Повышенный налог: {n:F2}");
            Console.WriteLine($"-----------------------");
        }
        public override void DisplayInfo()  //выводит информацию о многоэтажном здании
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество этажей - {_floors}");
            Console.WriteLine($"Средняя площадь на этаж - {AreaPerFloor:F2} кв.м.");
            Console.WriteLine($"Наличие лифта - {(_hasElevator ? "есть" : "нет")}");
        }
    }
}


