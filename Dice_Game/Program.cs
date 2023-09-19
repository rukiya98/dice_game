using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

/*
 *Name :Rukshan edirisinghe
 *Index :14635
 *Date : 2022/11/06 
 */

namespace Dice_Game
{
    internal class Game
    {
        static void Main(string[] args)
        {
            int player1_Number1;

            int player1_Number2;

            int player2_Number1;

            int player2_Number2;

            int player1_Point = 0;

            int player2_Point = 0;

            int player1_Total = 0;

            int player2_Total = 0;

            Random random = new Random();

            for (int x = 0; x < 50; x++)
            {
                Console.WriteLine("Press enter to roll the dice");
                Console.ReadKey();

                if (player1_Total >= 100)
                {
                    Console.WriteLine("*****Congartulations.. Player 1 won the game*****");
                    break;
                }
                if (player2_Total >= 100)
                {
                    Console.WriteLine("*****Congartulations.. Player 2 won the game*****");
                    break;
                }

                player1_Number1 = random.Next(1, 7);
                player1_Number2 = random.Next(1, 7);
                player1_Point = player1_Number1 + player1_Number2;
                player1_Total = player1_Total + player1_Point;

                if (player1_Number1 == player1_Number2)
                {
                    if (player1_Number1 > 1 && player1_Number2 > 1)
                    {
                        Console.WriteLine("Dice 1: " + player1_Number1);
                        Console.WriteLine("Dice 2: " + player1_Number2);
                        Console.WriteLine("Score of player 1: " + player1_Total);
                        Console.WriteLine();

                        do
                        {
                            player1_Number1 = random.Next(1, 7);
                            player1_Number2 = random.Next(1, 7);
                            player1_Point = player1_Number1 + player1_Number2;
                            player1_Total = player1_Total + player1_Point;

                            Console.WriteLine("Dice 1: " + player1_Number1);
                            Console.WriteLine("Dice 2: " + player1_Number2);

                            if (player1_Number1 == 1 && player1_Number2 == 1)
                            {
                                player1_Total = 0;
                                Console.WriteLine("Score of player 1: " + player1_Total);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Score of player 1: " + player1_Total);
                                Console.WriteLine();
                            }

                        }
                        while (player1_Number1 == player1_Number2);

                    }

                    else
                    {
                        Console.WriteLine("Dice 1: " + player1_Number1);
                        Console.WriteLine("Dice 2: " + player1_Number2);
                        player1_Total = 0;
                        Console.WriteLine("Score of player 1: " + player1_Total);
                        Console.WriteLine();

                    }

                }
                else
                {
                    Console.WriteLine("Dice 1: " + player1_Number1);
                    Console.WriteLine("Dice 2: " + player1_Number2);
                    Console.WriteLine("Score of player 1: " + player1_Total);
                    Console.WriteLine();
                }

                player2_Number1 = random.Next(1, 7);
                player2_Number2 = random.Next(1, 7);
                player2_Point = player2_Number1 + player2_Number2;
                player2_Total = player2_Total + player2_Point;

                if (player2_Number1 == player2_Number2)
                {
                    if (player2_Number1 > 1 && player2_Number2 > 1)
                    {
                        Console.WriteLine("Dice 1: " + player2_Number1);
                        Console.WriteLine("Dice 2: " + player2_Number2);
                        Console.WriteLine("Score of player 2: " + player2_Total);
                        Console.WriteLine();

                        do
                        {
                            player2_Number1 = random.Next(1, 7);
                            player2_Number2 = random.Next(1, 7);
                            player2_Point = player2_Number1 + player2_Number2;
                            player2_Total = player2_Total + player2_Point;

                            Console.WriteLine("Dice 1: " + player2_Number1);
                            Console.WriteLine("Dice 2: " + player2_Number2);

                            if (player2_Number1 == 1 && player2_Number2 == 1)
                            {
                                player2_Total = 0;
                                Console.WriteLine("Score of player 2: " + player2_Total);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Score of player 2: " + player2_Total);
                                Console.WriteLine();
                            }

                        }
                        while (player2_Number1 == player2_Number2);

                    }

                    else
                    {
                        Console.WriteLine("Dice 1: " + player2_Number1);
                        Console.WriteLine("Dice 2: " + player2_Number2);
                        player2_Total = 0;
                        Console.WriteLine("Score of player 2: " + player2_Total);
                        Console.WriteLine();

                    }

                }
                else
                {
                    Console.WriteLine("Dice 1: " + player2_Number1);
                    Console.WriteLine("Dice 2: " + player2_Number2);
                    Console.WriteLine("Score of player 2: " + player2_Total);
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
    }
}
