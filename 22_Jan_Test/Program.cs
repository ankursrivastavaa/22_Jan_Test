using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Jan_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grades");
            try
            {
                string s = Console.ReadLine();
                int n = int.Parse(s);

                Console.WriteLine("Your grades based on your marks are :" + Grade_Calculate(n));
                Console.ReadKey(true);
            }// End of try

            catch
            {

            }

            string Grade_Calculate(int input)

            {
                int n = input;
                string grade = "";

                if (n >= 95)
                {
                    grade = "A+";
                    
                }

                else if (n < 95 && n >= 90)
                    {
                             grade = "A";
                             
                    }

            else if (n < 90 && n >= 87)
            {
                grade = "A-";
                
            }
                else if(n < 87 && n >= 84)
                {
                    grade = "B+";
                    
                }

                else if (n < 84 && n >= 80)
                {
                    grade = "B+";
                    
                }

                else if (n < 80 && n >= 77)
                {
                    grade = "B";
                    
                }

                else if (n < 80 && n >= 77)
                {
                    grade = "B-";
                    
                }

                else if (n < 77 && n >= 74)
                {
                    grade = "C+";
                    
                }

                else if (n < 74 && n >= 70)
                {
                    grade = "C";
                    
                }

                else if (n < 70 && n >= 67)
                {
                    grade = "C-";
                    
                }

                else if (n < 67 && n >= 63)
                {
                    grade = "D+";
                    
                }

                else if (n < 63 && n >= 60)
                {
                    grade = "D";
                    
                }

                else if (n < 60)
                {
                    grade = "F";
                    
                }

                else
                {
                    Console.WriteLine("Please enter proper marks");
                }

                return grade;
            }

        }// end of main
    }
}
