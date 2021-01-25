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
    float xv = 3;
    float yv = 3;



    void start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

     // Update is called once per frame
    void FixedUpdate()
    {
        EndGame();
        SlowWalk();
        NormalWalk();
        Walking();

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
            


        }
    }

    void NormalWalk()
    {
        if (Input.GetMouseButtonUp(0))
        {
            print("uncrouching");
            crouching = false;
            if (crouching == false)
            {
                yv = 0;
                xv = 0;
                rb.velocity = new Vector2(xv, yv);
            }

        }
    }
    void SlowWalk()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("crouching");
            crouching = true;
            if (crouching == true)
            {
                yv = -+1;
                xv = -+1;

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