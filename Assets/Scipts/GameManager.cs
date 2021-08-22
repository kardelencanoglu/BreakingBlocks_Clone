using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Scene libary

public class GameManager : MonoBehaviour
{
    public Transform ball; 

    public Transform cam;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkBallPos(); //call
    }

    private void checkBallPos()
    {
        if(ball.position.y <= cam.position.y - 4f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
