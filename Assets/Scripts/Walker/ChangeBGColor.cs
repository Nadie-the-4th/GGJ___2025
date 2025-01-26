using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGColor : MonoBehaviour
{
    Animator BGColors;
    // Start is called before the first frame update
    void Start()
    {
        BGColors = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            BGColors.SetTrigger("Pink");
        }

        if (Input.GetKeyDown("b"))
        {
            BGColors.SetTrigger("Blue");
        }
    }
}
