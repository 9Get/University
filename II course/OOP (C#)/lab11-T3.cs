using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR11
{
    class PartOfWorld : IComparable
    {
        protected string Name { get; set; }
        protected int Area { get; set; }

        public PartOfWorld() { Name = "None"; Area = 0; }
        public PartOfWorld(string name, int area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(object obj)
        {
            PartOfWorld tempPartOfWorld = (PartOfWorld)obj;
            return Area.CompareTo(tempPartOfWorld.Area);
        }

        public override string ToString()
        {
            return $"Name of part: {Name}, area: {Area}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PartOfWorld partOfWorld1 = new PartOfWorld();
            PartOfWorld partOfWorld2 = new PartOfWorld("Africa", 30370000);
            PartOfWorld partOfWorld3 = new PartOfWorld("Australia", 8510000);

            HashSet<PartOfWorld> partOfWorlds = new HashSet<PartOfWorld>();
            partOfWorlds.Add(partOfWorld1);
            partOfWorlds.Add(partOfWorld2);
            partOfWorlds.Add(partOfWorld3);
            partOfWorlds.Add(partOfWorld1);

            foreach(var element in partOfWorlds)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}