using Subscriptions;
using Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            ISubscriptionCreator website = new WebSite();
            ISubscriptionCreator mobileApp = new MobileApp();
            ISubscriptionCreator managerCall = new ManagerCall();

            Subscription domesticSub = website.CreateSubscription("Domestic");
            Subscription eduSub = mobileApp.CreateSubscription("Educational");
            Subscription premiumSub = managerCall.CreateSubscription("Premium");

            Console.WriteLine(domesticSub);
            Console.WriteLine(eduSub);
            Console.WriteLine(premiumSub);
        }
    }
}
