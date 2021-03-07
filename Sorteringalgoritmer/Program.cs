using System;
using System.Collections.Generic;
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
            List<int> tallista = new List<int>();
            SkapaSlumptallista(tallista, 10);
            Bubblesort(tallista);
            Console.WriteLine("Listan är sorterad!");
        }
    }
}
