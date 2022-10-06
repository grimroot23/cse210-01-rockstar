using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] choices = {'1', '2', '3', '4', '5', '6', '7' ,'8', '9'};

            string win = "no";

            char turn = 'o';

            do {
                // Determines whether to place x or o
                if (turn == 'x') {
                    turn = 'o';
                }
                else {
                    turn = 'x';
                }

                // Creates Board
                Console.Write($"{choices[0]}|{choices[1]}|{choices[2]}\n-+-+-\n{choices[3]}|{choices[4]}|{choices[5]}\n-+-+-\n{choices[6]}|{choices[7]}|{choices[8]}");

                Console.WriteLine();

                Console.WriteLine($"{turn}'s turn to choose a square (1-9)");

                // Gets selection from user
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine();
                
                // Determines which square to replace
                choices[choice - 1] = turn;

                // Determines if game has been won
                if ( (choices[0] == turn && choices[1] == turn && choices[2] == turn) || (choices[3] == turn && choices[4] == turn && choices[5] == turn) || (choices[6] == turn && choices[7] == turn && choices[8] == turn) || (choices[0] == turn && choices[3] == turn && choices[6] == turn) || (choices[1] == turn && choices[4] == turn && choices[7] == turn) || (choices[2] == turn && choices[5] == turn && choices[8] == turn) || (choices[0] == turn && choices[4] == turn && choices[8] == turn) || (choices[2] == turn && choices[4] == turn && choices[6] == turn)) {
                    win = "yes";
                    Console.WriteLine($"{turn} won the game!!!");
                }

            } while (win == "no");

        }
    }
}





