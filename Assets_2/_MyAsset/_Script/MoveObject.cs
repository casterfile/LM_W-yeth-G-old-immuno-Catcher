using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
	public Transform target;
	private float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
//		target = GameObject.Find("Target").GetComponent<Transform>();
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}
