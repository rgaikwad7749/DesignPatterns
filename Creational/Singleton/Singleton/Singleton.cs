using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDemo
{
    public class Singleton
    {
        private static Singleton instance;

        private ConnectionMultiplexer conn;

        private Singleton()
        {

            conn = ConnectionMultiplexer.Connect("localhost");
        }

        public static Singleton getSingletonInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }


        public IDatabase someLogic()
        {
            return conn.GetDatabase();

        }

    }
}