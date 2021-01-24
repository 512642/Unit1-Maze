using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float xv = 0;
        float yv = 0;

        if (Input.GetKey("w"))
        {
            yv = 3;
        }
        if (Input.GetKey("a"))
        {
            xv = -3;    

        }
        if (Input.GetKey("s"))
        {
            yv = -3;
        }
        if (Input.GetKey("d"))
        {
            xv = 3;
        }


        if( (xv == 0) && (yv == 0) )
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }


        // set the x and y velocity
        rb.velocity = new Vector2(xv, yv);



    }
}
