using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static System.Console;

namespace ForTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HI :)";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\twere to go?");
            
            int width = Console.WindowWidth / 2;
            int height = 10;

            while (width !=0 && height !=0)
            {
                Char.TryParse(Console.ReadLine(), out char ch);                
                ch = Char.ToUpper(ch);
                Console.CursorLeft = Console.WindowWidth / 2;
                switch (ch)
                {
                    case 'A':
                        Console.SetCursorPosition(1, 1);
                        Console.Write("_move_left_\u2190     ");
                        Console.SetCursorPosition(width, height);
                        Console.Write("\u2190");
                        Console.SetCursorPosition(0, 1);
                        --width;                  
                         break;

                    case 'D':
                        Console.SetCursorPosition(1, 1);
                        Console.WriteLine("_move_right_\u2192     ");
                        Console.SetCursorPosition(width, height);
                        Console.Write("\u2192");
                        Console.SetCursorPosition(0, 1);
                        ++width;                        
                         break;

                    case 'W':
                        Console.SetCursorPosition(1, 1);
                        Console.WriteLine("_move_up_\u2191     ");
                        Console.SetCursorPosition(width, height);
                        Console.Write( "\u2191");
                        Console.SetCursorPosition(0, 1);
                        --height; 
                        break;

                    case 'S':
                        Console.SetCursorPosition(1, 1);
                        Console.WriteLine("_move_down_\u2193     ");
                        Console.SetCursorPosition(width, height);
                        Console.Write("\u2193");
                        Console.SetCursorPosition(0, 1);
                        ++height;
                        break;

                    default:
                        Console.SetCursorPosition(1, 1);
                        Console.WriteLine("_stay_put_\u2194     ");
                        Console.SetCursorPosition(0, 1);
                        break;

                }
            }

        }
    }
}

