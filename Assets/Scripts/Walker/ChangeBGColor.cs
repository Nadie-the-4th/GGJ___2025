using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGColor : MonoBehaviour
{
    public float yInput;
    public float xInput;
    Animator BGColors;
    // Start is called before the first frame update
    void Start()
    {
        BGColors = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("p"))
        //{
        //    BGColors.SetTrigger("Pink");
        //}

        //if (Input.GetKeyDown("b"))
        //{
        //    BGColors.SetTrigger("Blue");
        //}

        //if (Input.GetKeyDown("u"))
        //{
        //    BGColors.SetTrigger("Purple");
        //}

        float yInput = Input.GetAxis("Vertical"); //y and b
        float xInput = Input.GetAxis("Horizontal");

        BGColors.SetFloat("yInput", Mathf.Abs(yInput));
        BGColors.SetFloat("xInput", Mathf.Abs(xInput));

    }
}
