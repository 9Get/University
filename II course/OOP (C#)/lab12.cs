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
        public string Name { get; protected set; }
        public int Area { get; protected set; }

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

        public override bool Equals(object obj)
        {
            PartOfWorld pow = (PartOfWorld)obj;
            return Name == pow.Name && Area == pow.Area;
        }
        public override int GetHashCode()
        {
            int hashcode = Name.GetHashCode();
            hashcode = 23 * hashcode + Area.GetHashCode();
            return hashcode;
        }

        public override string ToString()
        {
            return $"Name of part: {Name}, area: {Area}";
        }
    }

    delegate void DMethod(int x);
    delegate void DMethodNoParameters();

    class Program
    {
        void VarIncrement(int x) { x++; }
        void NoParameters() { Console.WriteLine("NoParameters was invoked."); }

        static void Main(string[] args)
        {
            // 1
            Program program = new Program();
            DMethod dMethod = program.VarIncrement;
           
            int x = 4;
            dMethod(x);
            Console.WriteLine("x: " + x);

            // 2
            DMethodNoParameters dMethodNoParameters = program.NoParameters;
            dMethodNoParameters();

            // 3.1
            Action<int> action = program.VarIncrement;
            action(x);

            // 3.2
            Action actionNoPar = program.NoParameters;
            actionNoPar();

            // 4.1
            int num = Convert.ToInt32(Console.ReadLine());

            DMethod method = number => Console.WriteLine($"number^2 = {number * number}");
            method(num);

            // 4.2
            List<PartOfWorld> partsOfWorld = new List<PartOfWorld>();
            partsOfWorld.Add(new PartOfWorld());
            partsOfWorld.Add(new PartOfWorld("Africa", 30370000));
            partsOfWorld.Add(new PartOfWorld("Australia", 8510000));

            Func<PartOfWorld, PartOfWorld, int> sumAreas = (partsOfWorld1, partsOfWorld2) => partsOfWorld1.Area + partsOfWorld2.Area;
            Console.WriteLine($"Sum: {sumAreas(partsOfWorld[0], partsOfWorld[1])}");

            Console.ReadLine();
        }
    }
}