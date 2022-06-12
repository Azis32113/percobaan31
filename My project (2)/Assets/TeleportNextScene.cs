using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportNextScene : MonoBehaviour
{

    public Transform SpawnPoint;
    public GameObject DoorPrefabs;
    bool spawn;
    int spawnCounter = 1;
    // Start is called before the first frame update
    void Start()
    {
        spawn = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (spawn == true && spawnCounter >= 1)
        {
            Instantiate(DoorPrefabs, SpawnPoint.position, Quaternion.Euler(0,0,0));
            spawnCounter -= 1;
        }
    }




   public void SummonNextScene()
    {
        spawn = true;
    }
}
