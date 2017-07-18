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
	private Grave G;
	private Board B;
	
	// Use this for initialization
	void Start ()
	{
		//Initializing and Start methods
		P = Camera.main.GetComponent<Main>().MPlayer;
		R = Camera.main.GetComponent<ReadJson>();
		G = Camera.main.GetComponent<Grave>();
		P.Start();
		R.Start();
		//get 50 random cards [only for testing]
		for (int co = 0; co < 50; co++)
		{
			GameObject thisCard = Instantiate(PreCard, new Vector3(7.91f, -2.31f, -.1f), Quaternion.Euler(0, 180, 90));
			R.GetCard(thisCard,Random.Range(0, R.CardDataCards["Cards"].Count));
			P.Deck.Add(thisCard);
			if(thisCard.GetComponent<Card>().GetPath() != "path")
				thisCard.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(thisCard.GetComponent<Card>().GetPath());
		}
		//Shuffling the Deck
		for (int i = 0; i < P.Deck.Count; i++) {
			GameObject temp = P.Deck[i];
			int randomIndex = Random.Range(i, P.Deck.Count);
			P.Deck[i] = P.Deck[randomIndex];
			P.Deck[randomIndex] = temp;
		}
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

	public void MoveCardToHand(GameObject card, int c)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;

		StartCoroutine(RotateToPosition(card.transform,new Vector3(-3, -3, 0), 0));
		StartCoroutine(MoveToPosition(card.transform, new Vector3((c * 2) - 5, -(fheight / 2) + 2, -1), .5f, 1));
		Debug.Log(card.GetComponent<Card>().GetName());
		P.Hand[c] = card;
		P.Deck.Remove(P.Deck[0]);
	}
	
	public void MoveCardToGrave(GameObject card)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;
		
		StartCoroutine(RotateToPosition(card.transform,new Vector3(-3, -3, 0), 0));
		StartCoroutine(MoveToPosition(card.transform, new Vector3(10.5f, -(fheight / 2) + 2, -(G.Graveyard.Count/10f)-1f), .5f, 4));
		Debug.Log(card.GetComponent<Card>().GetName());
		G.Graveyard.Add(card);
		P.Deck.Remove(P.Deck[0]);
		G.Pop();
	}
	
	public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove, float back)
	{
		var currentPos = transform.position;
		var t = 0f;
		while(t < 1)
		{
			t += Time.deltaTime / timeToMove;
			transform.position = Vector3.Lerp(currentPos, position, t);
			yield return null;
		}	
		t = 0f;
		while(t < 1)
		{
			t += Time.deltaTime / 0.1f;
			transform.position = Vector3.Lerp(position, position+new Vector3(0,0,back), t);
			yield return null;
		}
	}
	
	public IEnumerator RotateToPosition(Transform transform,Vector3 axis, int to)
	{
		while(transform.rotation.y > to)
		{
			transform.Rotate (axis);
			yield return null;
		}
		transform.rotation = Quaternion.Euler(0, 0, 0);
	}
	
	[SerializeField]
	private UnityEngine.UI.Text _counter;
	
	public void Pop()
	{
		_counter.text = P.Deck.Count.ToString();
	}
}
