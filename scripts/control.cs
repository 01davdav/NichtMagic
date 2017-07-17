using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Random = UnityEngine.Random;

public class Control : MonoBehaviour {
	
	//Initializing the handcard obj
	public static GameObject Handcard;
	[SerializeField]
	public GameObject Hh;
	
	// Use this for initialization
	void Start ()
	{
		//set handcard gameobject
		Handcard = Hh;
		//get 50 random cards [only for testing]
		for (int co = 0; co < 50; co++)
		{
			Player.Deck.Add(Card.GetRandomCard());
		}
		//debug first cards
		for (int co = 0; co < 5; co++)
		{
			Debug.Log(Player.Deck[co]);
		}
		//Shuffling the Deck
		for (int i = 0; i < Player.Deck.Count; i++) {
			Card temp = Player.Deck[i];
			int randomIndex = Random.Range(i, Player.Deck.Count);
			Player.Deck[i] = Player.Deck[randomIndex];
			Player.Deck[randomIndex] = temp;
		}
		//Drawing the first five cards
		StartCoroutine(Draw4());
	}

	//Drawing the first five cards
	IEnumerator Draw4()
	{
		for (int c = 0; c < 4; c++)
		{
			yield return new WaitForSeconds(0.2f);
			Player.Draw();
		}
	}
	
	//random name generator [for testing]
	private static string[] names = new string[] { "Peter", "Ron", "Satchmo", "Lutti", "David", "Suvi", "Henrik", "Ubroot", "Patrick" };
	private static string[] lnames = new string[] { "Peter", "Ron", "Satchmo", "Hrditchka", "Luckenburger", "Maximus" };
	public static string GetRandomName()
	{
		String name = names[Random.Range(0, names.Length)] + " " + lnames[Random.Range(0, lnames.Length)];
		return name;
	}

	public static void InstantiateHandCard(Card card, int c, String tag)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;
		GameObject myHandcard = Instantiate(Handcard, new Vector3((c*2)-5, -(fheight/2)+2, 0), Handcard.transform.rotation);
		myHandcard.tag = tag;
	}
}
