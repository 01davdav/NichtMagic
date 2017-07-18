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

	private Control C;


	public void Start()
	{
		if (C == null)
		{
			C = Camera.main.GetComponent<Control>();
		}
	}
	
	//Drawing the first five cards
	public IEnumerator Draw4()
	{
		for (int c = 0; c < 4; c++)
		{
			yield return new WaitForSeconds(0.2f);
			Draw();
		}
	}
	
	//Method for drawing a card
	public void Draw()
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
				C.MoveCardToHand(Deck[0],c);
				break;
			}
		}
	}
	
	//for testing
	public void GetRandomCard(GameObject card)
	{
		card.GetComponent<Card>().SetCard(C.GetRandomName(), 0, 0, 0, 0, "path");
	}
}
