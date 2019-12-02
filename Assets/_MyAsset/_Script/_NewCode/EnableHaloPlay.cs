using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableHaloPlay : MonoBehaviour
{
    public GameObject HaloPlay;
    // public bool isHaloEnable = false;
    // Use this for initialization
    void Start()
    {
        HaloPlay.SetActive(false);
#if UNITY_STANDALONE && !UNITY_EDITOR
			HaloPlay.SetActive(true);
#endif

        // #if UNITY_STANDALONE_WIN
        //   if(isHaloEnable == false){
        //   	HaloPlay.SetActive(false);
        //   }else{
        //   	HaloPlay.SetActive(true);
        //   }

        // #endif

        //  #if UNITY_EDITOR
        //   HaloPlay.SetActive(false);
        // #endif
    }


}
