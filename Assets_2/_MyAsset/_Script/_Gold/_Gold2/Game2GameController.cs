using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2GameController : MonoBehaviour {
	public GameObject UIControlWin, UIControlLose;
	public string SceneName;
	// Use this for initialization
	void Start () {
		UIControlWin.SetActive (false);
		UIControlLose.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(GlobalVar.GlobalScore == 5 && GlobalVar.isEndGame == false){
			UIControlWin.SetActive (true);
		}
		else if(GlobalVar.isEndGame == true && GlobalVar.GlobalScore < 5){
			UIControlLose.SetActive (true);
		}
	}

	public void Restart(){
		Application.LoadLevel(SceneName);
	}
}
