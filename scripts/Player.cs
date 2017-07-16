using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{

	public Card[] hand = new Card[6];
	[SerializeField]
	public GameObject handcard;
	
	// Use this for initialization
	void Start () 
	{
		StartCoroutine (draw5());
	}

	IEnumerator draw5()
	{
		for (int c = 0; c < 5; c++)
		{
			yield return new WaitForSeconds(0.2f);
			draw();
		}
	}

	public void draw()
	{
		for (int c = 0; c < 6; c++)
		{
			if (c == 5)
			{
				control.Deck.Remove(control.Deck[0]);
				break;
			}
			if (hand[c] == null)
			{
				hand[c] = control.Deck[0];
				Debug.Log(hand[c]);
				Instantiate(handcard, new Vector3(-6+(c*2), -3.3f, 0), transform.rotation);
				control.Deck.Remove(control.Deck[0]);
				break;
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
