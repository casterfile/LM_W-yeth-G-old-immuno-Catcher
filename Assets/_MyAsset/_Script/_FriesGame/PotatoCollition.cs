using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoCollition : MonoBehaviour {
	private Transform target;
	private float speed = 1;
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "fry")
		{
			col.gameObject.GetComponent<Collider>().enabled = false;

			float step = speed * Time.deltaTime;
			target = GameObject.Find("Target").GetComponent<Transform>();
			col.gameObject.transform.position = Vector3.MoveTowards(transform.position, target.position, step);
//			Destroy (col.gameObject);

			StartCoroutine(NextMove(col.gameObject));
		}
	}

	IEnumerator NextMove(GameObject gm)
	{
		
		yield return new WaitForSeconds(3);

		gm.GetComponent<Rigidbody>().detectCollisions = false;
		gm.GetComponent<Rigidbody>().isKinematic = false;

		Destroy (gm.GetComponent<Rigidbody>());
		GlobalVar.GlobalScore++;

		print ("GlobalVar.GlobalScore: "+GlobalVar.GlobalScore);
	}
}
