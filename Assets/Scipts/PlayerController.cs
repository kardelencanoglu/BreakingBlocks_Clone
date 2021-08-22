using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
       Vector3 mousePos  = Camera.main.ScreenToWorldPoint(new Vector3 (
           Input.mousePosition.x,
           transform.position.y,
           transform.position.z
       ));

       mousePos.x = Mathf.Clamp(mousePos.x, -4.33f, 4.33f);
       
       transform.position = new Vector3(
           mousePos.x,
           transform.position.y,
           transform.position.z
       );
    }
}
