using System;
using StackExchange.Redis;

namespace ConsoleRedis
{
    // docker run -d -p 6379:6379 redis
    // docker exec -it 666333e4ad18 redis-cli
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

            IDatabase db = redis.GetDatabase();

            string value = db.StringGet("name");
            Console.WriteLine(value);

            Console.ReadKey(); 
        }
    }
}
