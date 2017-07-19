using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingButton : MonoBehaviour {
	private Player P;
	private WriteJson W;

	private void Start()
	{
		P = Camera.main.GetComponent<Main>().MPlayer;
		W = Camera.main.GetComponent<WriteJson>();
	}

	public void DrawACard () {
		
		P.Draw();
	}

	public void SaveCurrentDeck()
	{
		W.addDeck(P.getDeckIds());
	}
}
