using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int final = 100;
            int size = 5;
            Print_arr(Get_even_arr(size, start, final), size);
            //Console.WriteLine(Search_max_value(Get_arr_rand(size), size));
            //Console.WriteLine(Search_min_value(Get_arr_rand(size), size));

            Console.ReadKey();
        }


        static int[,] Get_arr_rand(int size)
        {
            int[,] arr = new int[size, size];
            Random rand = new Random();
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (i >= j)
                    {

                        arr[i, j] = rand.Next(1, 10);
                    }
                }
            }

            return arr;
        }

        static int[,] Get_even_arr(int size, int start, int final)
        {
            int[,] arr = new int[size, size];
            Random rand = new Random();
            int even = 0;
            for(int i = 0; i < size; i++)
            {
            
                for (int j = 0; j < size; j++)
                {
                    if ((rand.Next(start, final) % 2) == 0)
                    {
                        even = rand.Next(start, final);

                        if (i >= j)
                        {

                            arr[i, j] = even;


                        }
                    }
                }
            }
            return arr;

        }

        static int[,] Get_odd_arr(int size, int start, int final)
        {
            int[,] arr = new int[size, size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((rand.Next(start, final) % 2) == 1)
                    {
                        arr[i, j] = rand.Next(start, final);
                    }
                }
            }
            return arr;

        }


        static char[,] Get_arr_symbol(int size)
        {
            char[,] arr = new char[size, size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(i >= j)
                    {
                        arr[i, j] = (char)rand.Next(0x0020, 0x0070);
                    }
                }
            }
            return arr;
        }

        static char[,] Get__arr_eng(int size)
        {
            char[,] arr = new char[size, size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i >= j)
                    {
                        arr[i, j] = (char)rand.Next(0x0071, 0x007A);
                    }
                }
            }
            return arr;
        }

        static int Search_max_value(int[,] arr, int size)
        {
            int max = 0;

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }

        static int Search_min_value(int[,] arr, int size)
        {
            int min = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }

        static void Print_arr(int[,] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine("");
            }
        }
        static void Print_arr(char[,] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine("");
            }

        }
    }

   

}
