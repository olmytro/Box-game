using System;
using System.Collections.Generic;
using System.Text;

namespace box
{
    public class Boxer
    {
        public string name;
        static public int playerHp = 10;
        static public int computerHp = 10;
        static public bool status = true;
        static public int roundCount = 3;
        static public int oneRoundTime = 5;

        public Boxer(string Name)
        {
            this.name = Name;
        }

        private bool ChanceOfPunch()
        {
            Random rnd = new Random();
            int generateChance = rnd.Next(1, 10);
            if (generateChance % 2 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void Punch()
        {

            Console.WriteLine($"{name} замахивается");
            if (ChanceOfPunch() == true)
            {
                Console.WriteLine("попал");
                if (this.name == "Player")
                {
                    Bobo("Computer");
                }
                else
                {
                    Bobo("Player");
                }
            }
            else 
            {
                Console.WriteLine("промазал");
            }  
        }
        public static int Bobo(string boxer)
        {
            if (boxer == "Computer")
            {
                Console.WriteLine("Computer missed the punch");
                return computerHp--;
            }
            else
            {
                Console.WriteLine("Player missed the punch");
                return playerHp--;
            }
                
        }
        public static void HpZero(string hp)
        {
            if(hp == "Player")
            Console.WriteLine("The Player doesn't have hp. The Player lost");
            else
                Console.WriteLine("The Computer doesn't have hp. The Computer lost");
        }
        public static void RoundEnd(int round, int playerHp, int computerHp)
        {
            Console.WriteLine($"Round {round} end");
            Console.WriteLine($"Player hp is: {playerHp}");
            Console.WriteLine($"Computer hp is: {computerHp}");   
        }
        public static void HpMore(int playerHp, int computerHp)
        {
            Console.WriteLine("Result.");
            if (playerHp > computerHp)
                Console.WriteLine("The Player has more hp and win!");
            else if(playerHp == computerHp)
                Console.WriteLine("There is Draw!");
            else
                Console.WriteLine("The Computer has more hp and win!");
        }
    }
}
