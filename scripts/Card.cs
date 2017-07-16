using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
	private String name;
	private int manacosts;
	private int attack;
	private int life;
	private int shield;
	private int currentShield;
	private Boolean breakable = true;
	
	public Card(String newName, int newManacosts, int newAttack, int newLife, int newShield)
	{
		setName(newName);
		setManacosts(newManacosts);
		setAttack(newAttack);
		setLife(newLife);
		setShield(newShield);
	}

	public void setName(String newName)
	{
		if(name != null)
		name = newName;
	}

	public void setManacosts(int newManacosts)
	{
		if (newManacosts >= 0)
		{
			manacosts = newManacosts;
		}
	}

	public void addManacosts(int newManacosts)
	{
		if (newManacosts > 0)
		{
			manacosts += newManacosts;
		}
	}

	public void removeManacosts(int newManacosts)
	{
		if (newManacosts > 0)
		{
			manacosts -= newManacosts;
		}
	}

	public void setAttack(int newAttack)
	{
		if (newAttack >= 0)
		{
			attack = newAttack;
		}
	}

	public void addAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			attack += newAttack;
		}
	}

	public void removeAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			attack -= newAttack;
		}
	}

	public void setLife(int newLife)
	{
		if (newLife >= 0)
		{
			life = newLife;
		}
	}

	public void addLife(int newLife)
	{
		if (newLife > 0)
		{
			life += newLife;
		}
	}

	public void removeLife(int newLife)
	{
		if (newLife > 0)
		{
			life -= newLife;
		}
	}

	public void setShield(int newShield)
	{
		if (newShield >= 0)
		{
			shield = newShield;
		}
	}

	public void addShield(int newShield)
	{
		if (newShield > 0)
		{
			shield += newShield;
		}
	}

	public void removeShield(int newShield)
	{
		if (newShield > 0)
		{
			shield -= newShield;
		}
	}

	public void setBreakable(Boolean newBreakable)
	{
		breakable = newBreakable;
	}

	public void setCurrentShield(int newCurrentShield)
	{
		if (newCurrentShield >= 0)
		{
			currentShield = newCurrentShield;
		}
	}

	public void addCurrentShield(int newCurrentShield)
	{
		if (newCurrentShield > 0)
		{
			currentShield += newCurrentShield;
		}
	}

	public void removeCurrentShield(int newCurrentShield)
	{
		if (newCurrentShield > 0)
		{
			currentShield -= newCurrentShield;
		}
	}

	public int getManacosts()
	{
		return manacosts;
	}

	public int getAttack()
	{
		return attack;
	}

	public int getLife()
	{
		return life;
	}
	
	public string getName()
	{
		return name;
	}

	public int getShield()
	{
		return shield;
	}

	public Boolean getBreakable()
	{
		return breakable;
	}

	public int getCurrentShield()
	{
		return currentShield;
	}
	
	// Use this for initialization
	void Start () 
	{
		
	}
}
