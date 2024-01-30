using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> FirstList = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> SecondList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> res = MergeAndSort(FirstList, SecondList);
            foreach(int i in res)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static List<int> MergeAndSort(List<int> FirstList, List<int> SecondList)
        {
            List<int> res = new List<int>();

            while(FirstList.Count > 0 && SecondList.Count > 0)
            {
                if (FirstList[FirstList.Count - 1] > SecondList[SecondList.Count - 1])
                {
                    res.Add(FirstList[FirstList.Count - 1]);
                    FirstList.RemoveAt(FirstList.Count - 1);
                }
                else
                {
                    res.Add(SecondList[SecondList.Count - 1]);
                    SecondList.RemoveAt(SecondList.Count - 1);
                }
            }
            FirstList.Reverse();
            SecondList.Reverse();
            res.AddRange(FirstList);
            res.AddRange(SecondList);
            return res;
        }
    }
}
