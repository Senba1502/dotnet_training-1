using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Scholarship
  
    {
        
        public decimal Merit(int marks, decimal fees)
        {
            decimal ScholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                ScholarshipAmount = fees * 0.2; 
            }
            else if (marks > 80 && marks <= 90)
            {
                ScholarshipAmount = fees * 0.3; 
            }
            else if (marks > 90)
            {
                ScholarshipAmount = fees * 0.5; 
            }

            return ScholarshipAmount;
        }
    }

    
    public class Schlor
    {
        public static void Main()
        {
            Scholarship Scholar = new Scholarship();

            Console.WriteLine("Enter marks: ");
            int marks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fees: ");
            decimal fees = decimal.Parse(Console.ReadLine());

            decimal ScholarshipAmount = Scholar.Merit(marks, fees);
            Console.WriteLine($"Scholarship Amount: {ScholarshipAmount}");

            Console.Read();
        }
    }

}

