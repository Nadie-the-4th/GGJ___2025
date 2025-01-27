using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        AkSoundEngine.PostEvent("Events_Game_MainMenu", this.gameObject);
    }
    public void PlayGame()
    {
        AkSoundEngine.PostEvent("Events_Game_MainMenu_Stop", this.gameObject);
        AkSoundEngine.PostEvent("Events_Game_Start", this.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
