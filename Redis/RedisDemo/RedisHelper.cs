using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedisDemo
{
    public class RedisHelper
    {
        private ConnectionMultiplexer redis { get; set; }
        private IDatabase db { get; set; }
        public RedisHelper(string connection)
        {
            redis = ConnectionMultiplexer.Connect(connection);
            db = redis.GetDatabase();
        }

        public bool SetValue(string key, string value)
        {
            return db.StringSet(key, value);
        }

        public string GetValue(string key)
        {
            return db.StringGet(key);
        }

        public bool DeleteKey(string key)
        {
            return db.KeyDelete(key);
        }
    }
}
