using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s = new Sorting();
            
            s.SortElements();
        }
    }

    public class Sorting
    {
        //List<int> elementsToSort = new List<int>();
        int[] elementsToSort = {10, 4, 17, 2, 5};
        int currentElement;
        int count = 1;
        //int reset;
        int maxCount;
        int temporarySpace;
        int previousKey;

        public void SortElements()
        {
            //elementsToSort.Add(10);
            //elementsToSort.Add(4);
            //elementsToSort.Add(7);
            //elementsToSort.Add(2);
            //elementsToSort.Add(5);

            //reset = count;
            maxCount = elementsToSort.Length;
            while(count < maxCount)
            {
                for (int currentKey = 1; currentKey < maxCount; currentKey++)
                {
                    currentElement = elementsToSort[currentKey];
                    previousKey = currentKey - 1;

                    while (previousKey >= 0 && elementsToSort[previousKey] > currentElement)
                    {
                        temporarySpace = currentElement;
                        elementsToSort[currentKey] = elementsToSort[previousKey];
                        elementsToSort[previousKey] = temporarySpace;
                        temporarySpace = 0;
                    }
                } --maxCount;
            }

            Debug.WriteLine("Sorted elements:");

            foreach(int value in elementsToSort)
            {
                Debug.WriteLine("{0}",value);
            }
        }
    }

}
