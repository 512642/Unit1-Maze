using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float saveSpeed = 3.0f;
    float crouchSpeed = 1.0f;
    public float speed = 3.0f;
    bool collided = false;
    int LifeCounter = 3; // this can be an int as you are only using whole numbers
    //public bool crouched = false;
    public Rigidbody2D rb;
    public Transform spawn;
    bool crouching = false;
    private Animator anim;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        endGame();
        crouch();
        uncrouch();
    }

    void OnCollisionEnter2D(Collision2D col)
    {

       Debug.Log("collided with " + col.gameObject.tag);


        if (col.collider.tag == "Walls")
        {
            collided = true;
            transform.position = spawn.position;
            // If your intention is to decrease the lifecounter when the player hits a wall, add your code here.       
            LifeCounter--;
            Debug.Log(LifeCounter);

            System.Threading.Thread.Sleep(1000);// delays movement for 1s.
        }
    }

    void uncrouch()
    {
        if (Input.GetMouseButtonUp(0))
        {
            crouching = false;
            if(crouching == false)
            {
                speed = saveSpeed;
            }

        }
    }
    void crouch()
    {
    if (Input.GetMouseButtonDown(0))
        {
            crouching = true;
            if (crouching == true)
            {
                speed = crouchSpeed;
            }
        }
    }

    
    
    void endGame()
    {
        if (LifeCounter == 0)
        {
            Debug.Log("EndGame");
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

}