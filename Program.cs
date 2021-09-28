using System;
using System.Text;

namespace Cours_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder c = new StringBuilder();
            int b = 10;
            
                for (int i = 0; i < b; i++)
                {   
                    c.Append("*");
                    Console.WriteLine(c);
                }  
            }
        }
    }
