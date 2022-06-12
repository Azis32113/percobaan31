using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeOilCollision : MonoBehaviour
{

    [SerializeField]
    private FloatSO ScoreSO;

    void OnCollisionEnter2D(Collision2D Collision)
    {
        
        if (Collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }

        else
        {
            ScoreSO.Value -= 10;
            Destroy(gameObject);
        }

    }

}