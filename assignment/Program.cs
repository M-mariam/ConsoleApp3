using System;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            Console.WriteLine("Even A number that can be divided by 3 and 4");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }
            #endregion
            #region Q2
            Console.WriteLine("enter an integer");
            int integer = int.Parse(Console.ReadLine());
            if (integer < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
            #endregion
            #region Q3
            //Console.WriteLine("Enter 3 Numbers");
            //string[] numbers = Console.ReadLine().Split();
            //int max = 0;
            //max = int.Parse(numbers[0]);
            //int min = 0;
            //min = int.Parse(numbers[0]);
            //for (int i = 1; i < numbers.Length; i++){
            //    if (int.Parse(numbers[i]) > max)
            //    {
            //        max = int.Parse(numbers[i]);

            //    }
            //    if (int.Parse(numbers[i]) < min)
            //    {
            //        min = int.Parse(numbers[i]);

            //    }
            //}
            //Console.WriteLine("max number is " +max);
            //Console.WriteLine("min number is " +min);
            #endregion
            #region Q4
            //Console.WriteLine("Enter a Number");
            //int input = int.Parse(Console.ReadLine());
            //if (input % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            #endregion
            #region Q5
            //Console.WriteLine("Enter a character");
            //string Char = Console.ReadLine();
            //switch (Char)
            //{
            //    case "a":
            //    case "e":
            //    case "i":
            //    case "o":
            //    case "u":
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}
            #endregion
            #region Q6
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i<=num; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q7
            //Console.WriteLine("Enter a number");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i*number);
            //}
            #endregion
            #region Q8
            //Console.WriteLine("Enter a number");
            //int evennum = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= evennum; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Q9
            //Console.WriteLine("Enter Two numbers");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //for(int i = num1; i<=num2; i++)
            //{
            //    Console.WriteLine(num1*i);
            //}
            #endregion
            #region Q15

            //Console.WriteLine("Enter marks of five subjects ");
            //string input = Console.ReadLine();
            //int[] marks = input.Split(' ').Select(int.Parse).ToArray();
            //int total = marks.Sum();
            //double average = marks.Average();
            //double percentage = (total / 500) * 100; 
            //Console.WriteLine($"Total marks = " + total);
            //Console.WriteLine($"Average marks = " +average);
            //Console.WriteLine($"Percentage = " + percentage);
            #endregion
            #region Q11
            //Console.WriteLine("Enter Month Number");
            //int month = int.Parse(Console.ReadLine());
            //int year = DateTime.Now.Year;
            //int daysInMonth = DateTime.DaysInMonth(year, month);
            //Console.WriteLine(daysInMonth);
            #endregion

            #region Q12
            //Console.WriteLine("Enter 1st  Number");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter the operator");
            //string oper = Console.ReadLine();
            //Console.WriteLine("Enter 2nd  Number");
            //double num2 = double.Parse(Console.ReadLine());
            //double result = 0;
            //switch (oper)
            //{
            //    case "+":
            //        result = num1 + num2;
            //        break;
            //    case "-":
            //        result = num1 - num2;
            //        ; break;
            //    case "*":
            //        result = num1 * num2;
            //        break;
            //    case "/":
            //        result = num1 / num2;
            //        break;
            //    case "%":
            //        result = num1 % num2;
            //        break;

            //}
            #endregion
            #region Q13
            //Console.WriteLine("string");
            //string world = Console.ReadLine();
            //string reversedString = string.Empty;

            //for (int i = world.Length - 1; i > -1; i--)
            //{

            //    reversedString += world[i];
            //}

            //Console.WriteLine(reversedString);

            #endregion

            #region Q14
            //Console.WriteLine("enter numbers");
            //int integers = int.Parse(Console.ReadLine());
            //int reversInteger = 0;

            //while (integers > 0)
            //{
            //    reversInteger = (reversInteger * 10) + (integers % 10);
            //    integers = integers / 10;
            //}

            //Console.WriteLine(reversInteger);

            #endregion

            #region Q17
            //Console.WriteLine("Enter the first point (x1, y1):");
            //string[] point1 = Console.ReadLine().Split();
            //int x1 = int.Parse(point1[0]);
            //int y1 = int.Parse(point1[1]);

            //Console.WriteLine("Enter the second point (x2, y2):");
            //string[] point2 = Console.ReadLine().Split();
            //int x2 = int.Parse(point2[0]);
            //int y2 = int.Parse(point2[1]);

            //Console.WriteLine("Enter the third point (x3, y3):");
            //string[] point3 = Console.ReadLine().Split();
            //int x3 = int.Parse(point3[0]);
            //int y3 = int.Parse(point3[1]);

            //bool strightline = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
            //if (strightline == true)
            //{
            //    Console.WriteLine("the point is lie on a streight line");
            //}
            //else
            //{
            //    Console.WriteLine("the point is not lie on a streight line");

            //}
            #endregion
            #region Q18
            // Console.WriteLine("Enter hours");
            // int input = int.Parse(Console.ReadLine());
            //string output=  input switch
            //{
            //    <=3   => "highly efficient",
            //     >=3 and <=4 => "they are instructed to increase their speed.",
            //     >=4 and <=5 => "they are provided with training to enhance their speed. ",
            //     > 5 => " they are required to leave the company.",

            // };
            // Console.WriteLine(output);
            #endregion
        }
    }
}
