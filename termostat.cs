public class Thermostat : IDevice
    {
        public bool IsOn { get; private set; }
        public double Temperature { get; private set; } = 21.0; 
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("[Термостат] Система климат-контроля активирована.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("[Термостат] Система климат-контроля отключена.");
        }

        public void SetTemperature(double temperature)
        {
            Temperature = temperature;
            Console.WriteLine($"[Термостат] Целевая температура установлена на {Temperature}°C.");
        }
    }