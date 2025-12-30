using Dal;
using DalApi;
using DalList;
using DO;

namespace DalTest
{
    internal class Program
    { 
        static readonly IDal s_dal=new Dal.DalList();
        private static void Main(string[] args)
        {
            Initialization.Initialize(s_dal);
            int select1 = PrintMainMenu();
            Console.WriteLine(select1);

        }

        public static int PrintMainMenu()
        {
            Console.WriteLine("Product? press 1, Customer? press 2, Sale? press 3, exit? press another key");
            return int.Parse(Console.ReadLine());
        }


    }
}
