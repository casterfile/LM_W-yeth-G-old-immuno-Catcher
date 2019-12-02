using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireMove : MonoBehaviour {

	private Transform target;
	private float speed = 15.0f;
	private bool isHit = false;
	public string Name;
	void Start()
    {
        target = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

	void Update() {
		if(isHit == false){
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		}else{
			gameObject.GetComponent<Collider>().enabled = false;
		}
	}


	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Down"){
        	isHit = true;
        	// print("Down");
     		// StartCoroutine(DetroyObject(gameObject));
     		if(Name == "Point"){
     			print("Score Point");
     			Player.PlayerScore++;
     		}
     		else if(Name == "Bomb"){
     			print("Bomb Bomb");
     			Player.Life--;
     		}
     		Destroy(gameObject);
     		
   		}

   		if (col.gameObject.tag == "Up"){
   			isHit = true;
     		// print("Up");
     		StartCoroutine(DetroyObject(gameObject));
   		}

   		if (col.gameObject.tag == "Player"){
     		Player.Life--;
   			isHit = true;
     		print("Player Hit");
     		Destroy(gameObject);
   		}


    }


    IEnumerator DetroyObject(GameObject Object)
    {
        yield return new WaitForSeconds(5);
        Destroy(Object);
    }
}
