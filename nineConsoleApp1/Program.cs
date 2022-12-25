using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace nineConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// 九九乘法表
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i}*{j}={(i * j),3:N0}\r");
                }
                    Console.WriteLine();
                }  
            }
        }
    } 
