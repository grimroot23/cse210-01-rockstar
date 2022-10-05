using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main() 
        {
            //Board "Pieces"
            int[] board_slots = {1,2,3,4,5,6,7,8,9};
            string board_divide = "-+-+-";
            string slot1 = "1";
            string slot2 = "2";
            string slot3 = "3";
            string slot4 = "4";
            string slot5 = "5";
            string slot6 = "6";
            string slot7 = "7";
            string slot8 = "8";
            string slot9 = "9";
            //Player identities
            string player_one = "x";
            string player_two = "o";
            int one_selection;
            int two_selection;

            

            //def printBoard() {printing the Board "Pieces"}
            void board()
            {
                Console.WriteLine("");

                Console.WriteLine($"{slot1}|{slot2}|{slot3}");
                Console.WriteLine(board_divide);
                Console.WriteLine($"{slot4}|{slot5}|{slot6}");
                Console.WriteLine(board_divide);
                Console.WriteLine($"{slot7}|{slot8}|{slot9}");

                Console.WriteLine("");
            }
            //def playerSelection() {ask choice from player one}
            void player_one_selection()
            {
                Console.Write("Player one choose a number: ");
                one_selection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }
            //def playerTwoSelection() {ask choice from player one}
            void player_two_selection()
            {
                Console.Write("Player two choose a number: ");
                two_selection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }
            //def playerOneTurn
            void player_one_turn() 
            {
                for (int i = 0;  i < board_slots.Length; i++)
                {
                    if (one_selection == board_slots[0])
                    {
                        slot1 = "x";
                    }
                    else if (one_selection == board_slots[1])
                    {
                        slot2 = "x";
                    }
                    else if (one_selection == board_slots[2])
                    {
                        slot3 = "x";
                    }
                    else if (one_selection == board_slots[3])
                    {
                        slot4 = "x";
                    }
                    else if (one_selection == board_slots[4])
                    {
                        slot5 = "x";
                    }
                    else if (one_selection == board_slots[5])
                    {
                        slot6 = "x";
                    }
                    else if (one_selection == board_slots[6])
                    {
                        slot7 = "x";
                    }
                    else if (one_selection == board_slots[7])
                    {
                        slot8 = "x";
                    }
                    else if (one_selection == board_slots[8])
                    {
                        slot9 = "x";
                    }

                    
                }
            }
            //def playerTwoTurn
            void player_two_turn() 
            {
                for (int i = 0;  i < board_slots.Length; i++)
                {
                    if (two_selection == board_slots[0])
                    {
                        slot1 = "o";
                    }
                    else if (two_selection == board_slots[1])
                    {
                        slot2 = "o";
                    }
                    else if (two_selection == board_slots[2])
                    {
                        slot3 = "o";
                    }
                    else if (two_selection == board_slots[3])
                    {
                        slot4 = "o";
                    }
                    else if (two_selection == board_slots[4])
                    {
                        slot5 = "o";
                    }
                    else if (two_selection == board_slots[5])
                    {
                        slot6 = "o";
                    }
                    else if (two_selection == board_slots[6])
                    {
                        slot7 = "o";
                    }
                    else if (two_selection == board_slots[7])
                    {
                        slot8 = "o";
                    }
                    else if (two_selection == board_slots[8])
                    {
                        slot9 = "o";
                    }

                    
                }
            }

            
            //Welcome Banner
            Console.WriteLine("Welcome to TicTacToe");
            //Show Board
            board();
            //List player identities
            Console.WriteLine($"Player one is '{player_one}' and Player two is '{player_two}'");
            Console.WriteLine("");

            //Call playerOneSelection()
            player_one_selection();
            //Call playerOneTurn
            player_one_turn();
            //Show Board New
            board();

            //Call playerTwoSelection()
            player_two_selection();
            //Call playerTwoTurn
            player_two_turn();
            //Show Board New
            board();
        }
    }
}