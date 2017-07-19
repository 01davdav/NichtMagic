using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonPlayCard : MonoBehaviour
{

	private Player P;
	
	void Start ()
	{
		P = Camera.main.GetComponent<Main>().MPlayer;
	}

	public void PlayACard()
	{
		P.PlayCard();
	}
}
