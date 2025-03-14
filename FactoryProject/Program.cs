namespace AbstractFactory
{
    using System;
    using Factories;

    class Program
    {
        static void Main()
        {
            IDeviceFactory[] factories = { new KiaomiFactory(), new IProneFactory(), new BalaxyFactory() };

            foreach (var factory in factories)
            {
                Console.WriteLine("Devices from " + factory.GetType().Name.Replace("Factory", "") + ":");
                Console.WriteLine(factory.CreateLaptop().GetDeviceName());
                Console.WriteLine(factory.CreateNetbook().GetDeviceName());
                Console.WriteLine(factory.CreateEBook().GetDeviceName());
                Console.WriteLine(factory.CreateSmartphone().GetDeviceName());
                Console.WriteLine();
            }
        }
    }
}