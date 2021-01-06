using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float xSpeed = 3.0f;
    public float ySpeed = 3.0f;
    public float LifeCounter = 3.0f; // this can be an int as you are only using whole numbers

    Rigidbody2D rb;

    // Update is called once per frame

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {

        PlayerControl();

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("collided with " + col.gameObject.tag);
        if (col.gameObject.tag == "Walls")
        {
            // If your intention is to decrease the lifecounter when the player hits a wall, add your code here.
            LifeCounter--;
            // reset player position and display message to say "game over"

        }
    }


    void PlayerControl()
    {
         if (Input.GetKey("w"))
                {
                    //transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);
                    rb.velocity = new Vector2(0, 2.0f);
                }

                if (Input.GetKey("s"))
                {
                    //transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);
                    rb.velocity = new Vector2(0, -2.0f);
                }

                {
                    //transform.position += new Vector3(0, -ySpeed * Time.deltaTime, 0);
                }
                if (Input.GetKey("d"))
                {
                    //transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
                }
                if (Input.GetKey("a"))
                {
                    //transform.position += new Vector3(-xSpeed * Time.deltaTime, 0, 0);
                }
            }
       
    }


    /*
    void Lives()
    {
        if (Col.gameObject.tag == "Walls")
        {
            LifeCounter--;
            Debug.log(LifeCounter);
        }
    }
    */
