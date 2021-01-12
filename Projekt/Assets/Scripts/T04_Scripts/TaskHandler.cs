using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskHandler : MonoBehaviour
{

    private LevelGrid levelGrid;
    private float loopPointMinutes, loopPointSeconds;
    private double time;
    private int nextSource;
    public AudioSource[] musicSources;
    public int musicBPM, timeSignature;
    public float barsLength;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Task04.Start\n");
        levelGrid = new LevelGrid(CameraFollow.x_min, CameraFollow.x_max, CameraFollow.y_min, CameraFollow.y_max);
        Debug.Log("After brick construction");
        Clock timer = new GameObject("Timer").AddComponent<Clock>();
        loopPointMinutes = (barsLength * timeSignature) / musicBPM;

        loopPointSeconds = loopPointMinutes * 60;

        time = AudioSettings.dspTime;

        musicSources[0].Play();
        nextSource = 1;
    }

    void Update()
    {
        if (!musicSources[nextSource].isPlaying)
        {
            time = time + loopPointSeconds;

            musicSources[nextSource].PlayScheduled(time);

            nextSource = 1 - nextSource; //Switch to other AudioSource
        }
    }
}

