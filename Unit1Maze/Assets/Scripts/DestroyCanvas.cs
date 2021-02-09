using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCanvas : MonoBehaviour
{
    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    // Update is called once per frame
    void FixedUpdate()
    {

            if (Input.GetKey("escape"))
            {
                GameObject.Destroy(Text);
            }


    }


}


