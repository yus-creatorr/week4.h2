public class Lamp : IDevice
    {
        public bool IsOn { get; private set; }
        public int Brightness { get; private set; } = 50; // Уникальное свойство

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("[Лампа] Свет включен.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("[Лампа] Свет выключен.");
        }

       
        public void SetBrightness(int brightness)
        {
            Brightness = brightness;
            Console.WriteLine($"[Лампа] Яркость установлена на {Brightness}%.");
        }
    }