using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using LitJson;

public class ReadJson
{
	private string _jsonString;
	private JsonData _cardData;

	public void Start()
	{
		_jsonString = File.ReadAllText(Application.dataPath + "/other/cards.json");
		_cardData = JsonMapper.ToObject(_jsonString);
	}
	
	public void GetCard(GameObject card,int id)
	{
		card.GetComponent<Card>().SetCard((string) _cardData["Cards"][id]["name"], (int) _cardData["Cards"][id]["cost"],
			(int) _cardData["Cards"][id]["attack"], (int) _cardData["Cards"][id]["life"], (int) _cardData["Cards"][id]["shield"],
			(string) _cardData["Cards"][id]["path"]);
	}
}
