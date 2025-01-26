using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    private Rigidbody2D playerRb;
    private float rotationForce = 3.0f;
    private float moveForce = 80.0f;
    private Vector2 velocity;
    public float bounceForce;
    public GameObject playerSprite;
    public GameObject animateCharacter;
    public Animator animator;


    // Start is called before the first frame update
    private void Awake()
    {
        Instantiate(playerSprite, this.transform);
    }

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        
        animateCharacter = GameObject.FindWithTag("Bubble");


        animator = animateCharacter.GetComponent<Animator>();

        velocity = new Vector2(0.25f, 0f);

       



    }

 

    // Update is called once per frame
    void Update()
    {
        float rotate = Input.GetAxis("Vertical"); //y and b
        playerRb.AddTorque(rotationForce * rotate);



        if (Input.GetKeyDown("k"))
        {
            playerRb.AddForce(transform.right * moveForce);
            animator.SetTrigger("Push");
            AkSoundEngine.PostEvent("Events_SFX_Player_Movement_Moving", this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            playerRb.AddForce(transform.right * (-moveForce* bounceForce));
            AkSoundEngine.PostEvent("Events_SFX_Player_Border", this.gameObject);
        }
    }

    //AUDIO TRIGGERS
    void OnTriggerEnter2D(Collider2D col)
    {
        //AREA ONE
        if (col.gameObject.CompareTag("Area1"))
        {
            Debug.Log("Area1 Boundary");
            AkSoundEngine.PostEvent("Events_Levels_Area1_Start", this.gameObject);
        }

        //AREA TWO
        else if (col.gameObject.CompareTag("Area2"))
        {
            Debug.Log("Area2 Boundary");
            AkSoundEngine.PostEvent("Events_Levels_Area2_Start", this.gameObject);
        }

        //AREA THREE
        else if (col.gameObject.CompareTag("Area3"))
        {
            Debug.Log("Area3 Boundary");
        }
    }

  

}
