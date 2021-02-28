using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //List<string> lj = new List<string>();

            //lj.Add("Studio Time");
            //lj.Add("Mixing");
            //lj.Add("Mario Plush");
            //Console.WriteLine("I want to get " + lj[0]);

            //Insert()
            //lj.Insert(1, "Internet");

            //Remove()
            //lj.Remove("Mixing");

            //RemoveAt()
            //lj.RemoveAt(0);

            //RemoveRange()
            //lj.RemoveRange(0, 2);

            //Sort()
            //lj.Sort();

            //Console.WriteLine("At LJ's, we offer:");
            //foreach (var ljhouse in lj)
            //{
            //    Console.Write(ljhouse + ", ");
            //}

            //lj[0] = "Cooking";
            //Console.WriteLine("After: I want to get " + lj[0]);

            ////AddRange()
            //var dante = new List<string>();
            //dante.AddRange(lj);
            //Console.WriteLine(dante[1]);


            //BinarySearch()
            //string[] ljArray = new string[3] { "Guitars", "Drum", "Vocal" };
            //Console.WriteLine(Array.BinarySearch(ljArray, "Drum"));

            //Clear()
            //lj.Clear();
            //Console.WriteLine(lj[0]);

            //Contains()
            //Console.WriteLine(lj.Contains("Mario"));

            var RecordingStudios = new List<Okura>() {
                new Okura(){serviceName = "Studio Time", servicePrice = 20 },
                new Okura(){serviceName = "Mixing", servicePrice = 50 },
                new Okura(){serviceName = "Music Production", servicePrice = 100 }
            };
            //foreach (var x in RecordingStudios)
            //{
            //    Console.WriteLine("I need " + x.serviceName + " for " + x.servicePrice + " at his house since he has Spectrum Internet.");
            //}

            //ForEach()

            //List<int> ljnum = new List<int>() { 21, 22, 23, 24 };
            //ljnum.ForEach(x => Console.WriteLine(x + "for LJ Studio"));

            //LINQ Examples

            var LJQuery = from s in RecordingStudios
                          where s.serviceName == "Mixing"
                          select s;
            Console.Write("The following services that is affordable to Lassiez Faire are: ");
            foreach(var ljs in LJQuery)
            {
                Console.Write(ljs.serviceName + ", whcih costs " + ljs.servicePrice + ", ");
            }
        }
    }
}
class Okura
{
    public string serviceName { get; set; }
    public int servicePrice { get; set; }
}