using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player
{

	//Initializing
	public GameObject[] Hand = new GameObject[6];
	public List<GameObject> Deck = new List<GameObject>();

	//Method for drawing a card
	public void Draw()
	{
		for (int c = 0; c < 7; c++)
		{
			if (c == 6)
			{
				Grave.Graveyard.Add(Deck[0]);
				Deck.Remove(Deck[0]);
				break;
			}
			if (Hand[c] == null)
			{
				Control.InstantiateHandCard(Deck[0],c);
				Deck.Remove(Deck[0]);
				break;
			}
		}
	}
	
	//for testing
	public void GetRandomCard(GameObject card)
	{
		card.GetComponent<Card>().SetCard(Control.GetRandomName(), 0, 0, 0, 0, "path");
	}
}
