
using PriceHunterFilter;

namespace PriceHunterService
{
    internal class Program
    {
        private static readonly string MONGO_CLIENT = "mongodb://mongo:NtpcyRBFfPJUMRpJSeGB@containers-us-west-125.railway.app:6855/";
        private static readonly string DATABASE_NAME = "test";
        private static readonly string API_COLLETION = "products";
        private static readonly string SCRAPER_COLLECTION = "holders";

        static void Main(string[] args)
        {
            PriceHunterMain filter = new PriceHunterMain(MONGO_CLIENT, DATABASE_NAME, API_COLLETION, SCRAPER_COLLECTION);
            //PriceHunterMain filter = new PriceHunterMain();
            filter.Start();

        }
    }
}
