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

            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(partOfWorld3);
            arrayList1.Add(partOfWorld1);
            arrayList1.Add(partOfWorld2);

            Console.WriteLine("--Before sort--");
            foreach (var element in arrayList1)
            {
                Console.WriteLine(element);
            }
            arrayList1.Sort();
            Console.WriteLine("--After sort--");
            foreach (var element in arrayList1)
            {
                Console.WriteLine(element);
            }

            ArrayList arrayList2 = new ArrayList(5);
            arrayList2.Add(5);
            arrayList2.Add(35);
            arrayList2.Add(12);

            int userNumber = Convert.ToInt32(Console.ReadLine());
            int pos = arrayList2.IndexOf(userNumber);
            Console.WriteLine($"Position of {userNumber}: {pos}.");

            int sum = 0;
            for (int i = 0; i < arrayList2.Count; i++)
            {
                sum += (int)arrayList2[i];
            }
            Console.WriteLine($"Sum: {sum}");

            arrayList1.Clear();
            Console.ReadLine();
        }
    }
}