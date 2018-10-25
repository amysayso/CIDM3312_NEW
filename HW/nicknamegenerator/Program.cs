using System;

namespace nicknamegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //random
            Random adjectives = new Random();

            //adj

            /* 
            string [] Adventurous = {"adventuresome", "audacious", "bold", "courageous" ,"intrepid", "risky", "brave"};
            string [] Boring = {"dull", "stale", "uninteresting", "tiring" ,"tiresome", "monotonous", "humdrum", "stodgy"};
            string [] Healthy = {"active", "athletic", "fresh", "hearty" ,"lively", "strong", "tough", "healthful"};
            string [] Fancy = {"complicated", "decorative", "special", "sumptuous" ,"lavish", "elegant", "frilly"};
            string [] Sweet = {"appealing", "beautiful", "charming", "delicious" ,"delightful", "engaging", "generous", "loveable","loving", "gentle", "luscious"};
              */

            
            //first name
            Console.WriteLine("Hello! What is your name? ");
            string firstName = Console.ReadLine(); 

           //adj options
           Console.WriteLine("Please pick one from the list of adjectives: Adventurous, Boring, Healthy, Fancy, and Sweet." );
            
            // string adj = Console.ReadLine();
            //adj.ToUpper();
            //string adj = "Adventurous";
            string adj = Console.ReadLine();
            //Console.WriteLine(adj);

            switch (adj){


                case "Adventurous":
                            string [] Adventurous = new string[7] {"Adventuresome", "Audacious", "Bold", "Courageous" ,"Intrepid", "Risky", "Brave"};
                            adj = Adventurous[adjectives.Next(1,6)];
                            Console.WriteLine("{0}" + " {1}", adj, firstName); 
                            break;

                case "Boring":
                            string [] Boring = new string[8]{"Dull", "Stale", "Uninteresting", "Tiring" ,"Tiresome", "Monotonous", "Humdrum", "Stodgy"};
                            adj = Boring[adjectives.Next(1, 7)];
                            Console.WriteLine("{0}" + " {1}", adj, firstName);
                            break;

                case "Healthy":
                            string [] Healthy =new string[8] {"Active", "Athletic", "Fresh", "Hearty" ,"Lively", "Strong", "Tough", "Healthful"};
                            adj = Healthy[adjectives.Next(1, 7)];
                            Console.WriteLine("{0}" + " {1}", adj, firstName);
                            break;

                case "Fancy":
                            string [] Fancy = new string[7] {"Complicated", "Decorative", "Special", "Sumptuous" ,"Lavish", "Elegant", "Frilly"};
                            adj = Fancy[adjectives.Next(1, 6)];
                            Console.WriteLine("{0}" + " {1}", adj, firstName);
                            break;

                case "Sweet":
                            string [] Sweet = {"Appealing", "Beautiful", "Charming", "Delicious" ,"Delightful", "Engaging", "Generous", "Loveable","Loving", "Gentle", "Luscious"};
                            adj = Sweet[adjectives.Next(1, 10)];
                            Console.WriteLine("{0}" + " {1}", adj, firstName);
                            break;

            }
                
        }
    
    }
}
