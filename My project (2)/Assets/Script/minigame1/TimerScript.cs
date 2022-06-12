using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public static int ScoreValue;
    public float TimeLeft = 10.0f;
    
    int seconds;
    float minutes;
    Text Timer;

    public EnemySpawner Spawner;
    public TeleportNextScene Teleporter;
    private bool HasReached;

    // Start is called before the first frame update
    void Start()
    {
        Timer = GetComponent<Text>();
        HasReached = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HasReached == false)
        {
            TimeLeft -= 1 * Time.deltaTime;
        }
                    
        seconds = (int)(TimeLeft % 60);
        minutes = Mathf.Floor(TimeLeft/60);

        Timer.text = "timer: " + minutes + ":"+ seconds;

        if (TimeLeft <= 0)
        {
            Spawner.StopSpawning();
            HasReached = true;
            TimeLeft = 0;

            //keluar pintu ajaib menuju next stage
            Teleporter.SummonNextScene();
        }
             
    }
}