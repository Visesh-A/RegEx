﻿using System;
using UserRegistrationProblem_Regex;

namespace Regex_UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nchoose option to Perform \n1.First Name \n2.Last Name \n3.Email \n4.Mobile Number " +
                   "\n5.Password(Rule-1) \n6.Password(Rule-2) \n7.Password(Rule-3) \n8.Password(Rule-4) \n9.All Emails \n10.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                RegexProblems regular = new RegexProblems();
                switch (option)
                {
                    case 1:
                        regular.FirstName("Visesh");
                        break;
                    case 2:
                        regular.LastName("A");
                        break;
                    case 3:
                        regular.Email("abc.xyz@bl.co.in");
                        break;
                    case 4:
                        regular.Mobile("1234567890");
                        break;
                    case 5:
                        regular.Password1("Visesh5366");
                        break;
                    case 6:
                        regular.Password2("viseSH5366");
                        break;
                    case 7:
                        regular.Password3("VI5SE36");
                        break;
                    case 8:
                        regular.Password4("Wnfejf@0");
                        break;
                    case 9:
                        regular.AllEmails();
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }
        }
    }
}