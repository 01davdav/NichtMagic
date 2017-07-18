using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Random = UnityEngine.Random;

public class Control : MonoBehaviour {
	
	//Initializing the handcard obj
	public GameObject PreCard;

	private Player P;
	private ReadJson R;
	
	// Use this for initialization
	void Start ()
	{
		//Initializing and Start methods
		P = Camera.main.GetComponent<Main>().MPlayer;
		R = Camera.main.GetComponent<Main>().MReadJson;
		P.Start();
		R.Start();
		//get 50 random cards [only for testing]
		for (int co = 0; co < 50; co++)
		{
			GameObject thisCard = Instantiate(PreCard, new Vector3(7.91f, -2.31f, -1f), PreCard.transform.rotation);
			P.GetRandomCard(thisCard);
			P.Deck.Add(thisCard);
		}
		//Shuffling the Deck
		for (int i = 0; i < P.Deck.Count; i++) {
			GameObject temp = P.Deck[i];
			int randomIndex = Random.Range(i, P.Deck.Count);
			P.Deck[i] = P.Deck[randomIndex];
			P.Deck[randomIndex] = temp;
		}
		R.GetCard(P.Deck[0],0);
		R.GetCard(P.Deck[1],1);
		for (int c = 49; c >= 0; c--)
		{
			Debug.Log(P.Deck[c].GetComponent<Card>().GetName());
		}
		Debug.Log("--------");
		//Drawing the first four cards
		StartCoroutine(P.Draw4());
	}
	
	//random name generator [for testing]
	private string[] names = new string[] { "Peter", "Ron", "Satchmo", "Lutti", "David", "Suvi", "Henrik", "Ubroot", "Patrick" };
	private string[] lnames = new string[] { "Peter", "Ron", "Satchmo", "Hrditchka", "Luckenburger", "Maximus" };
	public string GetRandomName()
	{
		String name = names[Random.Range(0, names.Length)] + " " + lnames[Random.Range(0, lnames.Length)];
		return name;
	}

	public void MoveCard(GameObject card, int c)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;

		if(card.GetComponent<Card>().GetPath() != "path")
			card.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(card.GetComponent<Card>().GetPath());
		card.transform.localPosition = new Vector3((c * 2) - 5, -(fheight / 2) + 2, 0);
		Debug.Log(card.GetComponent<Card>().GetName());
		P.Hand[c] = card;
		P.Deck.Remove(P.Deck[0]);
	}
}
