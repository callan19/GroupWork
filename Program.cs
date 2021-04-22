using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          string DOB;
          string course;
          string firstName;
          string lastName;
          string gender;
          string gradYear;
          string instatutionName;
          int studentID;


        if (string.IsNullOrEmpty(DOB))
        {
            Console.WriteLine("Enter your date of birth");

        }

         if (string.IsNullOrEmpty(course))
        {
            Console.WriteLine("Enter the name of your course");

        }

         if (string.IsNullOrEmpty(firstName))
        {
            Console.WriteLine("Enter your first name");

        }

         if (string.IsNullOrEmpty(lastName))
        {
            Console.WriteLine("Enter your last name");

        }

         if (string.IsNullOrEmpty(gender))
        {
            Console.WriteLine("Enter your gender");

        }

         if (string.IsNullOrEmpty(gradYear))
        {
            Console.WriteLine("Enter your graduation vibe");

        }

         if (string.IsNullOrEmpty(instatutionName))
        {
            Console.WriteLine("Enter the name of your instatution");

        }

         if (string.IsNullOrEmpty(studentID))
        {
            Console.WriteLine("Enter your student ID");

        }


        }
    }
}
