﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFCore
{
    class Program
    {
        // 초기화 시간이 좀 걸림
        static void InitializeDB(bool forceReset = false)
        {
            using (AppDbContext db = new AppDbContext()) 
            {
                if (!forceReset && (db.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                    return;

                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Console.WriteLine("DB Initialized");
            }
        }
        static void Main(string[] args)
        {
            InitializeDB(true);
        }
    }
}