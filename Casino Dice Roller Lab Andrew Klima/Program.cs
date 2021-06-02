using System;

namespace Casino_Dice_Roller_Lab_Andrew_Klima
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rollAgain = true;
            while (rollAgain == true)
            {
                bool invalidNum = true;
                while(invalidNum == true)
                {
                    int input = GetInput("How many sides should each die have?");
                    if (input < 1)
                    {
                        Console.WriteLine("Must be a number above 0");
                        invalidNum = true;
                    }
                    else
                    {
                        int roll1 = RandomRollDice(input);
                        int roll2 = RandomRollDice(input);
                        int[] rolls = { roll1, roll2 };

                        Console.WriteLine();
                        Console.WriteLine($"You have rolled {rolls[0]} and {rolls[1]}! ({rolls[0] + rolls[1]} total)");
                        Console.WriteLine();

                        if (input == 6)
                        {
                            GetOutput(rolls);
                        }
                        invalidNum = false;
                    }
                }
                rollAgain = RollAgain();
            }
        }

        public static int RandomRollDice(int numSide)
        {
            Random dice = new Random();
            int roll = dice.Next(1, numSide + 1);
            return roll;
        }

        public static bool GetOutput(int[] rolls)
        {
            if (rolls[0] == 1 && rolls[1] == 1)
            {
                string snakeEyes = "Snake Eyes";
                Console.WriteLine(snakeEyes);
                
            }
            else if ((rolls[0] == 1 && rolls[1] == 2) || (rolls[0] == 2 && rolls[1] == 1))
            {
                string aceDeuce = "Ace Deuce";
                Console.WriteLine(aceDeuce);
                
            }
            else if (rolls[0] == 6 && rolls[1] == 6)
            {
                string boxCars = "Box Cars";
                Console.WriteLine(boxCars);
                
            }
            else if(rolls[0] + rolls[1] == 7 || rolls[0] + rolls[1] == 11)
            {
                string win = "Win";
                Console.WriteLine(win);
                
            }
            
            if(rolls[0] + rolls[1] == 2 || rolls[0] + rolls[1] == 3 || rolls[0] + rolls[1] == 12)
            {
                string craps = "Craps!";
                Console.WriteLine(craps);
               
            }
            return false;
        }


        public static int GetInput(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static bool RollAgain()
        {
            Console.WriteLine("Would you like to roll again? Y/N ");
            string answer = Console.ReadLine();

            if (answer.ToUpper() == "Y")
            {
                Console.WriteLine("Awesome! we go on");
                return true;
            }
            else if (answer.ToUpper() == "N")
            {
                Console.WriteLine("okay bye");
                return false;
            }
            else
            {
                Console.WriteLine("Umm idk what that means");
                return RollAgain();
            } 
        }
    }
}
