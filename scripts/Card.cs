using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
	private String _name;
	private int _manacosts;
	private int _attack;
	private int _life;
	private int _shield;
	private int _currentShield;
	private Boolean _breakable = true;
	private String _texturePath;

	private int _id;

	private Control C;
	private Player P;
	private Board B;
	
	private void Start()
	{
		C = Camera.main.GetComponent<Control>();
		P = Camera.main.GetComponent<Main>().MPlayer;
		B = Camera.main.GetComponent<Main>().MBoard;
	}

	private Color startcolor;
	
	void OnMouseEnter()
	{
		if (P.Hand.Contains(this.gameObject))
		{
			this.gameObject.transform.localScale = new Vector3(1, 1, 1);
			this.gameObject.GetComponent<Renderer>().sortingOrder = 1;
		}
	}
	void OnMouseExit()
	{
		if (P.Hand.Contains(this.gameObject))
		{
			this.gameObject.transform.localScale = new Vector3(.8f, .8f, .8f);
			this.gameObject.GetComponent<Renderer>().sortingOrder = 0;
		}
	}

	public void Exit()
	{
		this.gameObject.transform.localScale = new Vector3(.8f, .8f, .8f);
		this.gameObject.GetComponent<Renderer>().sortingOrder = 0;
	}
	
	private void OnMouseDown()
	{
		if (P.Hand.Contains(this.gameObject))
		{
			B.PlayCard(this.gameObject);
		}
	}

	public Card(String newName, int newManacosts, int newAttack, int newLife, int newShield, String newTexturePath, int newId) //create new Creature Card object
	{
		SetName(newName);
		SetManacosts(newManacosts);
		SetAttack(newAttack);
		SetLife(newLife);
		SetShield(newShield);
		SetPath(newTexturePath);
		SetId(newId);
	}
	
	public void SetCard(String newName, int newManacosts, int newAttack, int newLife, int newShield, String newTexturePath, int newId) //create new Creature Card object
	{
		SetName(newName);
		SetManacosts(newManacosts);
		SetAttack(newAttack);
		SetLife(newLife);
		SetShield(newShield);
		SetPath(newTexturePath);
		SetId(newId);
	}

	public Card(String newName, int newManacosts) //create new Spell Card object
	{
		SetName(newName);
		SetManacosts(newManacosts);
	}

	public void SetPath(String newTexturePath)
	{
		_texturePath = newTexturePath;
	}

	public void SetName(String newName)
	{
		if (!String.IsNullOrEmpty(newName))
		{
			_name = newName;
		}
	}

	public void SetManacosts(int newManacosts) //set manacosts of card
	{
		if (newManacosts >= 0)
		{
			_manacosts = newManacosts;
		}
	}

	public void AddManacosts(int newManacosts) //add manacosts to card
	{
		if (newManacosts > 0)
		{
			_manacosts += newManacosts;
		}
	}

	public void RemoveManacosts(int newManacosts) //subtract manacosts of card
	{
		if (newManacosts > 0)
		{
			_manacosts -= newManacosts;
		}
	}

	public void SetAttack(int newAttack) //set attack of card
	{
		if (newAttack >= 0)
		{
			_attack = newAttack;
		}
	}

	public void AddAttack(int newAttack) //add attack of card
	{
		if (newAttack > 0)
		{
			_attack += newAttack;
		}
	}

	public void RemoveAttack(int newAttack) //subtract attack of card 
	{
		if (newAttack > 0)
		{
			_attack -= newAttack;
		}
	}

	public void SetLife(int newLife) //set life of card
	{
		if (newLife >= 0)
		{
			_life = newLife;
		}
	}

	public void AddLife(int newLife) //add life of card
	{
		if (newLife > 0)
		{
			_life += newLife;
		}
	}

	public void RemoveLife(int newLife) //subtract life of card
	{
		if (newLife > 0)
		{
			_life -= newLife;
		}
	}

	public void SetShield(int newShield) //set shield of card
	{
		if (newShield >= 0)
		{
			_shield = newShield;
		}
	}

	public void AddShield(int newShield) //add shield of card
	{
		if (newShield > 0)
		{
			_shield += newShield;
		}
	}

	public void RemoveShield(int newShield) //subtract shield of card 
	{
		if (newShield > 0)
		{
			_shield -= newShield;
		}
	}

	public void SetBreakable(Boolean newBreakable) //is the shield breakable, yes - true, no - false
	{
		_breakable = newBreakable;
	}

	public void SetCurrentShield(int newCurrentShield) //set current value of shield 
	{
		if (newCurrentShield >= 0)
		{
			_currentShield = newCurrentShield;
		}
	}

	public void AddCurrentShield(int newCurrentShield) //add to current shield 
	{
		if (newCurrentShield > 0)
		{
			_currentShield += newCurrentShield;
		}
	}

	public void RemoveCurrentShield(int newCurrentShield) //remove from current shield 
	{
		if (newCurrentShield > 0)
		{
			_currentShield -= newCurrentShield;
		}
	}

	public void SetId(int newId)
	{
		_id = newId;
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
	
	public string GetPath()
	{
		return _texturePath;
	}

	public Boolean GetBreakable()
	{
		return _breakable;
	}

	public int GetCurrentShield()
	{
		return _currentShield;
	}

	public int GetId()
	{
		return _id;
	}
}
