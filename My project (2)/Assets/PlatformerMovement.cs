using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //Movement
    public float speed;
    public float jump;
    public int jumpCount;
    public int jumpAdder;
    float moveVelocity;

    //Grounded Vars
    bool grounded = false;

    void Update()
    {
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (grounded == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                jumpCount--;

                if (jumpCount <= 0)
                {
                    grounded = false;
                    jumpCount = jumpAdder;
                }

                
            }
             
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    }
    //Check if Grounded
    void OnCollisionEnter2D (Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            
        }

    }
    
}
