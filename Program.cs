using System;

namespace demo02.ifstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score : ");
            string input = Console.ReadLine();

            int score = (int)double.Parse(input);
            string grade;

            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine("You got : " + grade);
        }
    }
}

