using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVar : MonoBehaviour {
	public static int GlobalScore = 0;
	public static bool isEndGame = false;

	//Gold 2
	public static GameObject LastObject = null;
	public static string lastGO = "";

	public static Transform m_NewTransform1,m_NewTransform2,m_NewTransform3,m_NewTransform4,m_NewTransform5,m_NewTransform6;

	public static string Name1,Name2,Name3,Name4,Name5,Name6;
	// Use this for initialization
	void Start () {
		GlobalScore = 0;
		isEndGame = false;


		//Gold 2
		LastObject = null;
		lastGO = "";
		GlobalVar.m_NewTransform1 = null;
		GlobalVar.m_NewTransform2 = null;
		GlobalVar.m_NewTransform3 = null;
		GlobalVar.m_NewTransform4 = null;
		GlobalVar.m_NewTransform5 = null;
		GlobalVar.m_NewTransform6 = null;

		GlobalVar.Name1 = "";
		GlobalVar.Name2 = "";
		GlobalVar.Name3 = "";
		GlobalVar.Name4 = "";
		GlobalVar.Name5 = "";
		GlobalVar.Name6 = "";
	}

}
