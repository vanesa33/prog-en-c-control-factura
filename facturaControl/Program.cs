using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string PROD;
            int CAN = 0;
            int FI = 0;
            double PRE = 0;
            double TOT = 0;
            double PAGA = 0;
            char OP;
            string linea;
            FI = 6;
            PAGA = 0;
            Console.SetCursorPosition(5, 4);
            Console.Write("PRODUCTO CANTIDAD PRECIO TOTAL");
            do
            {
                Console.SetCursorPosition(5, FI);
                PROD = Console.ReadLine();
                Console.SetCursorPosition(17, FI);
                linea = Console.ReadLine();
                CAN = int.Parse(linea);
                Console.SetCursorPosition(27, FI);
                linea = Console.ReadLine();
                PRE = int.Parse(linea);
                TOT = CAN * PRE;
                Console.SetCursorPosition(33, FI);
                Console.Write(TOT);
                PAGA = PAGA + TOT;
                FI = FI + 1;
                Console.SetCursorPosition(30, 23);
                Console.Write("OTRO PRODUCTO S/N:");
                linea = Console.ReadLine();
                OP = char.Parse(linea.ToUpper());
            } while (OP.ToString().Contains("S"));
            Console.WriteLine("TOTAL A PAGAR :" + PAGA);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}