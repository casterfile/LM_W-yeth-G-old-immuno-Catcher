using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panggulo : MonoBehaviour {

	// Use this for initialization
	public void EndGame () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Touch")
		{
			GlobalVar.isEndGame = true;
		}

	}
}
