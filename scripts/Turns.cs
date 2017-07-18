using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour {

	private Player P;
	private Hero H;
	private Board B;

	private void Start()
	{
		Player P = Camera.main.GetComponent<Main>().MPlayer;
		Hero H = Camera.main.GetComponent<Hero>();
		Board B = Camera.main.GetComponent<Main>().MBoard;
	}

	public void Turn()
	{
		//start of turn
		
		H.AddMaxMana(1); //increment maxmana
		H.SetMana(H.GetMaxMana()); //set the mana of the hero to thei maxmana
		P.Draw(); //draw a card
		
		
		
		//end of turn
		
		foreach (Card c in B.BoardCards) //set shield back to max value
		{
			if (c != null && c.GetCurrentShield() > 0)
			{
				c.SetCurrentShield(c.GetShield());
			}
		}
	}
	

}
