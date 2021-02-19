using CablesDatabaseEFCoreFirebird;
using CablesDatabaseEFCoreFirebird.Entities;
using System;
using System.Linq;

namespace UseAndTestDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveFromTwistedElementsType();
        }

        static void UpdateTwistedElementsType()
        {
            using (var dbContext = new CablesContext())
            {
                var typesList = dbContext.TwistedElementTypes.Where(t => t.ElementType.ToUpper().Contains("TEST"))
                                                               .ToList();
                foreach (var type in typesList)
                {
                    if (type != null)
                    {
                        type.ElementType = "NEW Value=))";
                        dbContext.Update(type);
                    }
                }
                dbContext.SaveChanges();
            }
        }

        static void RemoveFromTwistedElementsType()
        {
            using (var dbContext = new CablesContext())
            {
                var typesList = dbContext.TwistedElementTypes.Where(t => t.ElementType.ToUpper().Contains("VAL"))
                                                               .ToList();
                foreach (var type in typesList)
                {
                    if(type != null)
                        dbContext.Remove(type);
                }
                dbContext.SaveChanges();
            }
        }

        static void InsertIntoTwistedElemetsType()
        {
            using(var dbContext = new CablesContext())
            {
                var elType = new TwistedElementType { ElementType = "six! Test" };
                var elType1 = new TwistedElementType { ElementType = "seven! Test" };
                var elType2 = new TwistedElementType { ElementType = "eight! Test" };
                dbContext.TwistedElementTypes.Add(elType);
                dbContext.TwistedElementTypes.AddRange(elType1, elType2);
                dbContext.SaveChanges();
            }
        }

        static void PrintMetals()
        {
            using (var dbcontext = new CablesContext())
            {
                var metals = dbcontext.Metals.ToList();
                Console.WriteLine("Metals:");
                foreach (var m in metals)
                {
                    Console.WriteLine($"{m.Id}: {m.MetalName} - {m.Density20}");
                }
            }
        }

        static void PrintConductors()
        {
            using (var dbcontext = new CablesContext())
            {
                var conductors = dbcontext.Conductors.Where(c => c.AreaInSqrMm == 0.75m).ToList();
                Console.WriteLine("Conductors:");
                foreach (var r in conductors)
                {
                    Console.WriteLine($"{r.Id}: {r.Title} - {r.WiresCount}х{r.WiresDiameter} - {r.AreaInSqrMm}мм - {r.Metal.MetalName}");
                }
            }
        }

        static void PrintCablesInfo()
        {
            using (var dbcontext = new CablesContext())
            {
                var cables = dbcontext.Cables.Where(c => c.MaxCoverDiameter < 13 && 
                                                         c.Title.StartsWith("СКАБ 250У") &&
                                                         c.ElementsCount < 5)
                                             .ToList();
                Console.WriteLine("Cables:");
                foreach (var c in cables)
                {
                    Console.WriteLine($"{c.Id}: {c.Title}");
                }
            }
        }
    }
}
