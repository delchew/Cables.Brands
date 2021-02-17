﻿using Cables.Brands.Database;
using System;
using System.Linq;

namespace UseAndTestDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            TestHowDatabaseWorking();
        }

        static void TestHowDatabaseWorking()
        {
            using (var dbContext = new CablesDatabaseContext())
            {
                var met1 = new Metal { MetalName = "медь", Density20 = 8890 };
                var met2 = new Metal { MetalName = "сталь", Density20 = 7800 };
                var met3 = new Metal { MetalName = "медь луженая", Density20 = 8890 };

                dbContext.Metals.Add(met1); //добавить 1 запись
                dbContext.Metals.AddRange(met2, met3); //Добавить несколько записей
                dbContext.SaveChanges();
                Console.WriteLine("Sucsessfully saved!" + Environment.NewLine);

                var met = dbContext.Metals.FirstOrDefault();
                if (met != null)
                {
                    met.MetalName = "new";
                    met.Density20 = 1000;
                    dbContext.Update(met); //обновляем конкретный объект

                    //dbContext.Remove(met); //Удаляем конкретный объект 
                    dbContext.SaveChanges(); //Внести обновления в базу после изменений
                }

                var item = dbContext.Metals.Where(i => i.Id == 2).FirstOrDefault();
                if (item != null)
                {
                    dbContext.Remove(item);
                    dbContext.SaveChanges();
                }
                else
                    Console.WriteLine("Записи не существует!");

                var classes = dbContext.Metals.ToList(); // получить все записи из таблицы
                Console.WriteLine("Metals:");
                //Выводим все данные из таблицы
                foreach (var cl in classes)
                {
                    Console.WriteLine($"{cl.Id}: {cl.MetalName} - {cl.Density20}");
                }
                Console.ReadKey();
            }
        }
    }
}
