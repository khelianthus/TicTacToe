// See https://aka.ms/new-console-template for more information
using System;

namespace TicTacToe {

    public class Program
    {
        public static void Main(string[ args]){

        //Create array for the playingfield consisting of 9 places
        string[] ticTacToeFieldArray = new string[9] {"-","-","-","-","-","-","-","-","-"};
        string playfield = "";
        //Store players score.
        int playerXScore = 0;
        int playerOScore = 0;
        //Store player token, choice of token
        string? playerX = "X";
        string? playerO = "O";

        //Start.newGameStart();

        //Need to use for ReadKey to work properly, and a name for variable
        ConsoleKeyInfo userChoice;
        Console.WriteLine("Welcome to a game of Tic-Tac-Toe!\n");
        Console.ReadLine();
        Console.WriteLine("What is your name?: ");
        string? playerName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Will {playerName} be X or O?:");
        //insert the choice in variable.
        userChoice = Console.ReadKey();
    

        if (userChoice.Key == ConsoleKey.X){
            Console.WriteLine("You chose X!");
            playerX = userChoice.ToString();
        }
        else if (userChoice.Key == ConsoleKey.O){
            Console.WriteLine("You chose O!");
            playerO = userChoice.ToString();
        }
        else {
            Console.WriteLine("Please select between X or O.");
        }

        Console.Clear();

        //Call board function.
        Board();

    public static void Board()
    {
       Console.WriteLine("     |     |      ");
       Console.WriteLine("  {0}  |  {1}  |  {2}", ticTacToeFieldArray[1], ticTacToeFieldArray[2], ticTacToeFieldArray[3]);
       Console.WriteLine("_____|_____|_____ ");
       Console.WriteLine("     |     |      ");
       Console.WriteLine("  {0}  |  {1}  |  {2}", ticTacToeFieldArray[4], ticTacToeFieldArray[5], ticTacToeFieldArray[6]);
       Console.WriteLine("_____|_____|_____ ");
       Console.WriteLine("     |     |      ");
       Console.WriteLine("  {0}  |  {1}  |  {2}", ticTacToeFieldArray[7], ticTacToeFieldArray[8], ticTacToeFieldArray[9]);
       Console.WriteLine("     |     |      ");
    }

           }
        }
    }