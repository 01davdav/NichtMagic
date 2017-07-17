using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Card
{
	private static String _name;
	private static int _manacosts;
	private static int _attack;
	private static int _life;
	private static int _shield;
	private static int _currentShield;
	private static Boolean _breakable = true;
	private static String _texturePath;
	
	public Card(String newName, int newManacosts, int newAttack, int newLife, int newShield, String newTexturePath) //create new Creature Card object
	{
		SetName(newName);
		SetManacosts(newManacosts);
		SetAttack(newAttack);
		SetLife(newLife);
		SetShield(newShield);
		SetPath(newTexturePath);
	}

	public Card(String newName, int newManacosts) //create new Spell Card object
	{
		SetName(newName);
		SetManacosts(newManacosts);
	}

	public static void SetPath(String newTexturePath)
	{
		_texturePath = newTexturePath;
	}

	public static void SetName(String newName)
	{
		if (!String.IsNullOrEmpty(newName))
		{
			_name = newName;
		}
	}

	public static void SetManacosts(int newManacosts) //set manacosts of card
	{
		if (newManacosts >= 0)
		{
			_manacosts = newManacosts;
		}
	}

	public static void AddManacosts(int newManacosts) //add manacosts to card
	{
		if (newManacosts > 0)
		{
			_manacosts += newManacosts;
		}
	}

	public static void RemoveManacosts(int newManacosts) //subtract manacosts of card
	{
		if (newManacosts > 0)
		{
			_manacosts -= newManacosts;
		}
	}

	public static void SetAttack(int newAttack) //set attack of card
	{
		if (newAttack >= 0)
		{
			_attack = newAttack;
		}
	}

	public static void AddAttack(int newAttack) //add attack of card
	{
		if (newAttack > 0)
		{
			_attack += newAttack;
		}
	}

	public static void RemoveAttack(int newAttack) //subtract attack of card 
	{
		if (newAttack > 0)
		{
			_attack -= newAttack;
		}
	}

	public static void SetLife(int newLife) //set life of card
	{
		if (newLife >= 0)
		{
			_life = newLife;
		}
	}

	public static void AddLife(int newLife) //add life of card
	{
		if (newLife > 0)
		{
			_life += newLife;
		}
	}

	public static void RemoveLife(int newLife) //subtract life of card
	{
		if (newLife > 0)
		{
			_life -= newLife;
		}
	}

	public static void SetShield(int newShield) //set shield of card
	{
		if (newShield >= 0)
		{
			_shield = newShield;
		}
	}

	public static void AddShield(int newShield) //add shield of card
	{
		if (newShield > 0)
		{
			_shield += newShield;
		}
	}

	public static void RemoveShield(int newShield) //subtract shield of card 
	{
		if (newShield > 0)
		{
			_shield -= newShield;
		}
	}

	public static void SetBreakable(Boolean newBreakable) //is the shield breakable, yes - true, no - false
	{
		_breakable = newBreakable;
	}

	public static void SetCurrentShield(int newCurrentShield) //set current value of shield 
	{
		if (newCurrentShield >= 0)
		{
			_currentShield = newCurrentShield;
		}
	}

	public static void AddCurrentShield(int newCurrentShield) //add to current shield 
	{
		if (newCurrentShield > 0)
		{
			_currentShield += newCurrentShield;
		}
	}

	public static void RemoveCurrentShield(int newCurrentShield) //remove from current shield 
	{
		if (newCurrentShield > 0)
		{
			_currentShield -= newCurrentShield;
		}
	}

	public static int GetManacosts()
	{
		return _manacosts;
	}

	public static int GetAttack()
	{
		return _attack;
	}

	public static int GetLife()
	{
		return _life;
	}
	
	public static string GetName()
	{
		return _name;
	}

	public static int GetShield()
	{
		return _shield;
	}

	public static Boolean GetBreakable()
	{
		return _breakable;
	}

	public static int GetCurrentShield()
	{
		return _currentShield;
	}
	
	//for testing
	public static Card GetRandomCard()
	{
		return new Card(Control.GetRandomName(), 0, 0, 0, 0);
	}
}
