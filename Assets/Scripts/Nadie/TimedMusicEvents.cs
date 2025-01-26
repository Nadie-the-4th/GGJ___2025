using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TimedMusicEvents : MonoBehaviour
{
    // Start is called before the first frame update
    [YarnCommand("Birth")]

    public static void Beginnode() 
    {
        Debug.Log("Birth works!");

    }

    [YarnCommand("Question")]
 
       public static void Questionnode()
    {
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
