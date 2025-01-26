using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class CharacterMovement : MonoBehaviour 
{

    [YarnCommand("jump")]
    public void Jump() 
    {
        Debug.Log("Jumping!");
    }
}
