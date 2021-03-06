﻿using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player
{

	//Initializing
	public GameObject[] Hand = new GameObject[6];
	public List<GameObject> Deck = new List<GameObject>();

	private Control C;


	public void Start()
	{
		C = Camera.main.GetComponent<Control>();
	}
	
	//Drawing the first five cards
	public IEnumerator Draw4()
	{
		for (int c = 0; c < 4; c++)
		{
			yield return new WaitForSeconds(0.2f);
			Draw(1);
		}
	}
	
	//Method for drawing a card
	public void Draw(int i)
	{
		for (int j = 0; j < i; j++)
		{
			for (int c = 0; c < 7; c++)
			{
				if (c == 6)
				{
					C.MoveCardToGrave(Deck[0]);
					break;
				}
				if (Hand[c] == null)
				{
					C.MoveCardToHand(Deck[0], c);
					break;
				}
			}
			C.Pop();
		}
	}
	
	
	public int[] getDeckIds()
	{
		int[] deckIds = new int[Deck.Count];
		for (int c = 0; c < deckIds.Length; c++)
		{
			deckIds[c] = Deck[c].GetComponent<Card>().GetId();
		}
		return deckIds;
	}
}
