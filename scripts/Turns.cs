using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns{

	public static void Turn()
	{
		//start of turn
		
		Hero.AddMaxMana(1); //increment maxmana
		Hero.SetMana(Hero.GetMaxMana()); //set the mana of the hero to thei maxmana
		Player.Draw(); //draw a card
		
		
		
		//end of turn
		
		foreach (Card c in Board.BoardCards) //set shield back to max value
		{
			if (c != null && c.GetCurrentShield() > 0)
			{
				c.SetCurrentShield(c.GetShield());
			}
		}
	}
	

}
