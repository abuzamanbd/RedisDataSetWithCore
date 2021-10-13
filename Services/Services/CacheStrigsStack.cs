using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Ninject;
using Services.Model;
using StackExchange.Redis;

namespace RedisTest.Services
{
    public interface ICacheStrigsStack
    {
        string InsertInfoToRedis(DepositInfoModel depositInfoModel);
        DepositInfoModel CheckKeyExists(string key);
        void SetValue<T>(string key, T info);
        string GetStrings(string key);
        bool DeleteKey(string key);
    }
    public class CacheStrigsStack: ICacheStrigsStack
    {
        private readonly IDatabase _db;
        ConnectionMultiplexer _redis;
        private readonly IConfiguration _configuration;
        public CacheStrigsStack(IConfiguration configuration, IKernel kernel)
        {
            _configuration = configuration;
            try
            {
                var host = "localhost";
                var password = "";
                var options = ConfigurationOptions.Parse(host);

                if (!string.IsNullOrWhiteSpace(password))
                {
                    options.Password = password;
                }

                _redis = ConnectionMultiplexer.Connect(options);

                _db = _redis.GetDatabase();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string InsertInfoToRedis(DepositInfoModel depositInfoModel)
        {
            SetValue(depositInfoModel.ClientId.ToString(), depositInfoModel);
            return "Set Info SuccessFully";
        }
        public DepositInfoModel CheckKeyExists(string key)
        {
            var value = _db.StringGet(key);
            if (!value.HasValue)
            {
                return null;
            }
            var obj = JsonConvert.DeserializeObject<DepositInfoModel>(value);

            return obj;
        }

        public void SetValue<T>(string key, T info)
        {
            var serializeObj = JsonConvert.SerializeObject(info);
            var result = _db.StringSet(key, serializeObj);
        }

        public string GetStrings(string key)
        {
            throw new NotImplementedException();
        }

        public bool DeleteKey(string key)
        {
            throw new NotImplementedException();
        }
    }
}
