using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console002_DiamondWithStars
{

//      “When we love, we always strive to become better than we are.
//      When we strive to become better than we are, everything around us becomes better too.”
//          ― Paulo Coelho, The Alchemist
    class Program
    {
        static void Main(string[] args)
        {

            // Let's draw a series of triangles and diamonds using stars..
            int sideLength = 9;

            // let's first draw a right triangle first
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Now let's reverse the triangle
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 9; j > i; j--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Now let's draw a full isosceles triangle
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = sideLength; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m < i+1; m++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

            // Now let's draw an empty isosceles triangle
            Console.WriteLine();
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = sideLength; j > i; j--)
                {
                    Console.Write(" "); // empty chars before left line
                }
                Console.Write("*"); // left line

                for (int m = 0; m < i; m++)
                {
                    if (m==0)
                    {
                        Console.Write(" ");// only one space in the second row..
                    }
                    else
                    {
                        Console.Write(" " + " ");
                    }
                }
                if (i == 0)
                {
                    Console.Write(" "); // in order to have only one star at the top of the triangle.
                                        // don't print a second one ...
                }
                else
                {
                    Console.Write("*"); // right line
                }
                Console.WriteLine();
            }
            for (int i = 0; i < sideLength+1; i++)
            {
                Console.Write("*" + " "); // bottom line
            }
            Console.WriteLine();

            // Now let's draw a full diamond
            Console.WriteLine();
            // upper half of the dimond
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = sideLength; j > i; j--)
                {
                    Console.Write(" ");// empty chars before the upper left line of the diamond
                }
                for (int m = 0; m < i + 1; m++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();// next line
            }
            //lower half of the diamond
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < i+1; j++)
                    if (j==0)
                    {
                        Console.Write(" " + " ");
                    }
                    else
                    {
                        Console.Write(" ");// empty chars before the left line at the lower half of diamond.
                    }
                for (int m = sideLength; m > i + 1; m--)
                {
                    Console.Write("*" + " "); // draw the lower half
                }
                Console.WriteLine();
            }

            // Now let's draw an empty diamond
            // first the upper half
            Console.WriteLine();
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = sideLength; j > i; j--)
                {
                    Console.Write(" "); // empty chars before left line
                }
                Console.Write("*"); // left line

                for (int m = 0; m < i; m++)
                {
                    if (m == 0)
                    {
                        Console.Write(" ");//we need only one space in the second row..
                    }
                    else
                    {
                        Console.Write(" " + " ");
                    }
                }
                if (i == 0)
                {
                    Console.Write(" "); // in order to have only one star at the top of the triangle.
                                        // don't print a second one ...
                }
                else
                {
                    Console.Write("*"); // right line
                }
                Console.WriteLine();
            }
            for (int i = 0; i < sideLength + 1; i++)
            {
                Console.Write("*" + " "); // bottom line
            }
            Console.WriteLine();

            // now let's reverse this empt triange to finish the lower half of the diamond
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
              
                Console.Write("*");// left line at the lower half

                for (int k = sideLength-1; k >i; k--)
                {     
                        Console.Write(" " + " ");
                }
                
                Console.Write("*");// right line at the lower half
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
