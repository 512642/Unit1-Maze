using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    int yv = 5;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, yv);
    }


    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.collider.tag == "Walls")
        {
            yv = -yv;

        }
    }
}
