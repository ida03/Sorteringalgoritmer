using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteringalgoritmer
{
    class Program
    {
        static void Bubblesort(List<int> myList)
        {
            for (int i=0; i<myList.Count; i++)
            {
                for (int j=0; j < myList.Count - 1; j++)
                {
                    if (myList[j]> myList[j + 1])
                    {
                        int temp = myList[j];
                        myList[j] = myList[j + 1];
                        myList[j + 1] = temp;
                    }
                }
            }
        }
        static void Selectionsort(List<int> myList)
        {
            int temp, smallest;
            for (int i=0; i<myList.Count-1; i++)
            {
                smallest = i;
                for (int j = i+1; j<myList.Count; j++)
                {
                    if (myList[j] < myList[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = myList[smallest];
                myList[smallest] = myList[i];
                myList[i] = temp;
            }
        }

        static void SkapaSlumptallista(List<int>myList,int size)
        {
            Random slump = new Random();
            for (int i=0; i<size; i++)
            {
                myList.Add(slump.Next(100000));
            }
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            List<int> tallistaB = new List<int>();
            List<int> tallistaS = new List<int>();

            sw.Start();
            SkapaSlumptallista(tallistaB, 100000);
            Bubblesort(tallistaB);
            sw.Stop();
            Console.WriteLine("Listan är sorterad!");
            Console.WriteLine("Sorteringstid för Bubblesort " + sw.ElapsedMilliseconds);

            sw.Reset();

            sw.Start();
            SkapaSlumptallista(tallistaS, 100000);
            Selectionsort(tallistaS);
            sw.Stop();
            Console.WriteLine("Listan är sorterad!");
            Console.WriteLine("Sorteringstid för Selectionsort " + sw.ElapsedMilliseconds);
        }
    }
}
