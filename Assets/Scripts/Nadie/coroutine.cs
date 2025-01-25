using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimedDialogue());
    }

    public string StartNode;
    [SerializeField] DialogueRunner Dialogue;

    // public void Interact()
    // {
    //     Dialogue.StartDialogue(StartNode);


    // }

    private IEnumerator TimedDialogue()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Hi");
        Dialogue.StartDialogue(StartNode);


        yield return new WaitForSeconds(145f);
        Debug.Log("Hey");
    }

}
