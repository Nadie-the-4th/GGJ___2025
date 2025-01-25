using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    private Rigidbody2D playerRb;
    private float rotationForce = 3.0f;
    private float moveForce = 100.0f;
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
        float rotate = Input.GetAxis("Vertical"); //y and b
        playerRb.AddTorque(rotationForce * rotate);

        if (Input.GetKeyDown("space"))
        {
            playerRb.AddForce(transform.right * moveForce);
        }
    }

    void FixedUpdate()
    {
        
            //float move = Input.GetAxis("Horizontal"); //space bar push

        
       

        //playerRb.MoveRotation(playerRb.rotation + speed * rotate);
        //playerRb.MovePosition(playerRb.position + velocity * move); 

        //playerRb.AddForce(transform.up * speed * move, ForceMode2D.Impulse);

        //take force and multiply it by up rigibbody.addForce(transform.right * force), lowercase transform.up

        //rigidbody.addtorque(f)

        //put camera into Late iupdate

    }
}
