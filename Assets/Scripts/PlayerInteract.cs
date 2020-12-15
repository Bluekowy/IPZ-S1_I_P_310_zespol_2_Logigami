using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.tag=="interObject")
        {
            Debug.Log("dotknieto " + other.name);
        }
    }
}
