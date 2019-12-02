using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetect2 : MonoBehaviour {
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "cube")
		{
			col.gameObject.GetComponent<Renderer> ().material.color = ColorController.newColor2;

		}
	}
}
