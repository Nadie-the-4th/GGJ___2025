using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Restart : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Bubble");
    }

    public void BacktoMain()
    {
        Destroy(player);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
