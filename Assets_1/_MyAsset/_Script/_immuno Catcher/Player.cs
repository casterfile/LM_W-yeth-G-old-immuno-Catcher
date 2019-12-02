using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public static int PlayerScore = 0;
	public static int Life = 3;
	public GameObject UIControlWin, UIControlLose,Scoremanager;
	private Text Output;
	public string SceneName;
	private GameObject H1,H2,H3;
	// Use this for initialization
	void Start () {
		PlayerScore = 0;
		Life = 3;
		H1 = GameObject.Find("H1");
		H2 = GameObject.Find("H2");
		H3 = GameObject.Find("H3");
		Output = GameObject.Find("Output").GetComponent<Text>();
		Scoremanager = GameObject.Find("Scoremanager");

		UIControlWin.SetActive (false);
		UIControlLose.SetActive (false);
		Scoremanager.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		Output.text = PlayerScore+"";//"Score: "+ PlayerScore+ " || Life: "+ Life;

		if(Life == 3){
			H1.SetActive(true);
			H2.SetActive(true);
			H3.SetActive(true);
		}else if(Life == 2){
			H1.SetActive(true);
			H2.SetActive(true);
			H3.SetActive(false);
		}else if(Life == 1){
			H1.SetActive(true);
			H2.SetActive(false);
			H3.SetActive(false);
		}else if(Life == 0){
			H1.SetActive(false);
			H2.SetActive(false);
			H3.SetActive(false);
		}

		if(PlayerScore == 10){
			UIControlWin.SetActive (true);
			Scoremanager.SetActive(false);
		}
		else if(Life == 0){
			UIControlLose.SetActive (true);
			Scoremanager.SetActive(false);
		}
	}

	public void Restart(){
		Application.LoadLevel(SceneName);
	}
}
