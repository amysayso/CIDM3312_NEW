using System;

namespace CompoundInterest
{
    class Program
    {

        static double CalculatingInterest(double principal, double rate, double numberOfYears, double time){
            double amount;
            amount = principal * Math.Pow(1 + rate / numberOfYears , numberOfYears * time);
            return amount;
        }  
        static void Main(string[] args)
        {

        // RECIPE: 
        //     Title: Calculating an Interest Rate 

        //     Description: We are looking to determine an interest rate based on inputs of a person’s age, gender, and credit score.

        //     Ingredients:
        //             double principal;
        //             double rate;
        //             double numberOfYears;
        //             double time;
        //             double result;
        //             double age;
        //             double creditScore = 0.0;
        //             string gender;
        //             double total= 0.0;

        //     Instructions:
        //            1. Create the variables. 
        //            2. Get user input for the variables.
        //            3. Create a switch statement to determine a base interest rate based of the credit score.
        //            4. Create ranges of credit scores that will assign a specific interest rate.
        //            5. Minimally adjust the interest rate depending on age. Younger people get higher interest rates. Middle aged people 
        //               tend to get decent to good rates. Older people tend to get lower interest rates.
        //            6. Minimally adjust the interest rate depending on gender. Men tend to require higher interest rates. Women tend to 
        //               keep the same interest rates, not lower ones. 

        //     Completeness: We’ll know it’s complete when there is a final interest rate.


        double principal;
        double rate;
        double numberOfYears;
        double time;
        double result;
        double age; 
        double gender = 0.0; 
        double creditScore = 0.0;
        double total = 0.0;



        Console.WriteLine("What is your principal investment amount?");
        principal = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("What is your annual interest rate? ");
        rate = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("What is your number of time that interest is compounded per year? ");
        numberOfYears = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the total time? ");
        time = Convert.ToDouble(Console.ReadLine());

        
        result = CalculatingInterest(principal,rate, numberOfYears, time);


        //age
        Console.WriteLine("What is your age group? 1) 18-29, 2) 30-59, 3)60+");
        age = Convert.ToDouble(Console.ReadLine());

        switch (age)
        {
            case 1: total = result + 1.0;
            break;

            case 2: total = result + 3.0;
            break;

            case 3: total = result + 5.0;
            break;
        }
        
        //creditscore
        Console.WriteLine("What is your credit score? 1)0-580, 2)581-669, 3)670-739, 4)740-799 5)800-850 ");
        creditScore = Convert.ToDouble(Console.ReadLine());

        switch (creditScore)
        {
            case 1: total = result + 10.0;
            break;

            case 2: total = result + 6.0;
            break;

            case 3: total = result +4.0;
            break;

            case 4: total= result +2.0;
            break;

            case 5: total= result + 1.0;
            break;
        }

        //gender
        Console.WriteLine("What is your gender? 1)male or 2)female");
        gender = Convert.ToDouble(Console.ReadLine());

        switch (gender)
        {
            case 1: total = result + 4.0;
            break;

            case 2: total = result + 2.0;
            break;

        }
       

        result = CalculatingInterest(principal,rate, numberOfYears, time);
        
        Console.WriteLine("Here is your interest rate: {0}", total);
        
        }
    }
}
