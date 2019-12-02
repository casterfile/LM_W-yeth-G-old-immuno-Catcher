using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDelete : MonoBehaviour {

	// Use this for initialization
	private Player script;
	private GameObject Canvas;
	void Start () {
		StartCoroutine(DetroyObject());
		Canvas = GameObject.Find("Canvas");
		script = Canvas.GetComponent<Player>();


	}
	

	IEnumerator DetroyObject()
    {
        yield return new WaitForSeconds(5f);
	        if (gameObject.tag == "Points")
	        {
	        	script.OutputPopup(3);
	        }
	        else if (gameObject.tag == "Bomb")
	        {
	        	script.OutputPopup(1);
	        }
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
