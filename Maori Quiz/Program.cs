using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maori_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the maori quiz"); // intro and description
            Console.WriteLine("Whats you name?"); //Ask for the name of the person
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name + " How old are you?");

            int age = int.Parse(Console.ReadLine());

            if (age < 14)  //checks age
            {
                Console.WriteLine("You are too young for this quiz");
            }


            else if (age > 14)
            {   ///////////////////////////Q1/////////////////////////////////
                Console.WriteLine("Today we will test you knowledge on Te Reo Maori");
                Console.WriteLine("There will be 8 questions with option Good Luck!");
                Console.WriteLine("Q1: How do you say Hello in Te Reo Maori?");
                Console.WriteLine("    a.Kia Ora   b.Ni hao  c.Kamusta");
                string answer = Console.ReadLine();

                if (answer != "a")
                {
                    Console.WriteLine("Correct anwser is a");
                }
                else if (answer == "a") 
                {
                    Console.WriteLine("Yes correct");
                }


                //////////////////////////Q2/////////////////////////////////////
                Console.WriteLine("Q2: What does Tena koutou katoa mean?");
                Console.WriteLine(" a.What's your name?  b.Hello everybody  c.Hello");
                string answer1 = Console.ReadLine();

                if (answer1 != "b")
                {
                    Console.WriteLine("Correct anwser is b");
                }
                else if (answer1 == "b")
                {
                    Console.WriteLine("Yes correct");
                }

                
                
                ///////////////////////////Q3/////////////////////////////////
                Console.WriteLine("Q3: How do you say good afternoon in maori?");
                Console.WriteLine("   a.Tena po pai  b.Kei te ahiahi  c.Morena ");
                string answer2 = Console.ReadLine();

                if (answer2 != "b")
                {
                    Console.WriteLine("Correct anwser is b");
                }
                else if (answer2 == "b")
                {
                    Console.WriteLine("Yes correct");
                }



                ///////////////////////////Q4///////////////////////////////
                Console.WriteLine("Q4: What does Koa mean in maori?");
                Console.WriteLine("   a.No  b.Yes  c.Please ");
                string answer3 = Console.ReadLine();

                if (answer3 != "c")
                {
                    Console.WriteLine("Correct anwser is c");
                }
                else if (answer3 == "c")
                {
                    Console.WriteLine("Yes correct");
                }


                ///////////////////////////Q5///////////////////////////////
                Console.WriteLine("Q5: How do you say thank you in maori ");
                Console.WriteLine("   a.Tena po pai  b.Kamusta c.Aroha mai ");
                string answer4 = Console.ReadLine();

                if (answer4 != "c")
                {
                    Console.WriteLine("Correct anwser is c");
                }
                else if (answer4 == "c")
                {
                    Console.WriteLine("Yes correct");
                }


                ///////////////////////////Q6///////////////////////////////
                Console.WriteLine("Q6: Where is maroi most often spoken? ");
                Console.WriteLine("   a.New Zealand  b.Scotland  c.Africa ");
                string answer5 = Console.ReadLine();

                if (answer5 != "a")
                {
                    Console.WriteLine("Correct anwser is a");
                }
                else if (answer5== "a")
                {
                    Console.WriteLine("Yes correct");
                }


                ///////////////////////////Q7///////////////////////////////
                Console.WriteLine("Q7: How do you say winter in maroi? ");
                Console.WriteLine("  a.Te takurua  b.Ramuti  c.ngahuru ");
                string answer6 = Console.ReadLine();

                if (answer6 != "a")
                {
                    Console.WriteLine("Correct anwser is a");
                }
                else if (answer6 == "a")
                {
                    Console.WriteLine("Yes correct");
                }


                ///////////////////////////Q8///////////////////////////////
                Console.WriteLine("Q8: How do you say good bye in maroi? ");
                Console.WriteLine("  a.te aha  b.tama  c.Kia koa ");
                string answer8 = Console.ReadLine();

                if (answer6 != "c")
                {
                    Console.WriteLine("Correct anwser is v");
                }
                else if (answer8 == "c")
                {
                    Console.WriteLine("Yes correct");
                }

                Console.WriteLine("Thanks for playing press any key to exit");
                Console.ReadKey(); 



            }
            Console.ReadLine(); 
            


          


        }
    }
}