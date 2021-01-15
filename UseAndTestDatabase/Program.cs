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
            using (var dbCondext = new CablesDatabaseContext())
            {
                var class1 = new FireProtectionClass { Designation = "", ProtectionClass = "О.1.8.2.5.4" };
                var class2 = new FireProtectionClass { Designation = "нг(А)-LS", ProtectionClass = "П.1б.8.2.2.2" };
                var class3 = new FireProtectionClass { Designation = "нг(А)-FRHF", ProtectionClass = "П.1б.1.2.1.2" };

                dbCondext.FireProtectionClasses.Add(class1);
                dbCondext.FireProtectionClasses.Add(class2);
                dbCondext.FireProtectionClasses.Add(class3);
                dbCondext.SaveChanges();
                Console.WriteLine("Sucsessfully saved!");

                var classes = dbCondext.FireProtectionClasses.ToList();
                Console.WriteLine("Objects list:");
                foreach (var cl in classes)
                {
                    Console.WriteLine($"{cl.Id}: {cl.ProtectionClass} - {cl.Designation}");
                }
                Console.ReadKey();
            }
        }
    }
}
