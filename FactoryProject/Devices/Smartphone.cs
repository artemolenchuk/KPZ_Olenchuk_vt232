namespace Devices
{
    public class Smartphone : IDevice
    {
        private string brand;
        public Smartphone(string brand) => this.brand = brand;
        public string GetDeviceName() => $"{brand} Smartphone";
    }
}