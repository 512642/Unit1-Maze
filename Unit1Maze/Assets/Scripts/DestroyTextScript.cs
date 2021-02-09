using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTextScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject DestroyText;
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
                
    }

    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.collider.name == ("Player"))
        {
            Destroy(Canvas);
        }
    }


            // Update is called once per frame
            void FixedUpdate()
    {
        if (GetComponent<PlayerMove>().Destroying ==true)
        {
            GameObject.Destroy(Canvas);
        }
     
    }
}
