using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using LitJson;

public class ReadJson : MonoBehaviour
{
	public string JsonStringCards;
	public JsonData CardDataCards;
	public string JsonStringDecks;
	public JsonData CardDataDecks;
	
	private Control C;
	private Player P;

	public void Start()
	{
		C = Camera.main.GetComponent<Control>();
		P = Camera.main.GetComponent<Main>().MPlayer;
		JsonStringCards = File.ReadAllText(Application.dataPath + "/other/cards.json");
		CardDataCards = JsonMapper.ToObject(JsonStringCards);
		JsonStringDecks = File.ReadAllText(Application.dataPath + "/other/decks.json");
		CardDataDecks = JsonMapper.ToObject(JsonStringDecks);
	}
	
	public void GetCard(GameObject card,int id)
	{
		card.GetComponent<Card>().SetCard((string) CardDataCards["Cards"][id]["name"], (int) CardDataCards["Cards"][id]["cost"],
			(int) CardDataCards["Cards"][id]["attack"], (int) CardDataCards["Cards"][id]["life"], (int) CardDataCards["Cards"][id]["shield"],
			(string) CardDataCards["Cards"][id]["path"]);
	}

	public void LoadDeck(List<GameObject> deck, int id)
	{
		deck.Clear();
		for (int c = 0; c < CardDataDecks["Decks"][id].Count; c++)
		{
			GameObject thisCard = Instantiate(C.PreCard, new Vector3(7.91f, -2.31f, -.1f), Quaternion.Euler(0,180,90));
			GetCard(thisCard, (int)CardDataDecks["Decks"][id]["Cards"][c]);
			P.Deck.Add(thisCard);
			if(thisCard.GetComponent<Card>().GetPath() != "path")
				thisCard.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(thisCard.GetComponent<Card>().GetPath());
		}
	}
}
