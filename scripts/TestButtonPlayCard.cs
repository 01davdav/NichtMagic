using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonPlayCard : MonoBehaviour
{

	private Board B;
	
	void Start ()
	{
		B = Camera.main.GetComponent<Main>().MBoard;
	}

	public void PlayACard()
	{
		B.PlayCard();
	}
}
