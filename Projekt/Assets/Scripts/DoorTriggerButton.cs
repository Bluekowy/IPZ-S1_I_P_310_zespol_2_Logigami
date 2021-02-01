using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private playDoorAnimation door;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            door.OpenDoor();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            door.CloseDoor();
        }
    }
}

