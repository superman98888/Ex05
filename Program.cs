using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[height, height];
            draw1(array);
            draw2(array);
            draw3(array);
            draw4(array);
            Special(array);
            Create(array);
            
        }
        static void draw1(int[,] array)
        {
            //draw Dline1
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 1;
                    }
                }
            }
        }
        static void draw2(int[,] array)
        {// draw Dline2
            int temp = array.GetLength(1);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp = temp - 1;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == temp)
                    {
                        array[i, j] = 1;
                    }
                }
            }
        }
        static void draw3(int[,] array)
        {//draw 2 hori line
            int hori1 = -1;
            int hori2 = array.GetLength(1);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                hori1 = hori1 + 1;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == hori1)
                    {
                        array[0, j] = 5;
                    }
                    else
                    {
                        array[hori2 - 1, j] = 5;
                    }
                }
            }
        }
        static void draw4 (int [,] array)
        { //draw 2 line
            int temp = array.GetLength(0);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                        array[i, 0] = 9;
                        array[i, temp - 1] = 9;
                  
                }
            }
        }
        static void Special(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j && i == 0 ||i==j && i == array.GetLength(0)-1 )
                    {
                        array[i, j] = 4;
                    }
                    else if (i - j == array.GetLength(0)-1 || j - i == array.GetLength(0)-1 )
                    {
                        array[i, j] = 4;
                    }
                    
                }
            }
        }
        static void Create(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //Console.Write(array[i, j]);
                    if (array[i, j] == 1)
                    {
                        Console.Write("x");
                    }
                    else if (array[i, j] == 5)
                    {
                        Console.Write("-");
                    }
                    else if (array[i, j] == 9)
                    {
                        Console.Write("|");
                    }
                    else if (array[i, j] == 4)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
