using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR11
{
    class Airport<T>where T:Plane
    {
        List<T> listOfPlanes = new List<T>() { };
        public Airport() { }
        public Airport(T[] planes)
        {
            foreach(var plane in planes){
                listOfPlanes.Add(plane);
            }
        }

        public void Sort()
        {
            listOfPlanes.Sort();
        }

        public void Show()
        {
            for(int i = 0; i < listOfPlanes.Count; i++)
            {
                Console.WriteLine(listOfPlanes[i]);
            }
        }
        public void Clear()
        {
            listOfPlanes.Clear();
        }
        public void Insert(int index, T plane)
        {
            listOfPlanes.Insert(index, plane);
        }
    }

    class Plane : IComparable
    {
        protected string Type { get; set; }
        protected int EnginePower { get; set; }
        protected int NumberOfPassengers { get; set; }

        public Plane () 
        {
            Type = "None";
            EnginePower = 0;
            NumberOfPassengers = 0;
        }

        public Plane(string type, int powerEngine, int numberOfPassengers)
        {
            Type = type;
            EnginePower = powerEngine;
            NumberOfPassengers = numberOfPassengers;
        }

        public int CompareTo(object obj)
        {
            Plane plane = (Plane)obj;
            return NumberOfPassengers.CompareTo(plane.NumberOfPassengers);
        }

        public override string ToString()
        {
            return $"Type: {Type},\nEngine power: {EnginePower},\nNumber of passengers: {NumberOfPassengers}.";
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plane[] planes = { new Plane("Interceptor", 9500, 2), new Plane("Passenger", 8000, 103), new Plane("Transport", 8000, 4) };
            Airport<Plane> airport = new Airport<Plane>(planes);

            //Airport<Program> airport1 = new Airport<Program>();

            airport.Insert(1, new Plane());

            Console.WriteLine("--Before sort--\n");
            airport.Show();
            airport.Sort();
            Console.WriteLine("\n--After Sort--\n");
            airport.Show();

            airport.Clear();
            Console.ReadLine();
        }
    }
}