using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns{

	public void Turn()
	{
		Hero.SetMana(Hero.GetMaxMana());
		Player.Draw();
	}

}
