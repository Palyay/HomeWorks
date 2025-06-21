using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace Task15_1
{
    class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Processor { get; set; }
        public int Frequency { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }
        public int Videomemory { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> list = new List<Computer>()
            {
                new Computer() { Id = 1, Brand = "Acer Veriton", Processor = "Intel", Frequency = 3600, Ram = 4, Hdd = 512, Videomemory = 2, Cost = 52, Quantity = 19 },
                new Computer() { Id = 2, Brand = "Dell Optiplex", Processor = "Intel", Frequency = 2100, Ram = 8, Hdd = 1024, Videomemory = 2, Cost = 84, Quantity = 24 },
                new Computer() { Id = 3, Brand = "HP Pavilion", Processor = "Intel", Frequency = 3200, Ram = 16, Hdd = 1024, Videomemory = 8, Cost = 138, Quantity = 10 },
                new Computer() { Id = 4, Brand = "Alienware Aurora", Processor = "Intel", Frequency = 3600, Ram = 32, Hdd = 2048, Videomemory = 12, Cost = 214, Quantity = 2 },
                new Computer() { Id = 5, Brand = "Acer Predator", Processor = "Intel", Frequency = 3600, Ram = 32, Hdd = 3072, Videomemory = 8, Cost = 115, Quantity = 7 },
                new Computer() { Id = 6, Brand = "HP Pavilion", Processor = "AMD", Frequency = 3400, Ram = 16, Hdd = 1024, Videomemory = 8, Cost = 79, Quantity = 14 },
                new Computer() { Id = 7, Brand = "HP OMEN", Processor = "Intel", Frequency = 6200, Ram = 16, Hdd = 1024, Videomemory = 10, Cost = 155, Quantity = 5 },
                new Computer() { Id = 8, Brand = "Lenovo IdeaCentre", Processor = "AMD", Frequency = 3500, Ram = 4, Hdd = 1024, Videomemory = 8, Cost = 46, Quantity = 31 }
            }
            ;

            //все компьютеры с указанным процессором.Название процессора запросить у пользователя;
            Console.WriteLine($"Выберите процессор (AMD или Intel):");
            var valueProc = Console.ReadLine();

            List<Computer> computersProc = (from c in list
                                            where c.Processor == valueProc
                                            select c).ToList();
            foreach (Computer computer in computersProc)
            {
                Console.WriteLine($"{computer.Id} {computer.Brand} {computer.Processor} {computer.Frequency} {computer.Ram} {computer.Hdd} {computer.Videomemory} {computer.Cost} {computer.Quantity}");
            }

            //все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            Console.WriteLine($"Выберите минимальный объемом ОЗУ:");
            var valueRam = Convert.ToInt32(Console.ReadLine());

            List<Computer> computersRam = (from c in list
                                           where c.Ram >= valueRam
                                           select c).ToList();
            foreach (Computer computer in computersRam)
            {
                Console.WriteLine($"{computer.Id} {computer.Brand} {computer.Processor} {computer.Frequency} {computer.Ram} {computer.Hdd} {computer.Videomemory} {computer.Cost} {computer.Quantity}");
            }

            Console.WriteLine($"Cписок, отсортированный по увеличению стоимости");
            List<Computer> computersSortCost = (from c in list
                                                orderby c.Cost
                                                select c).ToList();
            foreach (Computer computer in computersSortCost)
            {
                Console.WriteLine($"{computer.Id} {computer.Brand} {computer.Processor} {computer.Frequency} {computer.Ram} {computer.Hdd} {computer.Videomemory} {computer.Cost} {computer.Quantity}");
            }

            Console.WriteLine($"Cписок, сгруппированный по типу процессора");
            var groupedProc = (from c in list
                               group c
                               by c.Processor);
            foreach (var group in groupedProc)
            {
                Console.WriteLine($"{group.Key}");

                foreach (var computer in group)
                {
                    Console.WriteLine($"{computer.Id} {computer.Brand} {computer.Processor} {computer.Frequency} {computer.Ram} {computer.Hdd} {computer.Videomemory} {computer.Cost} {computer.Quantity}");
                }
            }

            //найти самый дорогой и самый бюджетный компьютер;
            var maxCost = (from c in list
                           select c.Cost)
                           .Max();
            var minCost = (from c in list
                           select c.Cost)
                           .Min();
            Console.WriteLine($"Cамый дорогой компьютер стоит - {maxCost}");
            Console.WriteLine($"Cамый бюджетный компьютер стоит - {minCost}");

            //есть ли хотя бы один компьютер в количестве не менее 30 штук?
            var n = 30;
            var n1 = (from c in list
                      where c.Quantity >= n
                      select c);                      
            var nal = n1.Any();
            Console.WriteLine($" Компьютер в количестве 30 или более шт. - {nal}");

            Console.ReadKey();
        }
    }
}
