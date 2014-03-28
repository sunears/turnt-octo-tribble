using UnityEngine;
using System.Collections;

public class bombCountShow : MonoBehaviour {

	public Vector3 offset;
	public int count=0;
	private LayBombs layBombs;
	void Awake ()
	{
		// Setting up the reference.
		layBombs = GameObject.FindGameObjectWithTag("Player").GetComponent<LayBombs>();

	}
	
	
	void Update ()
	{


		count = layBombs.bombCount;
		guiText.text = ""+count;
	}
}
