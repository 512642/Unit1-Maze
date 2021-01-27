using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 3.0f;
    int LifeCounter = 3; // this can be an int as you are only using whole numbers
    //public bool crouched = false;
    public Rigidbody2D rb;
    public Transform spawn;
    bool crouching = false;



    void start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     // Update is called once per frame
    void FixedUpdate()
    {
        EndGame();
        SlowWalk();
        Walking();

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("collided with " + col.gameObject.tag);


        if (col.collider.tag == "Walls")
        {
            transform.position = spawn.position;
            // If your intention is to decrease the lifecounter when the player hits a wall, add your code here.       
            LifeCounter--;
            Debug.Log(LifeCounter);
            


        }
    }
    void SlowWalk()
    {
        if (Input.GetKey("up"))
        {
            crouching = true;
            if (crouching == true)
            {
                float yv = 0;
                float xv = 0;
                if (Input.GetKey("w"))
                {
                    yv = 1;
                }
                if (Input.GetKey("a"))
                {
                    xv = -1;

                }
                if (Input.GetKey("s"))
                {
                    yv = -1;
                }
                if (Input.GetKey("d"))
                {
                    xv = 1;
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
        SlowWalk();


    }

        void EndGame()
        {
            if (LifeCounter == 0)
            {
                Debug.Log("EndGame");
                Application.Quit();
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }

    }