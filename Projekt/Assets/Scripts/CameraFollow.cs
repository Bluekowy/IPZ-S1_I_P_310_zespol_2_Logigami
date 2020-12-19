using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;
    [Range(0,7)]
    public float offset;

    //variables to specify range of visibility
    static public float x_min = -15;
    static public float x_max = 15;
    static public float y_min = -10;
    static public float y_max = 2;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        // we store current camera's postion in variable temp - temporary position
        Vector3 temp = transform.position;

        // we set the camera's position x to be equal to the player's position x
        temp.x = playerTransform.position.x;
        //this will add the offset value to the temporary camera's position
        temp.x += offset;

        temp.y = playerTransform.position.y;
        temp.y += offset;
        //we set back the camera's temp position to the camera's current position
        transform.position = temp;
    }

 
} //Class

