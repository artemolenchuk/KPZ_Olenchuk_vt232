namespace Devices
{
    public class EBook : IDevice
    {
        private string brand;
        public EBook(string brand) => this.brand = brand;
        public string GetDeviceName() => $"{brand} E-Book";
    }
}