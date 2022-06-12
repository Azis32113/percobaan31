using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //Component
    Rigidbody2D rb;

    //Player
    public float walkSpeed = 4f;
    public float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertical;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical"); ;
    }

    private void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            rb.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertical * walkSpeed);

            if (inputHorizontal != 0 && inputVertical != 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertical *= speedLimiter;
            }
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}