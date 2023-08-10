using System;

namespace InsertingatEndofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // inserting at the end of an array 
            int[] intArray = new int[6];
            int length = 0;
            Console.WriteLine("Original Array: ");
            //Populating the array
            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i;
                //  we have to increase the value of length so that we can move on to the next index
                length++;
            }

            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }

            // this will get the value of length the last index at this point and make it 8
            
            Console.WriteLine("New Array: ");
            intArray[length -1]  = 8;
            length++;
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }


        }
    }
}
