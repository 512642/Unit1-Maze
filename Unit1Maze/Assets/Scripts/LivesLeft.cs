using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesLeft : MonoBehaviour
{
    GameObject Dead;
    GameObject Lives1;
    GameObject Lives2;
    GameObject Lives3;

    public int Livesleft;
    // Start is called before the first frame update
    void Start()
    {
        Livesleft = GameObject.Find("Player").GetComponent<PlayerMove>().LifeCounter;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
