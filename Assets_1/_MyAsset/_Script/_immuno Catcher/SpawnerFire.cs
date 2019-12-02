using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFire : MonoBehaviour {

	// Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject Bomb,Point;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Bomb.SetActive(false);
        Point.SetActive(false);
        InvokeRepeating("LaunchProjectile", 2.0f, 4.3f);
    }

    void LaunchProjectile()
    {
        // Rigidbody instance = Instantiate(projectile);

        // instance.velocity = Random.insideUnitSphere * 5;
        
         // GameObject gFloor = Instantiate(Floor);
		 // gFloor.transform.parent = transform;
		 
        // Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);

        // myPrefab.transform.parent = transform.parent;
        // gFloor.transform.localPosition = new Vector3(0,0,0) * fSpacing;

    	int number = Random.Range(1,11);
    	if(number < 5){
    		Vector3 position = new Vector3(Bomb.transform.position.x, Bomb.transform.position.y, Bomb.transform.position.z);
		    GameObject obj = Instantiate(Bomb, new Vector3(0, 0, 0), Quaternion.identity);;
		    obj.transform.localPosition  = transform.position;
		    obj.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
		    obj.transform.parent = transform;
		    obj.SetActive(true);
    	}else{
    		Vector3 position = new Vector3(Point.transform.position.x, Point.transform.position.y, Point.transform.position.z);
		    GameObject obj = Instantiate(Point, new Vector3(0, 0, 0), Quaternion.identity);;
		    obj.transform.localPosition  = transform.position;
		    obj.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
		    obj.transform.parent = transform;
		    obj.SetActive(true);
    	}
        
    }



}
