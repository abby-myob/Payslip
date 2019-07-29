using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PayslipsFirstSolution
{
    static class Program
    {
        static void Main(string[] args)
        {

            string filepath = "/Users/abby.thompson/Development/sample_input.csv";
            string outputFilePath = "/Users/abby.thompson/Development/output.csv";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            List<string> output = new List<string>();
            List<Person> people = new List<Person>();

            lines.RemoveAt(0); //remove first line
            
            //create people and create calculate their payslip values
            foreach (string line in lines)
            {
                string[] data = line.Split(",");
                if (data.Length != 5) continue;
                
                Person person = new Person
                {
                    FirstName = data[0],
                    LastName = data[1],
                    AnnualSalary = int.Parse(data[2]),
                    SuperRate = int.Parse(data[3].TrimEnd( new char[] { '%', ' ' } ) ),
                    PayPeriod = data[4]
                };
                
                PayslipLogic payslip = new PayslipLogic(person);
                
                payslip.CalculateFullName(); 
                payslip.CalculateGrossIncome();
                payslip.CalculateIncomeTax();
                payslip.CalculateNetIncome();
                payslip.CalculateSuper();
                
                people.Add(person);
            }
            

            output.Add("name,pay period,gross income,income tax,net income,super");
            
            // write back to the csv file
            foreach (Person person in people)
            {
                output.Add(
                    $"{person.FullName}," +
                    $"{person.PayPeriod}," +
                    $"{person.GrossIncome}," +
                    $"{person.IncomeTax}," +
                    $"{person.NetIncome}," +
                    $"{person.Super}");
            }
            
            File.WriteAllLines(outputFilePath, output);
        }
    }
    
    
    
    
}