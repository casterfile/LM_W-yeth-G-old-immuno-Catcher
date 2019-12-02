using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class BallCollider : MonoBehaviour {
	private Transform target;
	private float speed = 40;
	private bool isHit = false;
	// Use this for initialization
	public AudioClip Effect1;
	public AudioSource audioData;
	void Start () {
//		audioData = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isHit == true){
			float step = speed * Time.deltaTime;
			target = GameObject.Find("Target").GetComponent<Transform>();
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		}

	}


	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "enter")
		{
			isHit = true;	
			AudioSound ();
//			StartCoroutine(NextMove(col.gameObject));
		}

		if(col.gameObject.tag == "target"){
			if (isHit == true) {

				GetComponent<Rigidbody> ().detectCollisions = false;
				GetComponent<Rigidbody> ().isKinematic = false;

				Destroy (GetComponent<Rigidbody> ());
				GlobalVar.GlobalScore++;
				GetComponent<Collider>().enabled = false;
				print ("GlobalVar.GlobalScore: " + GlobalVar.GlobalScore);
				Destroy (gameObject);
			}
		}
	}

	IEnumerator NextMove(GameObject gm)
	{

		yield return new WaitForSeconds(3);


	}



	private void AudioSound(){
		audioData.PlayOneShot(Effect1, 0.7F);
	}
}
