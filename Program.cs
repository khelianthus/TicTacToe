using System;

namespace TicTacToe {
    public class Program
    {
        public static void Main(string[] args){

        //Create array for the playingfield consisting of 9 places
        string[] ticTacToeFieldArray = new string[9] {"-","-","-","-","-","-","-","-","-"};
        //string playfield = "";
        //Store players score.
        int playerXScore = 0;
        int playerOScore = 0;
        //Store player token, choice of token
        string? playerX = "X";
        string? playerO = "O";

        //Call start function.
        Start();
        //Call board function.
        Board();

    void Start(){

        //Need to use for ReadKey to work properly, and a name for variable
        ConsoleKeyInfo userChoice;
        Console.WriteLine("Welcome to a game of Tic-Tac-Toe!\n");
        Console.ReadLine();
        Console.WriteLine("What is your name?: ");
        //Need questionmark because input can be null but should be sting
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
}

    void Board(){
       Console.WriteLine("     |     |      ");
       Console.WriteLine("  {0}  |  {1}  |  {2}", ticTacToeFieldArray[0], ticTacToeFieldArray[1], ticTacToeFieldArray[2]);
       Console.WriteLine("_____|_____|_____ ");
       Console.WriteLine("     |     |      ");
       Console.WriteLine("  {0}  |  {1}  |  {2}", ticTacToeFieldArray[3], ticTacToeFieldArray[4], ticTacToeFieldArray[5]);
       Console.WriteLine("_____|_____|_____ ");
       Console.WriteLine("     |     |      ");
       Console.WriteLine("  {0}  |  {1}  |  {2}", ticTacToeFieldArray[6], ticTacToeFieldArray[7], ticTacToeFieldArray[8]);
       Console.WriteLine("     |     |      ");
    }

           }
        }
    }