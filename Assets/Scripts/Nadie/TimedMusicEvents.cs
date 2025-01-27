using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TimedMusicEvents : MonoBehaviour
{
    public GameObject playerControl;
    public void Start()
    {
        playerControl.GetComponent<playerController>();
    }

    // Start is called before the first frame update
    [YarnCommand("Birth")]
    public void Beginnode() 
    {
        Debug.Log("Birth works!");
        

    }

    [YarnCommand("Question")]
 
       public void Questionnode()
    {
        //AkSoundEngine.PostEvent("Events_SFX_Player_Question", playerControl);
        Debug.Log("Question works!");


    }

   [YarnCommand("Ten")]

       public void Tensecnode() 
    {
        //AkSoundEngine.PostEvent("Events_SFX_Player_10Secs", playerControl);
        Debug.Log("Ten works!");        

    }

//     [YarnCommand("Death")]
//        public static void Deathnode() 
//     {}
        

    
}
