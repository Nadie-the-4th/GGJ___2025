using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TimedMusicEvents : MonoBehaviour
{
    public GameObject playerControl;

    // Start is called before the first frame update
    [YarnCommand("Birth")]

    // Start is called before the first frame update
    public void Start()
    {
        playerControl.GetComponent<playerController>();
    }

    public static void Beginnode() 
    {
        Debug.Log("Birth works!");
        

    }

    [YarnCommand("Question")]
 
       public static void Questionnode()
    {
        AkSoundEngine.PostEvent("Events_SFX_Player_Question", playerControl);
        Debug.Log("Question works!");


    }

   [YarnCommand("Ten")]

       public static void Tensecnode() 
    {
        Debug.Log("Ten works!");        

    }

//     [YarnCommand("Death")]
//        public static void Deathnode() 
//     {}
        

    
}
