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
	[SerializeField]
	public GameObject Hh;
	
	public Texture2D test;
	[SerializeField] 
	public Texture2D tt;
	
	// Use this for initialization
	void Start ()
	{
		//set handcard gameobject
		PreCard = Hh;
		test = tt;
		//get 50 random cards [only for testing]
		for (int co = 0; co < 50; co++)
		{
			GameObject thisCard = Instantiate(PreCard);
			Player.Deck.Add(thisCard);
		}
		Player.Deck[23].GetComponent<Card>().SetName("Hernals");
		for (int c = 0; c < 50; c++)
		{
			Debug.Log(Player.Deck[c].GetComponent<Card>().GetName());
		}
		//Shuffling the Deck
		for (int i = 0; i < Player.Deck.Count; i++) {
			GameObject temp = Player.Deck[i];
			int randomIndex = Random.Range(i, Player.Deck.Count);
			Player.Deck[i] = Player.Deck[randomIndex];
			Player.Deck[randomIndex] = temp;
		}
		//Drawing the first four cards
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
	private string[] names = new string[] { "Peter", "Ron", "Satchmo", "Lutti", "David", "Suvi", "Henrik", "Ubroot", "Patrick" };
	private string[] lnames = new string[] { "Peter", "Ron", "Satchmo", "Hrditchka", "Luckenburger", "Maximus" };
	public string GetRandomName()
	{
		String name = names[Random.Range(0, names.Length)] + " " + lnames[Random.Range(0, lnames.Length)];
		return name;
	}

	public void InstantiateHandCard(GameObject card, int c)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;
		GameObject myCard = Instantiate(PreCard, new Vector3((c*2)-5, -(fheight/2)+2, 0), PreCard.transform.rotation);
		myCard = card;
		Debug.Log(myCard.GetComponent<Card>().GetName());
		Player.Hand[c] = myCard;
	}
	
	public void InstantiateCard(GameObject card)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;
		GameObject myCard = Instantiate(PreCard);
		myCard = card;
	}
}
