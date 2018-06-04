using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using StackExchange.Redis;
using Microsoft.Extensions.Configuration;

namespace RedisDemo
{
    /// <summary>
    /// 配置文件
    /// </summary>
    public class RedisConfig
    {
        public static string WriteServerConStr
        {
            get => string.Format("{0},{1}", "127.0.0.1:6379", "127.0.0.1:6380");
        }

        public static string ReadServerConStr
        {
            get => string.Format("{0}", "127.0.0.1:6379");
        }

        public static int MaxWritePoolSize
        {
            get => 50;
        }

        public static int MaxReadPoolSize
        {
            get => 200;
        }

        public static bool AutoStart
        {
            get => true;
        }

    }
}
