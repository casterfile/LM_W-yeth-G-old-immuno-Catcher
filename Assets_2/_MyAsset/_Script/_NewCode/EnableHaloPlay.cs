using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableHaloPlay : MonoBehaviour {
	public GameObject HaloPlay;
	// Use this for initialization
	void Start () {
		

		

	    #if UNITY_STANDALONE_WIN
	      HaloPlay.SetActive(true);
	    #endif

	     #if UNITY_EDITOR
	      HaloPlay.SetActive(false);
	    #endif
	}


}
