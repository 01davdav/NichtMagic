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
	private WriteJson W;
	private Grave G;
	private Board B;
	
	// Use this for initialization
	void Start ()
	{
		//Initializing and Start methods
		P = Camera.main.GetComponent<Main>().MPlayer;
		R = Camera.main.GetComponent<ReadJson>();
		W = Camera.main.GetComponent<WriteJson>();
		G = Camera.main.GetComponent<Grave>();
		B = Camera.main.GetComponent<Main>().MBoard;
		P.Start();
		R.Start();
		W.Start();
		B.Start();
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

	public void MoveCardToHand(GameObject card, int c)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;

		StartCoroutine(RotateToPosition(card.transform,new Vector3(-5, -5, 0), 0));
		StartCoroutine(MoveToPosition(card.transform, new Vector3((c * 2) - 5, -(fheight / 2) + 2, -1), .5f, 1));
		Debug.Log(card.GetComponent<Card>().GetName());
		P.Hand[c] = card;
		P.Deck.Remove(P.Deck[0]);
	}

	public void MoveCardToBoard(GameObject card, float c, int position, Boolean loop)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;
		
		StartCoroutine(MoveToPosition(card.transform, new Vector3((c * 2) - 10, -(fheight / 2) + 5, -1), .5f, 1));
		Debug.Log(card.GetComponent<Card>().GetName());
		if (loop == true)
		{
			for (int i = B.BoardCards.Length; i > position + 2; i--)
			{
				B.BoardCards[i-1] = B.BoardCards[i-2];
			}
		}
		B.BoardCards[position] = card;
	}

	public void MoveCardToBoard(GameObject card, float c, int position, Boolean loop, int positionOfHandCard)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float) height;

		StartCoroutine(MoveToPosition(card.transform, new Vector3((c * 2) - 10, -(fheight / 2) + 5, -1), .5f, 1));
		Debug.Log(card.GetComponent<Card>().GetName());
		if (loop == true)
		{
			for (int i = B.BoardCards.Length; i > position + 2; i--)
			{
				B.BoardCards[i - 1] = B.BoardCards[i - 2];
			}
		}
		B.BoardCards[position] = card;
		P.Hand[positionOfHandCard] = null;
}
	
	public void MoveCardToGrave(GameObject card)
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;
		
		StartCoroutine(RotateToPosition(card.transform,new Vector3(-6, -6, 0), 0));
		StartCoroutine(MoveToPosition(card.transform, new Vector3(10.5f, -(fheight / 2) + 2, -(G.Graveyard.Count/10f)-1f), .3f, 4));
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
