using Singleton;

namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            Authenticator auth1 = Authenticator.Instance;
            Authenticator auth2 = Authenticator.Instance;

            Console.WriteLine(auth1 == auth2 ? "Same instance" : "Different instances");

            auth1.Authenticate("user", "password123");
        }
    }
}
