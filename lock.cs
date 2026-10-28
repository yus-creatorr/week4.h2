public class Lock : IDevice
    {
        public bool IsOn { get; private set; }
        public bool IsLocked { get; private set; } = true; // Уникальное свойство

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("[Замок] Электронная система замка включена (питание подано).");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("[Замок] Электронная система замка отключена.");
        }

        public void LockDoor()
        {
            IsLocked = true;
            Console.WriteLine("[Замок] Дверь заперта.");
        }

        public void UnlockDoor()
        {
            IsLocked = false;
            Console.WriteLine("[Замок] Дверь разблокирована.");
        }
    }