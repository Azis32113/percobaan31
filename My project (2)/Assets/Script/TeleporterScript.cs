using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleporterScript : MonoBehaviour
{

    public bool isPrevAllowed = true;

    void OnCollisionEnter2D(Collision2D Collision)
    {
        
        if (Collision.gameObject.CompareTag("TeleporterIn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
