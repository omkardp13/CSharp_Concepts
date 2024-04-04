
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1;
namespace ConsoleApp1
{
    class Program
    {

        /*
         * Multidimensional Arrays:

           A multidimensional array in C# represents a table of elements with a fixed number of dimensions.
           It can be two-dimensional, three-dimensional, or even higher.
           Multidimensional arrays are rectangular, meaning all rows have the same number of columns.
           Syntax: int[,] myArray = new int[3, 4]; creates a 2D array with 3 rows and 4 columns.
         * 
         * 
         * 
         * Jagged Arrays:

           A jagged array, also known as an array-of-arrays, is an array whose elements are arrays.
           Unlike multidimensional arrays, jagged arrays can have varying lengths for each row.
           Each "sub-array" within the jagged array can have different lengths.
          Syntax:

          int[][] jaggedArray = new int[3][];
          jaggedArray[0] = new int[] { 1, 2, 3 }; // First row with 3 elements
          jaggedArray[1] = new int[] { 4, 5 };    // Second row with 2 elements
          jaggedArray[2] = new int[] { 6, 7, 8 }; // Third row with 3 elements
         */


        /*
         * Here's a visual representation to illustrate the difference:

           Multidimensional Array:


          [ 1  2  3  4 ]
          [ 5  6  7  8 ] 
          [ 9 10 11 12 ]

          Jagged Array:

          [ 1  2  3 ]
          [ 4  5 ]
          [ 6  7  8 ]
In summary, multidimensional arrays are like tables with fixed dimensions, 
        while jagged arrays are arrays of arrays, allowing for more flexibility in the lengths of rows.
         * 
         */
        static void Main(string[] args)
        {
            // Syntax for declaring an array of integers
            int[] MyArray;

            // Syntax for declaring and initializing an array of integers
            int[] arr=new int[10];

            // Initializing the array with values
            int[] arr1 = new int[] {1,2,3,4,5,6,7,8};

            // Another way to initialize an array (omitting the size)
            int[] aaaa = { 1, 2, 3, 4, 5, };




            // Multidimensional array declaration and initialization
            int[,] my2DArray = new int[2, 3]; // Creates a 2x3 matrix of integers

            // Jagged array declaration and initialization
            int[][] myJaggedArray = new int[3][];
            myJaggedArray[0] = new int[3] { 1, 2, 3 };
            myJaggedArray[1] = new int[2] { 4, 5 };
            myJaggedArray[2] = new int[4] { 6, 7, 8, 9 };

        }
    }

}
    