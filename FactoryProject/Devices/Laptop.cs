namespace Devices
{
    public class Laptop : IDevice
    {
        private string brand;
        public Laptop(string brand) => this.brand = brand;
        public string GetDeviceName() => $"{brand} Laptop";
    }
}