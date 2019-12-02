using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game2Collition : MonoBehaviour {
	
	public Color c1;//= Color.yellow;
	private Color c2 = Color.red;
	private int lengthOfLineRenderer = 20;



	private bool isAddRigit = false;

	public AudioClip Effect1;
	public AudioSource audioData;
	void Start(){
		
		//audioData = GetComponent<AudioSource>();

		//c1 = new Color(0.3f, 0.4f, 0.6f, 0.3f);
	}

	void Update()
	{
//		print ("Data: "+ GlobalVar.m_NewTransform1);
	}

	void SettingOrder(Transform xData,Transform yData){

		if (xData.transform != null && yData.transform != null) {
			GlobalVar.GlobalScore++;
			Vector3 m_MyPosition1 = new Vector3 (xData.position.x, xData.position.y, xData.position.z);
			Vector3 m_MyPosition2 = new Vector3 (yData.position.x, yData.position.y, yData.position.z);
			DrawLine (m_MyPosition1, m_MyPosition2, c2, 0.2f);
			AudioSound ();
		}
	}

	void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.2f)
	{
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
//		lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		lr.material = new Material(Shader.Find("Standard"));
		lr.SetColors(color, color);
		lr.SetWidth(0.1f, 0.1f);
		lr.SetPosition(0, start);
		lr.SetPosition(1, end);

//		GameObject.Destroy(myLine, duration);
	}

	void OnTriggerEnter (Collider  col)
	{
		if(col.gameObject.name == "1"){
			if (GlobalVar.lastGO != col.gameObject.name) {
				GlobalVar.lastGO = col.gameObject.name;
			
				if (GlobalVar.Name1 == "" && GlobalVar.lastGO == "1" ) {
					GlobalVar.Name1 = col.gameObject.name;
				}
				else if(GlobalVar.Name1 == "1"){
					EndGame ();
				}
			}

		}

		if(col.gameObject.name == "2"){
			if (GlobalVar.lastGO != col.gameObject.name) {
				GlobalVar.lastGO = col.gameObject.name;

				if (GlobalVar.Name2 == "" && GlobalVar.lastGO == "2" ) {
					GlobalVar.Name2 = col.gameObject.name;
				}
				else if(GlobalVar.Name2 == "2"){
					EndGame ();
				}
			}

		}

		if(col.gameObject.name == "3"){
			if (GlobalVar.lastGO != col.gameObject.name) {
				GlobalVar.lastGO = col.gameObject.name;

				if (GlobalVar.Name3 == "" && GlobalVar.lastGO == "3" ) {
					GlobalVar.Name3 = col.gameObject.name;
				}
				else if(GlobalVar.Name3 == "3"){
					EndGame ();
				}
			}

		}

		if(col.gameObject.name == "4"){
			if (GlobalVar.lastGO != col.gameObject.name) {
				GlobalVar.lastGO = col.gameObject.name;

				if (GlobalVar.Name4 == "" && GlobalVar.lastGO == "4" ) {
					GlobalVar.Name4 = col.gameObject.name;
				}
				else if(GlobalVar.Name4 == "4"){
					EndGame ();
				}
			}

		}

		if(col.gameObject.name == "5"){
			if (GlobalVar.lastGO != col.gameObject.name) {
				GlobalVar.lastGO = col.gameObject.name;

				if (GlobalVar.Name5 == "" && GlobalVar.lastGO == "5" ) {
					GlobalVar.Name5 = col.gameObject.name;
				}
				else if(GlobalVar.Name5 == "5"){
					EndGame ();
				}
			}

		}



		if(col.gameObject.name == "6"){
			if (GlobalVar.lastGO != col.gameObject.name) {
				GlobalVar.lastGO = col.gameObject.name;

				if (GlobalVar.Name6 == "" && GlobalVar.lastGO == "6" ) {
					GlobalVar.Name6 = col.gameObject.name;
				}
				else if(GlobalVar.Name6 == "6"){
					EndGame ();
				}
			}

		}

		if (col.gameObject.tag == "endgame") {
			GlobalVar.isEndGame = true;
		}

		if(col.gameObject.tag == "fry")
		{
			if(GlobalVar.LastObject != col.gameObject && col.gameObject != null){
				GlobalVar.LastObject = col.gameObject;
				print ("GlobalVar.GlobalScore: " + GlobalVar.GlobalScore);

				if (GlobalVar.GlobalScore == 5 && GlobalVar.m_NewTransform6 == null && GlobalVar.m_NewTransform5 != col.gameObject.transform 
					&& GlobalVar.m_NewTransform4 != col.gameObject.transform && GlobalVar.m_NewTransform3 != col.gameObject.transform 
					&& GlobalVar.m_NewTransform2 != col.gameObject.transform && GlobalVar.m_NewTransform1 != col.gameObject.transform) {
					GlobalVar.m_NewTransform6 = col.gameObject.transform;
//					GlobalVar.GlobalScore = 6;
					SettingOrder (GlobalVar.m_NewTransform5, GlobalVar.m_NewTransform6);
//					print ("Data 6");
				}

				else if (GlobalVar.GlobalScore == 4 &&GlobalVar. m_NewTransform5 == null && GlobalVar.m_NewTransform4 != col.gameObject.transform 
					&& GlobalVar.m_NewTransform3 != col.gameObject.transform && GlobalVar.m_NewTransform2 != col.gameObject.transform 
					&&GlobalVar. m_NewTransform1 != col.gameObject.transform) {
					GlobalVar.m_NewTransform5 = col.gameObject.transform;
//					GlobalVar.GlobalScore = 5;
					SettingOrder (GlobalVar.m_NewTransform4, GlobalVar.m_NewTransform5);
//					print ("Data 5");
				}

				else if (GlobalVar.GlobalScore == 3 && GlobalVar.m_NewTransform4 == null && GlobalVar.m_NewTransform3 != col.gameObject.transform 
					&& GlobalVar.m_NewTransform2 != col.gameObject.transform && GlobalVar.m_NewTransform1 != col.gameObject.transform) {
					GlobalVar.m_NewTransform4 = col.gameObject.transform;
//					GlobalVar.GlobalScore = 4;
					SettingOrder (GlobalVar.m_NewTransform3, GlobalVar.m_NewTransform4);
//					print ("Data 4");
				}

				else if (GlobalVar.GlobalScore == 2 && GlobalVar.m_NewTransform3 == null && GlobalVar.m_NewTransform2 != col.gameObject.transform 
					&& GlobalVar.m_NewTransform1 != col.gameObject.transform) {
					GlobalVar.m_NewTransform3 = col.gameObject.transform;
//					GlobalVar.GlobalScore = 3;
					SettingOrder (GlobalVar.m_NewTransform2, GlobalVar.m_NewTransform3);
//					print ("Data 3");
				}

				else if (GlobalVar.GlobalScore == 1 && GlobalVar.m_NewTransform2 == null && GlobalVar.m_NewTransform1 != col.gameObject.transform) {
					
					if (col.gameObject.transform != null) {
						GlobalVar.m_NewTransform2 = col.gameObject.transform;
					}
//					GlobalVar.GlobalScore = 2;
//					print ("Data 2: ");

					try {
						SettingOrder (GlobalVar.m_NewTransform1,GlobalVar. m_NewTransform2);
					} catch {
						print ("Error: "+ GlobalVar.m_NewTransform1);	
						print ("Error: "+ GlobalVar.m_NewTransform2);
					}

				} 

				else if (GlobalVar.GlobalScore == 0 && GlobalVar.m_NewTransform1 == null) {
					GlobalVar.m_NewTransform1 = col.gameObject.transform;
					GlobalVar.GlobalScore = 1;
					print ("Data 1: "+GlobalVar.m_NewTransform1 );
					AudioSound ();
				}
					
			}


		}
	}

	void EndGame(){
		GlobalVar.isEndGame = true;
	}

	private void AudioSound(){
		audioData.PlayOneShot(Effect1, 0.7F);
	}
}
