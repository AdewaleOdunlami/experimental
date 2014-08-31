using System;
using System.Collections;
using System.Text;
using System.Diagnostics;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting sort = new Sorting();
            
            sort.SortElements();
        }
    }

    public class Sorting
    {
        int[] elementsToSort = {10, 4, 17, 2, 5};
        int currentElement = 0;
        int count = 1;
        int maxCount = 0;
        int temporarySpace = 0;
        int previousKey = 0;

        public void SortElements()
        {
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
