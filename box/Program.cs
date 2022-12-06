using System;

namespace box
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxer Player = new Boxer("Player");
            Boxer Computer = new Boxer("Computer");
            for (int j = 0; j < Boxer.roundCount; j++)
            {
                Console.WriteLine($"Round {j} start");
                for (int i = 0; i < Boxer.oneRoundTime; i++)
                {
                    Console.WriteLine(new string('-', 20));
                    Player.Punch();
                    if(Boxer.computerHp == 0)
                    {
                        return;
                    }
                    Computer.Punch();
                    if (Boxer.playerHp == 0)
                        return;
                }
                if (Boxer.computerHp == 0 || Boxer.playerHp == 0)
                {
                    if (Boxer.playerHp == 0)
                        Boxer.HpZero("Player");
                    else
                        Boxer.HpZero("Computer");
                }
                else
                {
                    Console.WriteLine(new string('-', 20));
                    Boxer.RoundEnd(j, Boxer.playerHp, Boxer.computerHp);
                    Console.WriteLine(new string('-', 20));
                }
            }
            Boxer.HpMore(Boxer.playerHp, Boxer.computerHp);
        }
    }
}
