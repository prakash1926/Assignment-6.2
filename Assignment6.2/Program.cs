using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentGrades = new ArrayList()
            {
                85,
                92,
                78,
                95,
                88
            };
            int sum = 0;
            Console.WriteLine("Grades of the students are as follows");
            foreach (int i in studentGrades)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("Sum of all grades: " + sum);
            studentGrades.Add(90);
            Console.WriteLine("ArrayList after addition");
            foreach (int i in studentGrades)
            {
                Console.WriteLine(i);
            }
            studentGrades.Remove(78);
            Console.WriteLine("ArrayList after removing an element");
            foreach (int i in studentGrades)
            {
                Console.WriteLine(i);
            }
            int ind = studentGrades.IndexOf(95);
            if (ind != -1 && ind < studentGrades.Count)
            {
                studentGrades[ind] = 96;
                Console.WriteLine("ArrayList after changing the value");
                foreach (int i in studentGrades)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("element not found at this arraylist");
            }

            Console.ReadKey();

        }
    
    }
}
