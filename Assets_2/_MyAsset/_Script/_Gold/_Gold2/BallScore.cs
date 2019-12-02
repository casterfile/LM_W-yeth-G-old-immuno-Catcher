using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScore : MonoBehaviour {
	private bool isScore = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Touch")
		{
			if(isScore == false){
				isScore = true;
//				GlobalVar.GlobalScore++;
//				if(GlobalVar.GlobalScore == 0){
//					GlobalVar.GlobalScore = 1;
//				}else if(GlobalVar.GlobalScore == 1){
//					GlobalVar.GlobalScore = 2;
//				}else if(GlobalVar.GlobalScore == 2){
//					GlobalVar.GlobalScore = 3;
//				}else if(GlobalVar.GlobalScore == 3){
//					GlobalVar.GlobalScore = 4;
//				}else if(GlobalVar.GlobalScore == 4){
//					GlobalVar.GlobalScore = 5;
//				}else if(GlobalVar.GlobalScore == 5){
//					GlobalVar.GlobalScore = 6;
//				}
			}
		}

	}
}
