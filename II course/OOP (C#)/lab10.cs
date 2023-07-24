using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10
{
    sealed class Lake : IDisposable
    {
        private bool disposedValue;

        private string Name { get; set; }
        private float Depth { get; set; }
        private float Area { get; set; }
        public Lake()
        {
            Name = "None";
            Depth = 0;
            Area = 0;
        }
        public Lake(string name, float depth, float area)
        {
            Name = name;
            Depth = depth;
            Area = area;
        }
        public override string ToString()
        {
            return $"Name: {Name},\nDepth: {Depth},\nArea: {Area}.\n";
        }

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // управляемые объекты
                }

                // неуправляемые объекты
                disposedValue = true;
            }
        }

        ~Lake()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lake lake1 = new Lake("Baikal", 100, 150);
            Lake lake2 = new Lake("Viktoria", 46, 94);
            Lake lake3 = new Lake();
            Console.WriteLine(lake1.ToString());
            lake2.Dispose();
            lake2 = null;
            GC.Collect(1, GCCollectionMode.Optimized);

            using (StreamWriter sw = new StreamWriter(@"C:\\Users\\SuperPC\\Desktop\\File.txt"))
            {
                sw.WriteLine("Using just worked");
                using (Lake lake4 = new Lake("UsingLake", 123, 45))
                {
                    Console.WriteLine(lake4.ToString());
                }
            }


            Console.ReadLine();
        }
    }
}