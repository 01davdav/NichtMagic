using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

	private static Random rand = new Random(DateTime.Now.Second);
	List<Card> Deck = new List<Card>();
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	string GenerateName(int len)
	{
		string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
		string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
		string Name = "";
		Name += consonants[rand.Next(consonants.Length)].ToUpper();
		Name += vowels[rand.Next(vowels.Length)];
		int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
		while (b < len)
		{
			Name += consonants[rand.Next(consonants.Length)];
			b++;
			Name += vowels[rand.Next(vowels.Length)];
			b++;
		}

		return Name;
	}
}
