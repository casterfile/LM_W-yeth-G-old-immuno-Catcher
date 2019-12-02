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
        target = GameObject.Find("PlayerAttact").GetComponent<Transform>();
    }

	void Update() {
		if(isHit == false){
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		}else{
			// GetComponent<Collider>().enabled = false;
            Component[] col = GetComponents<Collider>() as Component[];
            foreach(Component coll in col)
                Destroy(coll as Collider);

            // Component[] Rigid = GetComponents<Rigidbody>() as Component[];
            // foreach(Component rigid in Rigid)
            //     Destroy(rigid as Collider);
		}
	}


	void OnCollisionEnter(Collision col)
    {
     //    if (col.gameObject.tag == "Down"){
     //    	isHit = true;
     //    	// print("Down");
     // 		// StartCoroutine(DetroyObject(gameObject));
     // 		if(Name == "Point"){
     // 			print("Score Point");
     // 			Player.PlayerScore++;

     // 			GameObject Canvas = GameObject.Find("Canvas");
		   //      Player PlayerScript = Canvas.GetComponent<Player>();

		   //      PlayerScript.OutputPopup(1);

     // 		}
     // 		else if(Name == "Bomb"){
     // 			print("Bomb Bomb");
     // 			// Player.Life--;

     //            if(Player.Life == 3){
     //                Player.Life = 2;
     //            }else if(Player.Life == 2){
     //                Player.Life = 1;
     //            }else if(Player.Life == 1){
     //                Player.Life = 0;
     //            }

     // 			GameObject Canvas = GameObject.Find("Canvas");
		   //      Player PlayerScript = Canvas.GetComponent<Player>();

		   //      PlayerScript.OutputPopup(4);
     // 		}
     // 		Destroy(gameObject);
     		
   		// }

   		if (col.gameObject.tag == "Up" || col.gameObject.tag == "Hands"){
   			isHit = true;
     		// print("Up");
            GameObject Canvas = GameObject.Find("Canvas");
            Player PlayerScript = Canvas.GetComponent<Player>();
            PlayerScript.StartSound(2);
     		StartCoroutine(DetroyObject(gameObject));
   		}

   		if (col.gameObject.tag == "Player"){
            if (gameObject.tag == "Bomb") {
                //Player.Life--;
                if (isHit == false)
                {
                    if (Player.Life == 3)
                    {
                        Player.Life = 2;
                    }
                    else if (Player.Life == 2)
                    {
                        Player.Life = 1;
                    }
                    else if (Player.Life == 1)
                    {
                        Player.Life = 0;
                    }
                }


                isHit = true;
                print("Player Hit");

                GameObject Canvas = GameObject.Find("Canvas");
                Player PlayerScript = Canvas.GetComponent<Player>();

                PlayerScript.OutputPopup(4);

                
            }
            Destroy(gameObject);
        }


    }


    IEnumerator DetroyObject(GameObject Object)
    {
        yield return new WaitForSeconds(4);
        Destroy(Object);
    }

    public void HoverOverride(){
        // GameObject Canvas = GameObject.Find("Canvas");
        // Player PlayerScript = Canvas.GetComponent<Player>();

        // PlayerScript.StartSound(2);
        isHit = true;
    }

    public void GrabOverride(){
        // GameObject Canvas = GameObject.Find("Canvas");
        // Player PlayerScript = Canvas.GetComponent<Player>();

        // PlayerScript.StartSound(1);
        isHit = true;
    }
}
