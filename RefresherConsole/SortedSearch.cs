using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
   
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            int lengthOfArray = sortedArray.Length;

            //check if the arry is empty
            if (lengthOfArray == 0) return 0;

            //since this is sorted array, if the first item is more than or equal to 'lessThan', then return 0
            //because there is no number less than 0 if thats the case
            if (sortedArray[0] >= lessThan) return 0;

            //if last item is less than the 'lessThan', then return the length of array, becase in that case all items are less than 'lessThan' 
            if (sortedArray[lengthOfArray - 1] < lessThan) return lengthOfArray;

            //since his is sorted array, traverse using binary serach to find the index of the node of less than 'lessThan' 
            int index = Array.BinarySearch(sortedArray, lessThan);
            if (index < 0)
                return ~index;

            return index;

            /*
            int i= 0;
            int count = 0;
            while(i < sortedArray.Length )
            {
                if(sortedArray[i] < lessThan) count++;

            }*/
            //foreach(var i in sortedArray)
            //{
            //if(i<lessThan)
            //count++;

            //}
            //return count;
        }

       
    }
}
