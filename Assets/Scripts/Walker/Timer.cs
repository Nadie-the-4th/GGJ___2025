using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeValue;
    public TMP_Text timeText;
    public bool timesUp;
    public GameObject playerAnim;
    public Animator animate;
    public GameObject fullPlayer;
    public GameObject locator;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GameObject.FindWithTag("Bubble");
        animate = playerAnim.GetComponentInChildren<Animator>();


        locator = GameObject.FindWithTag("Locator");
        timeValue = 300;
        timesUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime; //minus the duration of the last frame
            timesUp = false;
        }

        else
        {
            timeValue = 0;
            timesUp = true;
            animate.SetBool("TimeUp", true);
            BubblePop();
            AkSoundEngine.PostEvent("Events_SFX_Player_Death", this.gameObject); 
        }

        displayTime(timeValue);
    }

    void displayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0 )
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); //round equation to nearest whole number
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); //modular calculation takes 60 away and shows the remainder

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); //left of colon formats 1st variable, right formats 2nd
            

    }

    public void BubblePop()
    {
        Destroy(locator);
        StartCoroutine(ExampleCoroutine());
       
    }


    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);

        //After we have waited 5 seconds print the time again.
        Destroy(playerAnim);
        Debug.Log("Player Destroyed");
      
    }
}
