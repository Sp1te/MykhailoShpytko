using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_1
{

    class Program
    {
   
        static int Size(int N)
        {
            int res = 0;
            if (N == 0)
            {
               res = 1;
            }
            else while (N != 0)
                 {
                    N /= 10;
                    res++;
                 }

            return res;
        }


        static int[] Get_arr(int N)
        {
            int temp = 0;
            int[] arr = new int [Size(N)];

            for(int i = Size(N) - 1; i >= 0; i--)
            {
                temp = N % 10;
                N /= 10; 
                arr[i] = temp;
            }
            return arr;
        }

        static void Print_arr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = {arr[i]}" + ", ");
            }
            Console.WriteLine();
        }

        static int Arithmetic_mean(int N)
        {
            int res = 0;
            for(int i = 0; i < Get_arr(N).Length; i++)
            {
                res = res + Get_arr(N)[i];
            }
            return res / Get_arr(N).Length;
        }

        static double Geometrical_mean(int N)
        {
            int res = 1;
            for(int i = 0; i < Get_arr(N).Length; i++)
            {
                if (Get_arr(N)[i] != 0)
                {
                    res *= Get_arr(N)[i];
                }
            }
            return Math.Pow(res, 1.0/Get_arr(N).Length);
        }
        static void Print_factorial(int N)
        {
          
            if (N < 65)
            {
                ulong factorial = 1;
                for(int i = 0; i < N; i++)
                {
                    factorial *= (ulong)i;
                }
                Console.WriteLine($"Factorial = {factorial}");
          
            }
            else { Console.WriteLine("Very bigest number"); }
                  
        }

        static int Even_summ_for(int N)
        {
            int res = 0;
            for(int i = 0; i < Get_arr(N).Length; i++)
            {
                if(Get_arr(N)[i] % 2 == 0)
                {
                    res += Get_arr(N)[i];
                }
            }
            return res;
        }

        static int Even_summ_while(int N)
        {
            int i = 0;
            int res = 0;
            while (i < Get_arr(N).Length)
            {
                if (Get_arr(N)[i] % 2 == 0)
                {
                    res += Get_arr(N)[i];
                }
                i++;
            }
            return res;
        }

        static int Even_summ_dowhile(int N)
        {
            int i = 0;
            int res = 0;
            do
            {
                if (Get_arr(N)[i] % 2 == 0)
                {
                    res += Get_arr(N)[i];
                }
                i++;
            } while (i < Get_arr(N).Length);
            return res;
        }



        static int Odd_summ(int N)
        {
            int res = 0;
            for (int i = 0; i < Get_arr(N).Length; i++)
            {
                if (Get_arr(N)[i] % 2 == 1)
                {
                    res += Get_arr(N)[i];
                }
            }
            return res;
        }

        static int Even_summ(int N, int start, int final)
        {
            
            int res = 0;
            {
                    for (int i = start; i <= final; i++)
                    {
                        if (Get_arr(N)[i] % 2 == 0)
                        {
                            res += Get_arr(N)[i];
                        }
                    }
                }
          
            
            return res;
        }

        static int Odd_summ(int N, int start, int final)
        {

            int res = 0;
            {
                for (int i = start; i <= final; i++)
                {
                    if (Get_arr(N)[i] % 2 == 1)
                    {
                        res += Get_arr(N)[i];
                    }
                }
            }


            return res;
        }




        static void Main(string[] args)
        {
            int N;

            while(true){
                try
                {
                    Console.WriteLine("Type your number");
                    N = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (OverflowException)
                {
                     Console.WriteLine("Your number is too big");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Type a integer number");
                }
            }
   

            Print_arr(Get_arr(N));
            Console.WriteLine($"Size = {Size(N)}");
            Console.WriteLine($"Arithmetic mean = {Arithmetic_mean(N)}");
            Console.WriteLine($"Geometrical mean = {Geometrical_mean(N)}");
            Console.WriteLine($"Even summ = {Even_summ(N)}");
            Console.WriteLine($"Odd summ = {Odd_summ(N)}");
            Print_factorial(N);
         

            Console.WriteLine("Type first possision arr");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type final possision arr");
            int final = Convert.ToInt32(Console.ReadLine());

            if (start < 0 || final > Get_arr(N).Length || final - start < 0)
            {
                Console.WriteLine("Number is not current");
            }
            else
            {
                Console.WriteLine($"Even summ = {Even_summ(N, start, final)}");
                Console.WriteLine($"Odd summ = {Odd_summ(N, start, final)}");
            }
            Console.ReadKey();
        }

        private static int[] Get_arr(object n)
        {
            throw new NotImplementedException();
        }
    }
}