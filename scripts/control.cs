using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Control : MonoBehaviour {
	
	public static GameObject Handcard;
	[SerializeField]
	public GameObject Hh;
	
	// Use this for initialization
	void Start ()
	{
		Handcard = Hh;
		for (int co = 0; co < 50; co++)
		{
			Player.Deck.Add(Card.GetRandomCard());
		}
		for (int co = 0; co < 5; co++)
		{
			Debug.Log(Player.Deck[co]);
		}
		for (int i = 0; i < Player.Deck.Count; i++) {
			Card temp = Player.Deck[i];
			int randomIndex = Random.Range(i, Player.Deck.Count);
			Player.Deck[i] = Player.Deck[randomIndex];
			Player.Deck[randomIndex] = temp;
		}
		Debug.Log("-----Shuffled----");
		for (int co = 0; co < 5; co++)
		{
			Debug.Log(Player.Deck[co].GetName());
		}
		StartCoroutine(Draw5());
	}

	IEnumerator Draw5()
	{
		for (int c = 0; c < 5; c++)
		{
			yield return new WaitForSeconds(0.2f);
			Player.Draw();
		}
	}
	
	private static string[] names = new string[] { "Peter", "Ron", "Satchmo", "Lutti", "David", "Suvi", "Henrik", "Ubroot", "Patrick" };
	private static string[] lnames = new string[] { "Peter", "Ron", "Satchmo", "Hrditchka", "Luckenburger", "Maximus" };
	public static string GetRandomName()
	{
		String name = names[Random.Range(0, names.Length)] + " " + lnames[Random.Range(0, lnames.Length)];
		return name;
	}

	public static void InstantiateHandCard(Card card, int c)
	{
		Instantiate(Handcard, new Vector3(-6+(c*2), -3.3f, 0), Handcard.transform.rotation);
	}
}
