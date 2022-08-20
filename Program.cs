using System;

namespace TicTacToe {
    public class Program
    {
        public static void Main(string[] args){

        //Create array for the playingfield consisting of 9 places, using char because we only use one character at the time in the array
        char[] playField = new char[9] {'-','-','-','-','-','-','-','-','-'};
        //Store player token, choice of token
        string? playerX = "";
        string? playerO = "";
        //Stores the players names
        string playerName1 ="";
        string playerName2= "";
        //Saves who's turn it is
        int currentPlayer = 0;

        //Call start function.
        Start(playerX, playerO);
        StartPlayerChoice(currentPlayer, playerName1, playerName2);
        //Call board function, passing through char array through function
        Board(playField, currentPlayer);
        //Game();

    void Start(string playerX, string playerO){

        //Need to use for ReadKey to work properly, and a name for variable
        ConsoleKeyInfo userChoice = new ConsoleKeyInfo();
        Console.WriteLine("Welcome to a game of Tic-Tac-Toe!\n");
        Console.ReadLine();
        Console.WriteLine("Who is the first player?: ");
        //Need questionmark after datatype because input can be null but should be sting
        string? playerName1 = Console.ReadLine();
        Console.Write($"Will {playerName1} be X or O?:\n");
        //insert the choice in variable.
        userChoice = Console.ReadKey();

        //Using KeyChar to transfer the pressed key to char, then string.
        if (userChoice.Key == ConsoleKey.X){
            Console.WriteLine($"{playerName1} chose X!");
            playerX = userChoice.KeyChar.ToString();
            Console.WriteLine(playerX);
            Console.Read();
        }

        else if (userChoice.Key == ConsoleKey.O){
            Console.WriteLine($"{playerName1} chose O!");
            playerO = userChoice.KeyChar.ToString();
            Console.WriteLine(playerO);
            Console.Read();
        }

        else {
            Console.WriteLine("Please select between X or O.");
            Console.Read();
        }
        Console.Clear();

        Console.WriteLine("Who is the second player?:");
        string? playerName2 = Console.ReadLine();

    //If first user chose X, second player is given O
        if (userChoice.Key == ConsoleKey.X){
            Console.WriteLine($"{playerName2} is O.");
            playerO = "O";
            Console.WriteLine(playerO);
            Console.Read();
        }

        //If first user chose O, second player is given X
        else{
            Console.WriteLine($"{playerName2} is X.");
            playerX = "X";
            Console.WriteLine(playerX);
            Console.Read();
        }
        Console.Clear();
    }

    void StartPlayerChoice (int currentPlayer, string playerName1, string playerName2){

    Console.WriteLine("Who will start?");
    Console.ReadLine();

    //Array containing playersname variables
    string?[] playersPlaying = new string?[] {playerName1, playerName2};
    //Saves where the player is on the menu
    int playerMenuSelection = 0;

    while (true) {
    Console.Clear();
    Console.CursorVisible = false;

    if (playerMenuSelection == 0){
        Console.WriteLine(playersPlaying[0] + "←");
        Console.WriteLine(playersPlaying[1]);
    }

    else if (playerMenuSelection == 1){
        Console.WriteLine(playersPlaying[0]);
        Console.WriteLine(playersPlaying[1] + "←"); 
    }

    var keyPressed = Console.ReadKey();
    if (keyPressed.Key == ConsoleKey.DownArrow && playerMenuSelection != playersPlaying.Length -1){
        playerMenuSelection++;
    }
    else if (keyPressed.Key == ConsoleKey.UpArrow && playerMenuSelection >= 1){
        playerMenuSelection--;
    }

    else if (keyPressed.Key == ConsoleKey.Enter){

    switch (playerMenuSelection){
        case 0:
        Console.WriteLine($"{playerName1} will start.");
        Console.Read();
        currentPlayer = 1;
        return;

        case 1:
        Console.WriteLine($"{playerName2} will start.");
        Console.Read();
        currentPlayer = 2;
        return;
            }
        }
    }

      }
}
    //string playerName1, string playerName2
    private static void Board(char[] playField, int currentPlayer){
        /*Console.WriteLine($"{playerName1}'s score:");
        Console.WriteLine($"{playerName2}'s score:");*/

        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {playField[0]}  |  {playField[1]}  |  {playField[2]}");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {playField[3]}  |  {playField[4]}  |  {playField[5]}");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {playField[6]}  |  {playField[7]}  |  {playField[8]}");
        Console.WriteLine("     |     |      ");

        Console.WriteLine($"It's {currentPlayer}'s turn!");
        Console.ReadLine();
    }

    /*static void Game(char[] playField){
    //int containing choice or where to put token, transform string to int
    int choice = Convert.ToInt32(Console.ReadLine());

        while (true){

            if (playField[choice] =! '-'){
            playerSelection = 1;
            }
        break;
        
        }

            }*/
        
        }
    }