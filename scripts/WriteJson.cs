using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using LitJson;

public class WriteJson : MonoBehaviour {
	public Character Deck;
	private JsonData deckJson;
	private ReadJson R;

	public void Start()
	{
		R = Camera.main.GetComponent<ReadJson>();
	}

	// Use this for initialization
	//void Start ()
	//{
	//	deckJson = JsonMapper.ToJson(Deck);
	//	File.WriteAllText(Application.dataPath + "/other/decks.json", deckJson.ToString());
	//}
	public void addDeck(int[] i)
	{
		int[][] Decks = new int[R.CardDataDecks["Cards"].Count+1][];
		for (int c = 0; c < (Decks.Length-1); c++)
		{
			Decks[c] = R.getDeck(c);
		}
		Decks[Decks.Length - 1] = i;
		Deck = new Character(Decks);
		deckJson = JsonMapper.ToJson(Deck);
		File.WriteAllText(Application.dataPath + "/other/decks.json", deckJson.ToString());
	}

	public void setDeck(int i)
	{
		
	}
}

public class Character
{
	public int[][] Cards;

	public Character(int[][] newCards)
	{
		Cards = newCards;
	}
}