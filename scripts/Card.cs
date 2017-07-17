using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
	private String _name;
	private int _manacosts;
	private int _attack;
	private int _life;
	private int _shield;
	private int _currentShield;
	private Boolean _breakable = true;
	
	public Card(String newName, int newManacosts, int newAttack, int newLife, int newShield)
	{
		SetName(newName);
		SetManacosts(newManacosts);
		SetAttack(newAttack);
		SetLife(newLife);
		SetShield(newShield);
	}

	public void SetName(String newName)
	{
		if(newName != null)
		_name = newName;
	}

	public void SetManacosts(int newManacosts)
	{
		if (newManacosts >= 0)
		{
			_manacosts = newManacosts;
		}
	}

	public void AddManacosts(int newManacosts)
	{
		if (newManacosts > 0)
		{
			_manacosts += newManacosts;
		}
	}

	public void RemoveManacosts(int newManacosts)
	{
		if (newManacosts > 0)
		{
			_manacosts -= newManacosts;
		}
	}

	public void SetAttack(int newAttack)
	{
		if (newAttack >= 0)
		{
			_attack = newAttack;
		}
	}

	public void AddAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			_attack += newAttack;
		}
	}

	public void RemoveAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			_attack -= newAttack;
		}
	}

	public void SetLife(int newLife)
	{
		if (newLife >= 0)
		{
			_life = newLife;
		}
	}

	public void AddLife(int newLife)
	{
		if (newLife > 0)
		{
			_life += newLife;
		}
	}

	public void RemoveLife(int newLife)
	{
		if (newLife > 0)
		{
			_life -= newLife;
		}
	}

	public void SetShield(int newShield)
	{
		if (newShield >= 0)
		{
			_shield = newShield;
		}
	}

	public void AddShield(int newShield)
	{
		if (newShield > 0)
		{
			_shield += newShield;
		}
	}

	public void RemoveShield(int newShield)
	{
		if (newShield > 0)
		{
			_shield -= newShield;
		}
	}

	public void SetBreakable(Boolean newBreakable)
	{
		_breakable = newBreakable;
	}

	public void SetCurrentShield(int newCurrentShield)
	{
		if (newCurrentShield >= 0)
		{
			_currentShield = newCurrentShield;
		}
	}

	public void AddCurrentShield(int newCurrentShield)
	{
		if (newCurrentShield > 0)
		{
			_currentShield += newCurrentShield;
		}
	}

	public void RemoveCurrentShield(int newCurrentShield)
	{
		if (newCurrentShield > 0)
		{
			_currentShield -= newCurrentShield;
		}
	}

	public int GetManacosts()
	{
		return _manacosts;
	}

	public int GetAttack()
	{
		return _attack;
	}

	public int GetLife()
	{
		return _life;
	}
	
	public string GetName()
	{
		return _name;
	}

	public int GetShield()
	{
		return _shield;
	}

	public Boolean GetBreakable()
	{
		return _breakable;
	}

	public int GetCurrentShield()
	{
		return _currentShield;
	}
	
	//for testing
	public static Card GetRandomCard()
	{
		return new Card(Control.GetRandomName(), 0, 0, 0, 0);
	}
}
