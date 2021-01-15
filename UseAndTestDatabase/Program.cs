using Cables.Brands.Common;
using Cables.Brands.Database;
using System;
using System.Linq;

namespace UseAndTestDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new CablesDatabaseContext())
            {
                var class1 = new FireProtectionClass { Designation = "", ProtectionClass = "О.1.8.2.5.4" };
                var class2 = new FireProtectionClass { Designation = "нг(А)-LS", ProtectionClass = "П.1б.8.2.2.2" };
                var class3 = new FireProtectionClass { Designation = "нг(А)-FRHF", ProtectionClass = "П.1б.1.2.1.2" };

                dbContext.FireProtectionClasses.Add(class1); //добавить 1 запись
                dbContext.FireProtectionClasses.AddRange(class2, class3); //Добавить несколько записей
                dbContext.SaveChanges();
                Console.WriteLine("Sucsessfully saved!" + Environment.NewLine);

                var firstClass = dbContext.FireProtectionClasses.FirstOrDefault();
                if(firstClass != null)
                {
                    firstClass.ProtectionClass = "22";
                    firstClass.Designation = "22";
                    dbContext.Update(firstClass); //обновляем конкретный объект

                    dbContext.Remove(firstClass); //Удаляем конкретный объект 
                    dbContext.SaveChanges(); //Внести обновления в базу после изменений
                }

                var item = dbContext.FireProtectionClasses.Where(i => i.Id == 22).FirstOrDefault();
                if (item != null)
                {
                    dbContext.Remove(item);
                    dbContext.SaveChanges();
                }
                else
                    Console.WriteLine("Записи не существует!");

                var classes = dbContext.FireProtectionClasses.ToList(); // получить все записи из таблицы
                Console.WriteLine("Objects list:");
                //Выводим все данные из таблицы
                foreach (var cl in classes)
                {
                    Console.WriteLine($"{cl.Id}: {cl.ProtectionClass} - {cl.Designation}");
                }
                Console.ReadKey();
            }
        }
    }
}
