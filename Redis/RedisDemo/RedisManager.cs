using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedisDemo
{
    public class RedisManager
    {
        private static PooledRedisClientManager prcm;

        static RedisManager()
        {
            CreateManager();
        }

        private static void CreateManager()
        {
            string[] WriteServerConStr = SplitString(RedisConfig.WriteServerConStr, ",");
            string[] ReadServerConStr = SplitString(RedisConfig.ReadServerConStr, ",");
            prcm = new PooledRedisClientManager(ReadServerConStr, WriteServerConStr, new RedisClientManagerConfig()
            {
                MaxWritePoolSize = RedisConfig.MaxWritePoolSize,
                MaxReadPoolSize = RedisConfig.MaxReadPoolSize,
                AutoStart = RedisConfig.AutoStart
            });
        }

        public static IRedisClient GetClient()
        {
            if (prcm == null)
            {
                CreateManager();
            }
            return prcm.GetClient();
        }

        private static string[] SplitString(string strSource, string split)
        {
            return strSource.Split(split.ToArray());
        }
    }
}
