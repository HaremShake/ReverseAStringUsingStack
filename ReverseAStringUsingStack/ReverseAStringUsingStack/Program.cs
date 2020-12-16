using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseAStringUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ReverseAStringUsingStack";
            Console.WriteLine("Enter a String:");
            string Input = Console.ReadLine();
            string Output = ReverseAString(Input);

            Console.WriteLine("\nReversed String is: " + Output);
            Console.Read();  
        }
        private static string ReverseAString(string Input)
        {
            var objStack = new Stack<char>();
            var OutPut = string.Empty;
            if (Input != null)
            {
               var InputLength = Input.Length;

               for (int i=0;i<InputLength;i++)  
                {  
                    objStack.Push(Input[i]);  
                }  
                
                while (objStack.Count != 0)  
                {  
                    OutPut += objStack.Pop();  
                }  
            }  
            return OutPut;  
        }
     }
 }

