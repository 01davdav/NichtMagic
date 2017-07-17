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
		return new Card((string)_cardData["Cards"][id]["name"],(int)_cardData["Cards"][id]["cost"],(int)_cardData["Cards"][id]["attack"],(int)_cardData["Cards"][id]["life"],(int)_cardData["Cards"][id]["shield"],(string)_cardData["Cards"][id]["path"]);
	}
}
