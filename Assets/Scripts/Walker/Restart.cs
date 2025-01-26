using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Restart : MonoBehaviour
{
    public GameObject player;
    public GameObject playerControl;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Bubble");
    }

    public void BacktoMain()
    {
        AkSoundEngine.PostEvent("Events_Game_MainMenu", playerControl);
        Destroy(player);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
