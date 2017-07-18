using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingButton : MonoBehaviour {
	private Player P;

	private void Start()
	{
		P = Camera.main.GetComponent<Main>().MPlayer;
	}

	public void DrawACard () {
		
		P.Draw();
	}
}
