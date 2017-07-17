using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player
{

	public static Card[] Hand = new Card[6];
	public static List<Card> Deck = new List<Card>();

	public static void Draw()
	{
		for (int c = 0; c < 6; c++)
		{
			if (c == 5)
			{
				Deck.Remove(Deck[0]);
				break;
			}
			if (Hand[c] == null)
			{
				Hand[c] = Deck[0];
				Debug.Log(Hand[c]);
				Control.InstantiateHandCard(Hand[c],c);
				Deck.Remove(Deck[0]);
				break;
			}
		}
		
	}
}
