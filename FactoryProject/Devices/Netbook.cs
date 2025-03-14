namespace Devices
{
    public class Netbook : IDevice
    {
        private string brand;
        public Netbook(string brand) => this.brand = brand;
        public string GetDeviceName() => $"{brand} Netbook";
    }
}