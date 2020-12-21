using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskHandler : MonoBehaviour
{

    private LevelGrid levelGrid;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Task04.Start\n");
        levelGrid = new LevelGrid(CameraFollow.x_min, CameraFollow.x_max, CameraFollow.y_min, CameraFollow.y_max);
        Debug.Log("After brick construction");
        Clock timer = new GameObject("Timer").AddComponent<Clock>();
    }
}
