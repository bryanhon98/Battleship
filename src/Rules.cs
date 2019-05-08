using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using SwinGameSDK;


public class Rules
{
	private const int INST_LEFT = 10;

	public static void HandleInstruction ()
	{
		if (SwinGame.MouseClicked (MouseButton.LeftButton) || SwinGame.KeyTyped (KeyCode.vk_ESCAPE) || SwinGame.KeyTyped (KeyCode.vk_RETURN)) {
			GameController.EndCurrentState ();
		}	}
	public static void DrawInstruction ()
	{
		const int INST_TOP = 80;
		const int INST_HEADING = 40;
		SwinGame.DrawText ("Basic gameplay of Battleship", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_HEADING);
		SwinGame.DrawText ("- Players take turns firing shots (by clicking on the tiles) to attack opponent's battleships.", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP);
		SwinGame.DrawText ("- On player's turn, click to fire on the tiles that player think opponent might placed their", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 20);
		SwinGame.DrawText ("  battleships at.", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 35);
		SwinGame.DrawText ("- If the tiles that player fired is where opponent placed their battleships at, player will hence", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 55);
		SwinGame.DrawText ("  get another round at firing.", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 70);
		SwinGame.DrawText ("- But if player did'nt fire at the tiles that the opponent placed, then it will then be opponent's", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 90);
		SwinGame.DrawText ("  turn.", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 105);
		SwinGame.DrawText ("- Tiles that player destroyed will be coloured with red.", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 125);
		SwinGame.DrawText ("- Tiles that player did'nt destroy will be coloured with blue.", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 145);
		SwinGame.DrawText ("- Winner is pick by whichever player that destroy all the opponent's battleships first.", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 165);
		SwinGame.DrawText ("- So basically the player to sink all five of his opponent's battleships wins the game.", Color.White, GameResources.GameFont ("Courier"), INST_LEFT, INST_TOP + 185);	}

	public static void ViewInstruction ()
	{

		GameController.AddNewState (GameState.ViewingInstruction);
		UtilityFunctions.DrawBackground ();
		DrawInstruction ();
	}
}

