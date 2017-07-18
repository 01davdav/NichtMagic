using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grave : MonoBehaviour {

	public List<GameObject> Graveyard = new List<GameObject>();
	[SerializeField]
	private UnityEngine.UI.Text _counter;
	
	public void Pop()
	{
		_counter.text = Graveyard.Count.ToString();
	}
}
