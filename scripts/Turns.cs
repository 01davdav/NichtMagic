﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns
{

	private Player P;
	private Hero H;
	private Board B;

	public void TStart()
	{
		Player P = Camera.main.GetComponent<Main>().MPlayer;
		Hero H = Camera.main.GetComponent<Main>().MHero;
		Board B = Camera.main.GetComponent<Main>().MBoard;
	}

	public void Turn()
	{
		//start of turn
		
		H.AddMaxMana(1); //increment maxmana
		H.SetMana(H.GetMaxMana()); //set the mana of the hero to thei maxmana
		P.Draw(); //draw a card
		
		
		
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
