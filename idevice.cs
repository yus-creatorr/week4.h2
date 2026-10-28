public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        bool IsOn { get; }
    }