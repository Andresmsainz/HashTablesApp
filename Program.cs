using System;
using System.Collections; //Contains Hashtables
namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable App!");

            //Creating
            Console.WriteLine("In Creating");
            Hashtable hash = new Hashtable();
            Console.WriteLine("------");

            //Adding
            Console.WriteLine("In Adding");
            hash.Add("Microsoft","USA");
            hash.Add("Nintendo", "Japan");
            hash.Add("Ikea", "Sweden");
            hash.Add("Mercedes", "Germany");
            Console.WriteLine("------");

            //Displaying
            Console.WriteLine("In Displaying");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("------");

            //Capacity
            Console.WriteLine("In Capacity");
            Console.WriteLine("Capacity currently at " + hash.Count);
            Console.WriteLine("------");

            //Remove
            Console.WriteLine("In Remove");

            Console.WriteLine("Removing Ikea");
            hash.Remove("Ikea");

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.WriteLine("------");

            //Contains
            Console.WriteLine("In Contains");
            Console.WriteLine("Does hash contain Ikea? " + hash.Contains("Ikea"));
            Console.WriteLine("Does hash contain Nintendo? " + hash.Contains("Nintendo"));
            Console.WriteLine("------");

            //Copy To Arraylist
            Console.WriteLine("In Copy to ArrayList");
            ArrayList array = new ArrayList(hash.Keys);

            Console.WriteLine("Displaying new array list");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
        }
    }
}
