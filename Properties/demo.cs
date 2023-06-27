using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Properties

   
{
    
    public class demo
    {
       
          static void Main(string[] args)
            {
                int WorkingDays = 1;
                int subjectperday = 1;
                int TotalSubjects = 1;
                int totalHoursWeek = 1;
                Console.WriteLine("Working Days : ");
                WorkingDays = Convert.ToInt32(Console.ReadLine());
                if (WorkingDays == 1)
                {
                    Console.WriteLine("please enter A Positive Number");

                }
                else if (WorkingDays >= 1 && WorkingDays <= 7)
                {
                    WorkingDays = WorkingDays - 1;
                }
                else
                {
                    Console.WriteLine("Please Enter the number between 1 and 7");
                }
                Console.WriteLine("subject per day : ");
                subjectperday = Convert.ToInt32(Console.ReadLine());
                if (subjectperday > 0 && subjectperday < 9)
                {
                    subjectperday = subjectperday - 1;
                }
                else
                {
                    Console.WriteLine("Please enter the number between 1 and 9");
                }
                Console.WriteLine("TotalSubjects : ");
                TotalSubjects = Convert.ToInt32(Console.ReadLine());
                if (TotalSubjects > 0)
                {
                    TotalSubjects = TotalSubjects - 1;
                }
                else
                {
                    Console.WriteLine("Please enter a positive number");
                }
                totalHoursWeek = WorkingDays * subjectperday;
                Console.WriteLine("total hours :" + totalHoursWeek);
            }

        }
    }
