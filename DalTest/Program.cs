using DO;
using DalApi;
using DalList;
using Dal;

namespace DalTest
{
    internal class Program
    { 
        static readonly IDal s_dal=new Dal.DalList();
        static void Main(string[] args)
        {
            Initialization.Initialize(s_dal);

        }
    }
}
