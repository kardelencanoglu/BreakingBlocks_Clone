using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       rb.AddForce(Vector3.up * 300f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
