﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace test
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            DB.DbConnect();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    public class DB
    {
        public static MongoClient mongoClient;
        public static IMongoDatabase mongoDatabase;
        public static IMongoCollection<Item> mongoCollection;

        public static void DbConnect()
        {
            mongoClient = new MongoClient("mongodb://myhomesvr.tk:9000");
            //mongoClient = new MongoClient("mongodb://202.182.100.146:9000");
            mongoDatabase = mongoClient.GetDatabase("info");
            mongoCollection = mongoDatabase.GetCollection<Item>("info");
        }

        public class Item
        {
            public ObjectId Id { get; set; }
            public int Status { get; set; } = 0;
            public DateTime Data { get; set; }
            public string Name { get; set; }
            public string Tel { get; set; }
            public string Adr { get; set; }
            public string Imei { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
            public byte[] Foto { get; set; }
        }
        
    }
}

