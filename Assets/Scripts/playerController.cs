using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    private Rigidbody2D playerRb;
    private float speed = 5.0f;
    private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(0.25f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float rotate = Input.GetAxis("Vertical");
        float move = Input.GetAxis("Horizontal");

        playerRb.MoveRotation(playerRb.rotation + speed * rotate);
        playerRb.MovePosition(playerRb.position + velocity * move);
    }
}
