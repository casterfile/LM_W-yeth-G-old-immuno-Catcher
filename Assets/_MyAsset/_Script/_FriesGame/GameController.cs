using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public GameObject UIControl;
	public string SceneName;
	// Use this for initialization
	void Start () {
		UIControl.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(GlobalVar.GlobalScore == 5){
			UIControl.SetActive (true);
		}
	}

	public void Restart(){
		Application.LoadLevel(SceneName);
	}
}
