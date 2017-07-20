using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonPlayCard : MonoBehaviour
{

	private Board B;
	private Player P;
	
	void Start ()
	{
		B = Camera.main.GetComponent<Main>().MBoard;
		P = Camera.main.GetComponent<Main>().MPlayer;
	}

	public void PlayACard()
	{
		B.PlayCard(P.Hand[0],2);
	}
}
