using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 3.0f;
    public int LifeCounter = 3; // this can be an int as you are only using whole numbers
    //public bool crouched = false;
    public Rigidbody2D rb;
    public Transform spawn;
    bool Sprinting = false;
    public Transform DestroyText;
    public bool Destroying = false;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     // Update is called once per frame
    void FixedUpdate()
    {
        EndGame();
        Sprint();
        Walking();

    }

    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.collider.tag == "Chaser" )
        {
            transform.position = spawn.position;
            // If your intention is to decrease the lifecounter when the player hits a wall, add your code here.       
            LifeCounter--;
            Debug.Log(LifeCounter);
            
        }
    }
    void Sprint()
    {
        if (Input.GetKey("space"))
        {
            Sprinting = true;
            if (Sprinting == true)
            {
                float yv = 0;
                float xv = 0;
                if (Input.GetKey("w"))
                {
                    yv = 5;
                }
                if (Input.GetKey("a"))
                {
                    xv = -5;

                }
                if (Input.GetKey("s"))
                {
                    yv = -5;
                }
                if (Input.GetKey("d"))
                {
                    xv = 5;
                }
                rb.velocity = new Vector2(xv, yv);
            }
        }
    }

        void Walking()
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
                // set the x and y velocity
             rb.velocity = new Vector2(xv, yv);
        Sprint();

        
    }



    void EndGame()
        {
            if (LifeCounter == 0)
            {
                Debug.Log("EndGame");
                Application.Quit();
            }
        }

    }