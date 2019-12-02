using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableVR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UnityEngine.XR.InputTracking.disablePositionalTracking = true;
	}
}
