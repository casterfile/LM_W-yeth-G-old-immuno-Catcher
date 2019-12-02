using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFire : MonoBehaviour {

	// Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject Bomb,Point;
    public float const1,const2;
    public Animator Anim_Cannon;
    private float ObjectSize = 1.5f;
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Bomb.SetActive(false);
        Point.SetActive(false);
        // Anim_Cannon = GameObject.Find("PROMILCAN_Anim").GetComponent<Animator>();
        InvokeRepeating("LaunchProjectile", const1, const2);
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
        
        StartCoroutine(PlayAnimation(2.0f));
        Anim_Cannon.SetInteger("AnimationNum", 1);
    	int number = Random.Range(1,11);
    	if(number < 5){
    		Vector3 position = new Vector3(Bomb.transform.position.x, Bomb.transform.position.y, Bomb.transform.position.z);
		    GameObject obj = Instantiate(Bomb, new Vector3(0, 0, 0), Quaternion.identity);
		    obj.transform.localScale = new Vector3(ObjectSize, ObjectSize, ObjectSize);
            obj.transform.localPosition  = transform.position;
            obj.transform.parent = transform;
            obj.transform.localRotation = Quaternion.Euler(Point.transform.localRotation.x, Point.transform.localRotation.y, Point.transform.localRotation.z);
		    obj.SetActive(true);
    	}else{
    		Vector3 position = new Vector3(Point.transform.position.x, Point.transform.position.y, Point.transform.position.z);
		    GameObject obj = Instantiate(Point, new Vector3(0, 0, 0), Quaternion.identity);
		    obj.transform.localPosition  = transform.position;
		    obj.transform.localScale = new Vector3(ObjectSize, ObjectSize, ObjectSize);
            obj.transform.parent = transform;
            obj.transform.localRotation = Quaternion.Euler(Point.transform.localRotation.x, Point.transform.localRotation.y, Point.transform.localRotation.z);
		    obj.SetActive(true);
    	}
        
    }

    IEnumerator PlayAnimation(float Delay)
    {
        GameObject Canvas = GameObject.Find("Canvas");
        Player PlayerScript = Canvas.GetComponent<Player>();

        PlayerScript.StartSound(3);
        yield return new WaitForSeconds(Delay);
        Anim_Cannon.SetInteger("AnimationNum", 2);
    }

}
