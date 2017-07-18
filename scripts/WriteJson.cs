using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using LitJson;

public class WriteJson : MonoBehaviour {
	public Character Deck = new Character(new int[]{0,0,0,0,0,1,1,1});
	private JsonData deckJson;
	
	
	// Use this for initialization
	//void Start ()
	//{
	//	deckJson = JsonMapper.ToJson(Deck);
	//	File.WriteAllText(Application.dataPath + "/other/decks.json", deckJson.ToString());
	//}
}

public class Character
{
	public int[] cards;

	public Character(int[] newCards)
	{
		cards = newCards;
	}
}