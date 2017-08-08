using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingButton : MonoBehaviour {
	private Player P;
	private WriteJson W;
	private Turns T;

	private void Start()
	{
		P = Camera.main.GetComponent<Main>().MPlayer;
		W = Camera.main.GetComponent<WriteJson>();
		T = Camera.main.GetComponent<Main>().MTurns;
	}

	public void DrawACard () 
	{
		T.Turn();
	}

	public void SaveCurrentDeck()
	{
		W.addDeck(P.getDeckIds());
	}
}
