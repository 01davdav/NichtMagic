using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using LitJson;

public class ReadJson
{
	private static string _jsonString = File.ReadAllText(Application.dataPath + "/other/cards.json");
	private static JsonData _cardData = JsonMapper.ToObject(_jsonString);
	

	public static Card GetCard(int id)
	{
		return new Card((string)_cardData["Cards"][0]["name"],(int)_cardData["Cards"][0]["cost"],(int)_cardData["Cards"][0]["attack"],(int)_cardData["Cards"][0]["life"],(int)_cardData["Cards"][0]["shield"],(string)_cardData["Cards"][0]["path"]);
	}
}
