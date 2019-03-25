using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(123);
            list.Add(123);
            list.Add(4);
            list.Add(5);
            int max = list.Count - 1;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[max] < list[i])
                {
                    max = i;
                }
            }
            Console.WriteLine($"{max} - {list[max]}");

            int sum = 0;
            for(int i = 0; i < list.Count; i++){
                if(i % 2 == 0){
                    sum += list[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
