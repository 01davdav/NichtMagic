using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns
{

	private Player P;
	private Hero H;
	private Board B;
	private Control C;

	public void TStart()
	{
		P = Camera.main.GetComponent<Main>().MPlayer;
		H = Camera.main.GetComponent<Main>().MHero;
		B = Camera.main.GetComponent<Main>().MBoard;
		C = Camera.main.GetComponent<Control>();
	}

	public void Turn()
	{
		//start of turn
		
		H.AddMaxMana(1); //increment maxmana
		H.SetMana(H.GetMaxMana()); //set the mana of the hero to thei maxmana
		P.Draw(); //draw a card
		C.UpdateMana();
		
		
		
		//end of turn
		
		foreach (GameObject c in B.BoardCards) //set shield back to max value
		{
			if (c != null && c.GetComponent<Card>().GetCurrentShield() > 0)
			{
				c.GetComponent<Card>().SetCurrentShield(c.GetComponent<Card>().GetShield());
			}
		}
	}
	

}
