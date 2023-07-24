using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    interface IWaterSurface
    {
        string Name { get; }
        string Continent { get; }
        float Depth { get; }
    }

    class River : IWaterSurface 
    {
        string name;
        string continent;
        float depth;

        public River()
        {
            this.name = "None";
            this.continent = "None";
            this.depth = 0f;
        }
        public River(string name, string continent, float depth)
        {
            this.name = name;
            this.continent = continent;
            this.depth = depth;
        }

        public string Name { get => name; }
        public string Continent { get => continent; }
        public float Depth { get => depth; }
        public override string ToString()
        {
            return $"River: {name}\nLocated in {continent}\nHas depth: {depth}m.\n";
        }
    }

    class Lake : IWaterSurface, IComparable<Lake>, IComparer
    {
        protected string name;
        protected string continent;
        protected float depth;

        public Lake()
        {
            this.name = "None";
            this.continent = "None";
            this.depth = 0f;
        }
        public Lake(string name, string continent, float depth)
        {
            this.name = name;
            this.continent = continent;
            this.depth = depth;
        }

        public string Name { get => name; }
        public string Continent { get => continent; }
        public float Depth { get => depth; }

        public int CompareTo(Lake lake)
        {
            return continent.CompareTo(lake.continent);
        }
        public int Compare(object x, object y)
        {
            Lake lake1 = (Lake)x;
            Lake lake2 = (Lake)y;
            return lake1.depth.CompareTo(lake2.depth);
        }

        public override string ToString()
        {
            return $"Lake: {name}\nLocated in {continent}\nHas depth: {depth}m.\n";
        }
    }
    class SortArray : IComparer
    {
        public int Compare(object x, object y)
        {
            Lake lake1 = (Lake)x;
            Lake lake2 = (Lake)y;
            return lake1.Name.CompareTo(lake2.Name);
        }
    }

    class Program
    {
        void MethodForInterface(IWaterSurface waterSurface)
        {
            Console.WriteLine(waterSurface.ToString());
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            River river1 = new River("Dnipro", "Europe", 18.79f);
            Lake lake1 = new Lake("Victoria", "Africa", 80f);
            IWaterSurface[] waterSurface1 = { new River("Amazon", "South America", 100f), new Lake("Michigan", "North America", 281f)};

            program.MethodForInterface(river1);
            program.MethodForInterface(lake1);
            program.MethodForInterface(waterSurface1[0]);

            Lake[] lakeArray1 = { new Lake("Baikal", "Asia", 1637f), new Lake("Tanganyika", "Africa", 1470f), new Lake("Venern", "Europe", 100f) };

            Console.WriteLine("==============Before Sorting #1==============");
            foreach (var element in lakeArray1)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine("==============After Sorting==============");
            Array.Sort(lakeArray1);
            foreach (var element in lakeArray1)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine("==============Before Sorting#2==============");
            foreach (var element in lakeArray1)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine("==============After Sorting==============");
            Array.Sort(lakeArray1, new Lake());
            foreach (var element in lakeArray1)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine("==============Before Sorting#3==============");
            foreach (var element in lakeArray1)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine("==============After Sorting==============");
            Array.Sort(lakeArray1, new SortArray());
            foreach (var element in lakeArray1)
            {
                Console.WriteLine(element.ToString());
            }

            Console.ReadLine();
        }
    }
}