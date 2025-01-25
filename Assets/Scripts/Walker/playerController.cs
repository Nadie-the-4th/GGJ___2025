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
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0.25f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float rotate = Input.GetAxis("Vertical"); //y and b
        playerRb.AddTorque(rotationForce * rotate);

        if (Input.GetKeyDown("space"))
        {
            playerRb.AddForce(transform.right * moveForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            playerRb.AddForce(transform.right * (-moveForce* bounceForce));
        }
    }

    //if we decide to wrap the world
    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    Debug.Log("hit wall!!");
    //    playerRb.AddForce(transform.right * -moveForce);
    //}

}
