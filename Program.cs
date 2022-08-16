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

        do {

        //Call start function.
        Start();
        //Call board function.
        Board();
        //Game();



        Console.Clear();

        } while (true){ 

    }


    void Start(){

        //Need to use for ReadKey to work properly, and a name for variable
        ConsoleKeyInfo userChoice;
        Console.WriteLine("Welcome to a game of Tic-Tac-Toe!\n");
        Console.ReadLine();
        Console.WriteLine("Who is the first player?: ");
        //Need questionmark because input can be null but should be sting
        string? playerName1 = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Will {playerName1} be X or O?:\n");
        //insert the choice in variable.
        userChoice = Console.ReadKey();

        if (userChoice.Key == ConsoleKey.X){
            Console.WriteLine($"{playerName1} chose X!");
            playerX = userChoice.ToString();
        }
        else if (userChoice.Key == ConsoleKey.O){
            Console.WriteLine($"{playerName1} chose O!");
            playerO = userChoice.ToString();
        }
        else {
            Console.WriteLine("Please select between X or O.");
        }
        Console.Clear();

        Console.WriteLine("Who is the second player?:");
        string? playerName2 = Console.ReadLine();

        if (userChoice.Key == ConsoleKey.X){
            Console.WriteLine($"{playerName2} is O.");
            playerO = userChoice.ToString();
            Console.WriteLine(playerO); 
        }

        else {
            Console.WriteLine($"{playerName2} is X.");
            playerX = userChoice.ToString();
            Console.WriteLine(playerX);

        }
    
}

    void Board(){
       Console.WriteLine("     |     |      ");
       Console.WriteLine($"{ticTacToeFieldArray[0]} | {ticTacToeFieldArray[1]} | {ticTacToeFieldArray[2]}");
       Console.WriteLine("_____|_____|_____ ");
       Console.WriteLine("     |     |      ");
       Console.WriteLine($"{ticTacToeFieldArray[3]} | {ticTacToeFieldArray[4]} | {ticTacToeFieldArray[5]}");
       Console.WriteLine("_____|_____|_____ ");
       Console.WriteLine("     |     |      ");
       Console.WriteLine($"{ticTacToeFieldArray[6]} | {ticTacToeFieldArray[7]} | {ticTacToeFieldArray[8]}");
       Console.WriteLine("     |     |      ");
    }

    static void Game(){
    //int containing choice or where to put token, transform string to int
    int choice = Convert.ToInt32(Console.ReadLine());

        while (true){

            if (ticTacToeFieldArray[choice] =! "-"){
            playerSelection = 1;
        }

        break;
    
    }

    }
           }
        }
    }