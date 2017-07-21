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


	[SerializeField]
	private AnimationCurve _animationCurve;
	
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
			thisCard.GetComponent<Card>().UpdateTM();
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

		P.Hand[c] = card;
		P.Deck.Remove(P.Deck[0]);
		
		StartCoroutine(RotateToPosition(card.transform,new Vector3(-5, -5, 0), 0));
		UpdateHand();
	}
	
	public void MoveToBoard(GameObject card, int c)
	{
		if (B.BoardCards[c] == null)
		{
			B.BoardCards[c] = card;
			P.Hand[System.Array.IndexOf(P.Hand, card)] = null;
		}
		else
		{
			GameObject a = B.BoardCards[c];
			GameObject b = card;
			for (int i = c; i < (B.BoardCards.Length-1); i++)
			{
				B.BoardCards[i] = b;
				b = a;
				a = B.BoardCards[i + 1];
			}
			P.Hand[System.Array.IndexOf(P.Hand, card)] = null;
		}
		
		UpdateBoard();
		UpdateHand();
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

	public void UpdateHand()
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;

		Boolean cont = false;
		do
		{
			cont = false;
			for (int c = (P.Hand.Length - 1); c > 0; c--)
			{
				if (P.Hand[c] != null && P.Hand[c - 1] == null)
				{
					P.Hand[c - 1] = P.Hand[c];
					P.Hand[c] = null;
					cont = true;
				}
			}
		} while (cont);
		int aoc = 0;
		for (aoc = 0; aoc < P.Hand.Length; aoc++)
		{
			if (P.Hand[aoc] == null)
				break;
		}
		
		for (int i = 0; i < aoc; i++)
		{
			StartCoroutine(MoveToPosition(P.Hand[i].transform, new Vector3((i * 2) - (aoc-1), -(fheight / 2) + 2, -2), .5f, 0));
		}
		
	}
	public void UpdateBoard()
	{
		double height = Camera.main.orthographicSize * 2.0;
		float fheight = (float)height;
		
		int aoc = 0;
		for (aoc = 0; aoc < B.BoardCards.Length; aoc++)
		{
			if (B.BoardCards[aoc] == null)
				break;
		}
		
		for (int i = 0; i < aoc; i++)
		{
			StartCoroutine(MoveToPosition(B.BoardCards[i].transform, new Vector3((i * 2) - (aoc-1), -(fheight / 2) + 5, -2), .5f, 2));
		}
	}
	
	public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove, float back)
	{
		var currentPos = transform.position;
		var t = 0f;
		while(t < 1)
		{
			t += Time.deltaTime / timeToMove;
			transform.position = Vector3.Lerp(currentPos, position, _animationCurve.Evaluate(t));
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
