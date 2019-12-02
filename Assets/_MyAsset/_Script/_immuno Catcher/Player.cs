using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour {
	public static int PlayerScore = 0;
	public static int Life = 3;
	public GameObject UIControlWin, UIControlLose,Scoremanager;
	private Text Output;
	public string SceneName;
	private GameObject H1,H2,H3;

	private GameObject Popup1,Popup2,Popup3,Popup4;

	public AudioClip SoundHitObject,SoundPoints,SoundCannon;
    public AudioSource ASCannon;
    // Use this for initialization
    void Awake(){
		GameObject Enemy = GameObject.Find("Enemy");
        SpawnerFire SpawnerFireScript1 = Enemy.GetComponent<SpawnerFire>();
		GameObject Enemy1 = GameObject.Find("Enemy1");
        SpawnerFire SpawnerFireScript2 = Enemy1.GetComponent<SpawnerFire>();
		GameObject Enemy2 = GameObject.Find("Enemy2");
        SpawnerFire SpawnerFireScript3 = Enemy2.GetComponent<SpawnerFire>();
        int number = Random.Range(1,4);

        ASCannon = GameObject.Find("ASCannon").GetComponent<AudioSource>();

        if (number == 2){
        	SpawnerFireScript1.const1 = 2;
        	SpawnerFireScript1.const2 = 4;
        	SpawnerFireScript2.const1 = 4;
        	SpawnerFireScript2.const2 = 8;
        	SpawnerFireScript3.const1 = 8;
        	SpawnerFireScript3.const2 = 16;
        }else if(number == 3){
        	SpawnerFireScript3.const1 = 2;
        	SpawnerFireScript3.const2 = 4;
        	SpawnerFireScript1.const1 = 4;
        	SpawnerFireScript1.const2 = 8;
        	SpawnerFireScript2.const1 = 8;
        	SpawnerFireScript2.const2 = 16;
        }else{
        	SpawnerFireScript2.const1 = 2;
        	SpawnerFireScript2.const2 = 4;
        	SpawnerFireScript3.const1 = 4;
        	SpawnerFireScript3.const2 = 8;
        	SpawnerFireScript1.const1 = 8;
        	SpawnerFireScript1.const2 = 16;
        }
	}

	void Start () {
		PlayerScore = 0;
		Life = 3;
		H1 = GameObject.Find("H1");
		H2 = GameObject.Find("H2");
		H3 = GameObject.Find("H3");

		Popup1 = GameObject.Find("Popup1");
		Popup2 = GameObject.Find("Popup2");
		Popup3 = GameObject.Find("Popup3");
		Popup4 = GameObject.Find("Popup4");

		Output = GameObject.Find("Output").GetComponent<Text>();
		Scoremanager = GameObject.Find("Scoremanager");


		Popup1.SetActive (false);
		Popup2.SetActive (false);
		Popup3.SetActive (false);
		Popup4.SetActive (false);

		UIControlWin.SetActive (false);
		UIControlLose.SetActive (false);
		Scoremanager.SetActive(true);

		
	}
	
	// Update is called once per frame
	void Update () {
		// StartSound(1);
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


		if (Input.GetKeyDown("r"))
        {
            Restart();
        }
	}

	public void Restart(){
		Application.LoadLevel(SceneName);
	}


	public void OutputPopup(int NumberPopup){
		int number = 1;
		Popup1.SetActive (false);
		Popup2.SetActive (false);
		Popup3.SetActive (false);
		if(NumberPopup == 1){
			number = Random.Range(1,3);
			if(number == 2){
				NumberPopup = 1;
			}else{
				NumberPopup = 2;
			}
		}

		if(NumberPopup == 1){
			Popup1.SetActive (true);
			Popup2.SetActive (false);
			Popup3.SetActive (false);
			Popup4.SetActive (false);
		}else if(NumberPopup == 2){
			Popup1.SetActive (false);
			Popup2.SetActive (true);
			Popup3.SetActive (false);
			Popup4.SetActive (false);
		}else if(NumberPopup == 3){
			Popup1.SetActive (false);
			Popup2.SetActive (false);
			Popup3.SetActive (true);
			Popup4.SetActive (false);
		}else if(NumberPopup == 4){
			Popup1.SetActive (false);
			Popup2.SetActive (false);
			Popup3.SetActive (false);
			Popup4.SetActive (true);
		}
	}

	public void StartSound(int soundNum)
    {
    	AudioSource audio = GetComponent<AudioSource>();
    	if(soundNum == 1){
    		audio.clip = SoundPoints;
        	audio.Play();
    	}else if(soundNum == 2){
    		audio.clip = SoundHitObject;
        	audio.Play();
    	}else if(soundNum == 3){
            ASCannon.clip = SoundCannon;
            ASCannon.Play();
    	}
        
    }
}
