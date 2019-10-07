using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.WriteLine("Type first string");
            str1 = Console.ReadLine();
           

            while (true)
            {
                Console.WriteLine("Type second string");
                str2 = Console.ReadLine();
                if (str1.Length < str2.Length)
                {
                    Console.WriteLine("Second string must be equal or lesser than first string ");
                }
                else { break; }
            }
        
            Console.WriteLine("str1 has content str2: " + ContentStr1InStr2(str1, str2));
            Console.WriteLine(ChangeCharacter(str1, str2));
            Console.WriteLine("str2 in str1 is contending: " + CoutOccurence(str1, str2));
           


            Console.ReadKey();
        }


        static bool ContentStr1InStr2(string str1, string str2)
        {
            int count = 0;

            for(int i = 0; i < str1.Length; i++)
            {
                for(int j = 0; i < str2.Length; i++)
                {
                    if (str1[i] == str2[j])
                    {
                        count++;

                    } 
                }
            }
            
            return count == str2.Length;
        }

        static string ChangeCharacter(string str1, string str2)
        {
            StringBuilder strbuilder = new StringBuilder(str1);

            for(int i = 0; i < strbuilder.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {

                    if (strbuilder[i] == str2[j])
                    {
                        strbuilder[j] = '#';
                    }

                }
            }
            return Convert.ToString(strbuilder);
        }

        static int CoutOccurence(string str1, string str2)
        {
            
            int count = (str1.Length - str2.Replace(str2, "").Length) / str2.Length;
            
            return count;
        }

    }
}
