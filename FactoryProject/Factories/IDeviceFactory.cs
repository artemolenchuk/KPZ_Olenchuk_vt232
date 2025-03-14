namespace Factories
{
    using Devices;

    public interface IDeviceFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }
}