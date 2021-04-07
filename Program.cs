using StackExchange.Redis;
using System;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = "";

            while (score != "exit")
            {
                    var options = new ConfigurationOptions();
                options.EndPoints.Add("localhost", 6379);

                var redis = ConnectionMultiplexer.Connect(options);
                var db = redis.GetDatabase(3);

                const string key1 = "appsKey";
                db.KeyDelete(key1);
                db.StringSet(key1, 1);

                const string key2 = "appsKey";
                db.KeyDelete(key2);
                db.StringSet(key2, 4);

                score = Console.ReadLine();
            }
        }
    }
}
