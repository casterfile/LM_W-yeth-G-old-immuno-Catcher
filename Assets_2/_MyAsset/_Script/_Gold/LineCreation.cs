using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreation : MonoBehaviour {

	// Creates a line renderer that follows a Sin() function
	// and animates it.

	public Color c1 = Color.yellow;
	public Color c2 = Color.red;
	public int lengthOfLineRenderer = 20;
	Vector3 m_MyPosition1, m_MyPosition2;

	public Transform m_NewTransform1,m_NewTransform2;
	void Start()
	{
		m_MyPosition1.Set(m_NewTransform1.position.x, m_NewTransform1.position.y, m_NewTransform1.position.z);
		m_MyPosition2.Set(m_NewTransform2.position.x, m_NewTransform2.position.y, m_NewTransform2.position.z);
		DrawLine (m_MyPosition1,m_MyPosition2,c1,0.2f);
	}

	void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.2f)
	{
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		lr.SetColors(color, color);
		lr.SetWidth(0.1f, 0.1f);
		lr.SetPosition(0, start);
		lr.SetPosition(1, end);
//		GameObject.Destroy(myLine, duration);
	}
}
