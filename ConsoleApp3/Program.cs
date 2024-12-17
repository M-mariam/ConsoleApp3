using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formating 
            //Equation: 4 + 3 = 7

            Console.WriteLine("Equation : 4 + 3 = 7"); // static
            //String message = "Equation : 4 + 3 = 7";

            //1.Sting concatination
            int x = 5, y = 3;
            string message = "equation : " + x + "+" + y + " = " + (x + y);
            Console.WriteLine(message);
            //string : immutable datatype : can't chage its value after creation

            // 2. String format
            string message2 = string.Format("Equation : {0} + {1} = {2}", x, y, x + y);
            Console.WriteLine(message);

            //  3. string interpolation
            // $ : Manipulation operator
            string message3 = $"Equation : {x} + {y} = {x + y}";
            Console.WriteLine(message);
            #endregion

            //Control statments
            //   1.conditional control statment(if, switch case)
            #region EX01
            Console.Write("Enter month number in 1st quarter: ");
            int MounthNumber = int.Parse(Console.ReadLine());
            //1. using if
            if (MounthNumber == 1)
            {
                // body , code : that will be executed when the epression is true
                Console.WriteLine("Jan");
            }
            else if (MounthNumber == 2)
            {
                Console.WriteLine("Feb");
            }
            else if (MounthNumber == 3)
            {
                Console.WriteLine("March");
            }
            else
            {
                Console.WriteLine("Invalid Month Number");
            }

            // using switch -> jump table -> # table 
            switch (MounthNumber)
            {
                case 1:
                    //code 
                    Console.WriteLine("jan");
                    break;
                case 2:
                    Console.WriteLine("Fen");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }
            #endregion
            #region ex02
            Console.Write("enter you name: ");
            string Name = Console.ReadLine();
            if (Name == "Ahmed" || Name == "ahmed")
            {
                Console.WriteLine("Hi ahmed");
            }
            else if (Name == "Omar" || Name == "omar")
            {
                Console.WriteLine("Hi Omar");
            }
            else if (Name == "Mariam" || Name == "mariam")
            {
                Console.WriteLine("Hi Mariam");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            //switch
            switch (Name)
            {
                case "Ahmed":
                //if(Name =="ahmed") -> and
                case "ahmed":
                    //code 
                    Console.WriteLine("Hi Ahmed");
                    break;
                case "Omar":
                case "omar":

                    Console.WriteLine("Hi Omar");
                    break;
                case "Mariam":
                case "mariam":
                    Console.WriteLine("Hi Mariam");
                    break;
                default:
                    Console.WriteLine("Invalid Name");
                    break;
            }
            #endregion
            #region ex03
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Welcome :)");
            }
            else if (age < 18)
            {
                Console.WriteLine("Bye Bye :(");
            }
            else
            {
                Console.WriteLine("equal ");

            }

            //switch
            switch (age > 18)
            {
                case true:
                    Console.WriteLine("Welcome :) ");
                    break;
                case false:
                    if (age < 18)
                    {
                        Console.WriteLine("Bye :( ");

                    }
                    else
                    {
                        Console.WriteLine("Equal  ! ");

                    }
                    break;
            }
            //Or
            switch (age)
            {
                case > 189:
                    Console.WriteLine("Welcome :) ");
                    break;
                case < 18:
                    Console.WriteLine("Bye :(");
                    break;
                default:
                    Console.WriteLine("Equals");
                    break;
            }

            #endregion

            object Input = new object();
            Input = 1;
            Input = "Mariam";
            //c# 7
            switch (Input)
            {
                case int X when X > 12:
                    Console.WriteLine("Int input");
                    break;
                case int X when X < 12:
                    Console.WriteLine("Int input");
                    break;
                case string S when S.Length > 12:
                    Console.WriteLine("String input");
                    break;
            }
            //C# 8
            string Inputs = Console.ReadLine();
            string Output = Inputs switch
            {
                "1" => "option 01",
                "2" => "option 02",
                "3" => "option 03",
                _ => "invalid"
            };

            //2.loop control statment(for, for each, while, do while)
            #region for loop
            for (/*statment*/; /*espression (T, F)*/; /*statment*/ )
            {
                // code : that will be repeated
            }
            //    for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Hello world");
            //}
            // foreach
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int N in numbers)
            {
                Console.WriteLine(N);
            }
            #endregion
            //while
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Hello");
                i++;
            }
            //do while --> chech frist

            int i2 = 11;
            do
            {
                Console.WriteLine("Hello");

            }
            while (i <= 10);
            int evenNum;
            do
            {
                Console.WriteLine("Even number");
                //evenNum = int.Parse(Console.ReadLine());
                //flag = int.TryParse(Console.ReadLine(), out evenNum);
            } while (!int.TryParse(Console.ReadLine(), out evenNum) || evenNum % 2 != 0);
            Console.WriteLine(evenNum);

            string S01;

            // //8 bytes
            //S01 = new string("ahmed");
            //S01 = "ahmed"; // syntax sugar
            //StringBuilder-- > same as string
            // mutable: can change its value after creation 
            //StringBuilder S01 = new StringBuilder("hello");
            //Console.WriteLine("S01" + S01);
            //Console.WriteLine("HashCode" + S01.GetHashCode());

            //S01.Append("ahmed");
            //Console.WriteLine("S01" + S01);
            //Console.WriteLine("HashCode" + S01.GetHashCode());
            // String methods 
            S01 = "Hello world";
            //string result = S01.Substring(S01.Length);
            string result = S01.Replace("Hello", "Welcome");

            //Console.WriteLine(result);
            //Console.WriteLine(S01);
        }
    }
}
