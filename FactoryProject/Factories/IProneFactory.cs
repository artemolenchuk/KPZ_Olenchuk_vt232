namespace Factories
{
    using Devices;

    public class IProneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("IProne");
        public IDevice CreateNetbook() => new Netbook("IProne");
        public IDevice CreateEBook() => new EBook("IProne");
        public IDevice CreateSmartphone() => new Smartphone("IProne");
    }
}