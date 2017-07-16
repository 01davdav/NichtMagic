using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class control : MonoBehaviour {

	List<Card> Deck = new List<Card>();
	
	// Use this for initialization
	void Start ()
	{
		for (int co = 0; co < 50; co++)
			Deck.Add( new Card(GetRandomName(), 0, 0, 0, 0));
		for (int co = 0; co < 5; co++)
		{
			Debug.Log(Deck[co].getName());
		}
		for (int i = 0; i < Deck.Count; i++) {
			Card temp = Deck[i];
			int randomIndex = Random.Range(i, Deck.Count);
			Deck[i] = Deck[randomIndex];
			Deck[randomIndex] = temp;
		}
		Debug.Log("-----Shuffled----");
		for (int co = 0; co < 5; co++)
		{
			Debug.Log(Deck[co].getName());
		}
	}
	
	private string[] names = new string[] { "Peter", "Ron", "Satchmo", "Lutti", "David", "Suvi", "Henrik", "Ubroot" };
	private string[] lnames = new string[] { "Peter", "Ron", "Satchmo", "Hrditchka", "Luckenburger", "Maximus" };
	public string GetRandomName()
	{
		String name = names[Random.Range(0, names.Length)] + " " + lnames[Random.Range(0, lnames.Length)];
		return name;
	}
	
}
