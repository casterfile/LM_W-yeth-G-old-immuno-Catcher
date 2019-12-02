using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetect3 : MonoBehaviour {
	void OnCollisionEnter (Collision col)
	{


		if(col.gameObject.tag == "cube")
		{
//			col.gameObject.GetComponent<Renderer> ().material.color = ColorController.newColor2;

//			print ("data1: "+col.gameObject.GetComponent<Renderer> ().material.color);
//			print ("data2: "+GetComponent<Renderer> ().material.color);
			if(col.gameObject.GetComponent<Renderer> ().material.color == GetComponent<Renderer> ().material.color){
				Destroy (col.gameObject);
			}

		}
	}
}
