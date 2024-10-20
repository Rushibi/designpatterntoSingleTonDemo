﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

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
        public static Singleton getSingletoninstance()
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
