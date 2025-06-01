using System.Threading.Channels;

namespace Task13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаем экземпляр класса умного дома
            SmartHomeSystem alex = new SmartHomeSystem("0", "0", "0");
            // Подписываемся на событие изменения состояния любого устройства
            alex.DeviceStatus += (Device, message) =>
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {Device} {message}");
            };
            //Проверим работу устройства "алекс"
            {
                alex.TurnOffLight();
                alex.TurnOnLight();
                alex.SetTemperature(23);
                alex.UnlockDoor();
                alex.LockDoor();
            }
        }
        public delegate void DeviceStateChanged(string Device, string message);

        public class SmartHomeSystem(string Light, string Thermostat, string Door)
        {
            public event DeviceStateChanged DeviceStatus;
            string Light = "Light:";
            string Thermostat = "Thermostat:";
            string Door = "Door:";
            public void TurnOnLight()
            {
                DeviceStatus?.Invoke(Light, "Выключен");
            }
            public void TurnOffLight()
            {
                DeviceStatus?.Invoke(Light, "Включен");
            }
            public void SetTemperature(int newTemp)
            {
                DeviceStatus?.Invoke(Thermostat, $"Температура изменена на {newTemp} °C");
            }
            public void LockDoor()
            {
                DeviceStatus?.Invoke(Door, "Заблокирована");
            }
            public void UnlockDoor()
            {
                DeviceStatus?.Invoke(Door, "Открыта");
            }
        }
    }
}


