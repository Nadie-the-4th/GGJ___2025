using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class FadeCamera : MonoBehaviour
{

    [YarnCommand("fade_camera")]
    public static void FadeCamra() 
    {
        Debug.Log("Fading the camera!");
    }
}