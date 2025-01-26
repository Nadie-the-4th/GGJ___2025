using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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



    public string Beginnode;
    [SerializeField] DialogueRunner Dialogue;


     public string Questionnode;
    [SerializeField] DialogueRunner Dialogue2;
    public string Tensecnode;
    [SerializeField] DialogueRunner Dialogue3;
    
        public string Deathnode;
    [SerializeField] DialogueRunner Dialogue4;


    // public void Interact()
    // {
    //     Dialogue.StartDialogue(StartNode);


    // }

    private IEnumerator TimedDialogue()
    {
        
        yield return new WaitForSeconds(2f);
        Debug.Log("Hello World");
        Dialogue.StartDialogue(Beginnode);
        Debug.Log("Fading the camera!");
        


        yield return new WaitForSeconds(20f);
        Debug.Log("awkwarddddd");
        Dialogue.StartDialogue(Questionnode);

        yield return new WaitForSeconds(40f);
        Debug.Log("10 seconds before death :3");
        Dialogue.StartDialogue(Tensecnode);

        // yield return new WaitForSeconds(300f);
        // Debug.Log("so long, bubble...");
        // Dialogue.StartDialogue(Deathnode);

        
    }

}
