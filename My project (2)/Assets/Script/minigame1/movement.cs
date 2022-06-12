using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float MovementSpeed = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
     var movement = Input.GetAxis("Horizontal");
     transform.position += new Vector3 (movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (movement == 0)
        {
            rb.velocity = new Vector2(0, 0);
        }

    }

    
        
        
        //if player di scene gamecather, dia teleport balik ke checkpoint terakhir
        
    
    

}
