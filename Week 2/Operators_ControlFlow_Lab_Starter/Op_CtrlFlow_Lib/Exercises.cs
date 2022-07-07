using System;
using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            if (nums.Count < 1)
                //return 0.0;
                throw new ArgumentException();

            double total = 0.0;
            foreach (int number in nums)
                total += number;
            return total / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Free" if they are under 5
        // "Child" if they are 5-12
        // "Student" if they are 13-17 inclusive
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        public static string TicketType(int age)
        {
            if (age < 0)
                throw new ArgumentOutOfRangeException();

            string ticketType = string.Empty;
            ticketType = age < 5 ? "Free"
                : age <= 12 ? "Child"
                : age <= 17 ? "Student"
                : age <= 59 ? "Standard"
                : "OAP";
            return ticketType;
        }

        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100)
                throw new ArgumentOutOfRangeException();
    
            var grade = "";
            if (mark >= 0 && mark <= 39)
                grade += "Fail";
            else if (mark >= 40 && mark <= 59)
                grade += "Pass";
            else if (mark >= 60 && mark <= 74)
                grade += "Pass with Merit";
            else if (mark >= 75 && mark <= 100)
                grade += "Pass with Distinction";
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            // Clarify default case requirements with client.
            // EDIT: Don't - Clarified in Exceptions Lab
            if (covidLevel < 0 || covidLevel > 4)
                throw new ArgumentException();

            int attendees = 0;
            switch (covidLevel)
            {
                case 0:
                    attendees = 200;
                    break;
                case 1:
                    attendees = 100;
                    break;
                case 2:
                    attendees = 50;
                    break;
                case 3:
                    attendees = 50;
                    break;
                case 4:
                    attendees = 20;
                    break;
                default:
                    break;
            }
            return attendees;
        }
    }
}
