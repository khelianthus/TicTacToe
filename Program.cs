﻿using System;

namespace TicTacToe {
    public class Program
    {
        public static void Main(string[] args){

        //Create array for the playingfield consisting of 9 places, using char because we only use one character at the time in the array
        char[] playField = new char[9] {'-','-','-','-','-','-','-','-','-'};
        //string playfield = "";
        //Store players score.
        //int playerXScore = 0;
        //int playerOScore = 0;
        //Store player token, choice of token
        string? playerX = "X";
        string? playerO = "O";
        int currentPlayer = 0;

        //Call start function.
        Start(playerX, playerO);
        //Call board function, passing through char array through function
        Board(playField, Start().playerName1, Start().playerName2);
        //Game();
        Console.Clear();

    void Start(string playerX, string playerO){

        //Need to use for ReadKey to work properly, and a name for variable
        ConsoleKeyInfo userChoice = new ConsoleKeyInfo();
        Console.WriteLine("Welcome to a game of Tic-Tac-Toe!\n");
        Console.WriteLine();
        Console.WriteLine("Who is the first player?: ");
        //Need questionmark after datatype because input can be null but should be sting
        string? playerName1 = Console.ReadLine();
        Console.WriteLine($"Will {playerName1} be X or O?:\n");
        //insert the choice in variable.
        userChoice = Console.ReadKey();

        //Using KeyChar to transfer the pressed key to char, then string.
        if (userChoice.Key == ConsoleKey.X){
            Console.WriteLine($"{playerName1} chose X!");
            Console.ReadLine();
            playerX = userChoice.KeyChar.ToString();
        }
        else if (userChoice.Key == ConsoleKey.O){
            Console.WriteLine($"{playerName1} chose O!");
            Console.ReadLine();
            playerO = userChoice.KeyChar.ToString();
        }
        else {
            Console.WriteLine("Please select between X or O.");
            Console.ReadLine();
        }
        Console.Clear();

        Console.WriteLine("Who is the second player?:");
        string? playerName2 = Console.ReadLine();

        if (userChoice.Key == ConsoleKey.X){
            Console.WriteLine($"{playerName2} is O.");
            playerO = userChoice.KeyChar.ToString();
            Console.WriteLine(playerO);
            Console.ReadLine();
        }

        else {
            Console.WriteLine($"{playerName2} is X.");
            playerX = userChoice.KeyChar.ToString();
            Console.WriteLine(playerX);
            Console.ReadLine();
        }
    
    Console.Clear();

    Console.WriteLine("Who will start?");
    Console.ReadLine();

    //Array containing playersname variables
    string?[] playersPlaying = new string?[] {playerName1, playerName2};
    //Saves where the player is on the menu
    int playerMenuSelection = 0;

    if (playerMenuSelection == 0){
        Console.WriteLine(playersPlaying[0] + "←");
        Console.WriteLine(playersPlaying[1]);
        Console.ReadLine();
    }

    else if (playerMenuSelection == 1){
        Console.WriteLine(playersPlaying[0]);
        Console.WriteLine(playersPlaying[1] + "←"); 
        Console.ReadLine();

    }

    var keyPressed = Console.ReadKey();
    if (keyPressed.Key == ConsoleKey.RightArrow && playerMenuSelection != playersPlaying.Length -1){
        playerMenuSelection++;
    }
    else if (keyPressed.Key == ConsoleKey.LeftArrow && playerMenuSelection >= 1){
        playerMenuSelection--;
    }

    switch (playerMenuSelection){
        case 0:
        currentPlayer = 1;
        break;

        case 1:
        currentPlayer = 2;
        break;
    }

    Console.ReadLine();

}

    void Board(char[] playField, string playerName1, string playerName2){
        Console.WriteLine($"{playerName1}'s score:");
        Console.WriteLine($"{playerName2}'s score:");

        Console.WriteLine("     |     |      ");
        Console.WriteLine($"{playField[0]}  |  {playField[1]}  |  {playField[2]}");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"{playField[3]}  |  {playField[4]}  |  {playField[5]}");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"{playField[6]}  |  {playField[7]}  |  {playField[8]}");
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
}