using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private playDoorAnimation door;
    bool isdoor = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (isdoor != true) {
                door.OpenDoor();
                isdoor = true;
            }
            else
            {
                door.CloseDoor();
                isdoor = false;
            }
        }
    }
}

