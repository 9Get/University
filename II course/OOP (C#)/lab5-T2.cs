using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_5
{
    class WaterSurface
    {
        protected float depth;
        protected bool freshwater;
        protected bool dry;
        public WaterSurface(float depth, bool freshwater, bool dry)
        {
            this.depth = depth;
            this.freshwater = freshwater;
        }
        public override string ToString()
        {
            return "WaterSurface";
        }
        public static void Method1(Object obj)
        {
            Console.WriteLine(obj);
        }

        public static void Method2(WaterSurface waterSurface)
        {
            Console.WriteLine(waterSurface);
        }

        public virtual void Method3()
        {
            Console.WriteLine("WaterSurface");
        }
    }

    sealed class River : WaterSurface
    {
        string nameOfRiver;
        float lengthOfRiver;

        public River(string nameOfRiver, float lengthOfRiver, float depth, bool freshwater, bool dry) : base(depth, freshwater, dry)
        {
            this.nameOfRiver = nameOfRiver;
            this.lengthOfRiver = lengthOfRiver;
        }
        public override string ToString()
        {
            return "River";
        }

        public override void Method3()
        {
            Console.WriteLine("River");
        }
    }

    sealed class Lake : WaterSurface
    {
        string nameOfLake;
        float area;

        public Lake(string nameOfLake, float area, float depth, bool freshwater, bool dry) : base(depth, freshwater, dry)
        {
            this.nameOfLake = nameOfLake;
            this.area = area;
        }
        public override string ToString()
        {
            return "Lake";
        }
        public override void Method3()
        {
            Console.WriteLine("Lake");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WaterSurface waterSurface1 = new WaterSurface(152f, true, true);
            River river1 = new River("Нил", 6852f, 6.32f, false, false);
            Lake lake1 = new Lake("Гурон", 59600f, 229, true, false);

            WaterSurface.Method1(waterSurface1 as WaterSurface);
            WaterSurface.Method1(river1 as River);
            WaterSurface.Method1(lake1 as Lake);
            WaterSurface.Method1(waterSurface1 as River);

            Console.WriteLine("==============================");

            WaterSurface.Method2(river1);
            WaterSurface.Method2(lake1);

            Console.WriteLine("==============================");

            WaterSurface[] waterSurfaces1 = { new WaterSurface(111, true, false), new River("qwerty", 1439f, 6f, false, true), new Lake("asdfg", 316f, 7f, true, false) };
            for(int i = 0; i < waterSurfaces1.Length; i++)
            {
                waterSurfaces1[i].Method3();
            }

            Console.ReadLine();
        }
    }
}