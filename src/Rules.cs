using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using SwinGameSDK;


public class Rules
{
	public Rules ()
	{
		Console.WriteLine ("Basic gameplay of Battleship");
		Console.WriteLine ("Players take turns firing shots (by calling out a grid coordinate) to attack enemy ships." +
						   "\n\nOn your turn, call out a letter and a number that identifies a row and column on your target grid. Your opponent checks that coordinate on his ocean grid and verbally responds \"miss\" if there is no ship there, or \"hit\" if you have correctly guessed a space that is occupied by one of his ships." +
						   "\n\nMark each of your shots (guesses) on your upper target grid using white pegs to document your misses and red pegs to register your hits. As the game proceeds, the red pegs will gradually identify the size and location of your opponent's ships.\n\nWhen it is your opponent's turn to fire shots at you, each time one of your ships receives a hit, put a red peg into the hole on the ship corresponding to the grid space. When one of your ships has every slot filled with red pegs, you must announce to your opponent that he has sunk your ship. In classic play, the phrase used is \"You sunk my battleship!\" It is, of course, illegal to change the position of the ships on the board once play has begun. " +
						   "\n\nThe first player to sink all five of his opponent's ships wins the game.");
	}
}

