using System;

namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisHelper redisHelper = new RedisHelper("127.0.0.1:6379");
            bool r1 = redisHelper.SetValue("czs", "czhensheng");
            string saveValue = redisHelper.GetValue("czs");
            Console.WriteLine(saveValue);
            bool r2 = redisHelper.SetValue("czs", "chewnzhensheng");
            saveValue = redisHelper.GetValue("czs");
            Console.WriteLine(saveValue);
            bool r3 = redisHelper.DeleteKey("czs");
            saveValue = redisHelper.GetValue("czs");
            Console.WriteLine(saveValue);
            RedisString.Set("mykey1", "abcdef");
            Console.WriteLine(RedisString.Get("mykey1"));

            string key = "Users";
            RedisBase.Core.FlushAll();
            RedisBase.Core.AddItemToList(key, "cuiyanwei");
            RedisBase.Core.AddItemToList(key, "xiaoming");
            RedisBase.Core.Add<string>("mykey", "123456");
            RedisString.Set("mykey1", "abcdef");
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
