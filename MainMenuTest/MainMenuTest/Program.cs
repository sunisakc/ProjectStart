using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenuTest
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuChoice();
        }
        private static void MenuChoice()
        {
            /* string input = "";
            while (input != "0")
            {
            Console.WriteLine("Welcome to main menu");
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine("(1) Senior Citizen");
            Console.WriteLine("(2) Repeat it ten time");
            Console.WriteLine("(3) The third world");
            Console.WriteLine("(0) Exit program");
            input = Console.ReadLine();
            if (input == "1")
            {
            Option1();
            }
            else if (input == "2")
            {
            Option2();
            }
            else if (input == "3")
            {
            Option3();
            }
            else if (input == "0")
            {
            break;
            }
            else
            {
            Console.WriteLine("Inconrrect choice");
           Console.ReadLine();
            }
            }
            Console.WriteLine("Thank you for your time");
            Console.ReadLine();
            }
            */
            string input = " ";

            Console.WriteLine("Welcome to main menu: 1=Option1 2=Option2 3=Option30 = Exit");
           
            Console.Write("Please enter your selection");
            input = Console.ReadLine();
            int swithchExp = int.Parse(input);
            switch (swithchExp)
            {
                case 1:

                    {

                        Option1();
                    }
                    break;
                case 2:
                    //if (swithchExp == 2)
                    {
                        Option2();
                    }
                    break;
                case 3:
                    // if (swithchExp == 3)
                    {
                        Option3(); ;
                    }
                    break;
                case 0:

                    //if (swithchExp == 0)
                    {
                        Console.WriteLine("Invalid selection please choose 1, 2 or 3");
                }
                    break;

            }

            Console.WriteLine("Thank you for your time");
            Console.ReadLine();
        }
        public static void Option1()
        {
            Console.WriteLine("Please input your age");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            if (age < 20)
            {
                Console.WriteLine("Kids deal:80kr");
            }
            else if (age >= 64)
            {
                Console.WriteLine("Senior Citizen Discount:90");
            }

            else
            {
                Console.WriteLine("Standard price:120");
            }
            Console.ReadLine();
        }
        public static void Option2()
        {
            Console.WriteLine("Enter words");
            string speed = Console.ReadLine();
            Console.WriteLine("Enter the number of time you want to print");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write(speed);
                }
            }
        }
        public static void Option3()
        {
            string temp;
            string sentenceText = (" ");
            Console.WriteLine("Please Enter sentence with at least three words");
            temp = Console.ReadLine();
            sentenceText = temp;
            string[] split = sentenceText.Split(' ');
            foreach (string item in split)
            {
                Console.WriteLine(item);
            }
            // find the third word and out put the third word
            string text = sentenceText.Split(' ')[0];
            if (sentenceText.Length >= 2)
            {
                Console.WriteLine("The third word is:" + text);
            }
            else
            {
                Console.WriteLine("You need more than 3 words");
            }
            Console.ReadLine();
        }
    }
}