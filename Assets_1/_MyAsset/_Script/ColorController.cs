using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour {

	public static Color newColor,newColor2;
	private float timer = 0.0f;
	private bool isColor = false;
	public GameObject wall1,wall2,wall3;

	// Use this for initialization
	void Start () {
		isColor = false;
		InvokeRepeating("ColorChange", 5.0f, 5.0f);
	}

	// Update is called once per frame
	void ColorChange () {
//		timer += Time.deltaTime;
//		if (timer >= 2.0f)//change the float value here to change how long it takes to switch.
//		{
//
//			timer = 0;
//		}

		int number = Random.Range (1, 3);
		// pick a random color
		// apply it on current object's material
		newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
		newColor2 = new Color( newColor.r - .80f, newColor.g - .70f, newColor.b + .90f, 1.0f );

		if(newColor == newColor){
			
		}
//		print ("newColor.r: "+ newColor.r);

		wall1.GetComponent<Renderer> ().material.color = newColor;
		wall2.GetComponent<Renderer> ().material.color = newColor2;

		if (number == 1) {
			wall3.GetComponent<Renderer>().material.color = newColor;
		}else if (number == 2) {
			wall3.GetComponent<Renderer>().material.color = newColor2;
		}

	}
}
