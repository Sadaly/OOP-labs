using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Queue deck = new Queue();
            deck.SetLenght(10);
            for (int i = 0; i < 10; i++)
            {
                bool trigger = false;
                do
                {
                    deck.array[i] = rand.Next(0, 10);
                    for (int j = 0; j < i; j++)
                        if (deck.array[j] == deck.array[i])
                        {
                            trigger = true; break;
                        }
                        else
                            trigger = false;
                }while (trigger);
            }
            for (int i = 0; i < 10; i++)
                Console.Write(deck.array[i]+"\t");
            Queue player1 = new Queue();
            player1.SetLenght(5);
            Queue player2 = new Queue();
            player2.SetLenght(5);
            if (rand.Next(0, 1)>0)
                for (int i = 0; i < 5; i++)
                {
                    player1.array[i] = deck.Take(false);
                    player2.array[i] = deck.Take(false);
                }
            else
                for (int i = 0; i < 5; i++)
                {
                    player2.array[i] = deck.Take(false);
                    player1.array[i] = deck.Take(false);
                }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
                Console.Write(player1.array[i] + "\t");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
                Console.Write(player2.array[i] + "\t");
            Console.WriteLine();
            while ((!player1.Empty() && !player2.Empty()))
            {
            if (player1.Pop() == 0 && player2.Pop() == 9)
                {
                    Console.WriteLine(player1.Pop() + " " + player2.Pop());
                    player1.Add(player2.Take(true));
                    player1.Add(player1.Take(true));
                }
                else if (player2.Pop() == 0 && player1.Pop() == 9)
                {
                    Console.WriteLine(player1.Pop() + " " + player2.Pop());
                    player2.Add(player1.Take(true));
                    player2.Add(player2.Take(true));
                }
                else if (player2.Pop() > player1.Pop())
                {
                    Console.WriteLine(player1.Pop() + " " + player2.Pop());
                    player2.Add(player1.Take(true));
                    player2.Add(player2.Take(true));
                }
                else if (player1.Pop() > player2.Pop())
                {
                    Console.WriteLine(player1.Pop() + " " + player2.Pop());
                    player1.Add(player2.Take(true));
                    player1.Add(player1.Take(true));
                }
                
            }
            if (player1.Empty())
                Console.WriteLine("Player 2 win");
            if (player2.Empty())
                Console.WriteLine("Player 1 win");
        }
    }
}
