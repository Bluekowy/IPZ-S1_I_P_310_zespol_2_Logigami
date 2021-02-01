using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playDoorAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Awake()//Może to przez to się naimacja raz na start odapala
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animator.SetBool("Open", true);
    }

    public void CloseDoor()
    {
         animator.SetBool("Open", false);
    }
}
