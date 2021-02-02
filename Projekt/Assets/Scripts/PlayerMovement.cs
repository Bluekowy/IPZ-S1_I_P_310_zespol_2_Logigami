using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.EventSystems;
public class PlayerMovement : MonoBehaviourPun
{
    private int collectedObjects = 0;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public GameController gameController;
    //public GameObject Chat;
    //public bool IsChatActive { get { return Chat.activeInHierarchy; } }
    //Chat.GetComponent<Canvas>().enabled = false;
    //public GameObject[] IsChatActive = GameObject.FindGameObjectsWithTag("chat");
    //private bool canMove;
    public bool canMove = true;
    void Update()
    {
        //canMove = gameController.canMove;
        if (photonView.IsMine) //&& !gameController.IsChatActive)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canMove)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else if (!canMove)
        {
            rb.velocity = Vector2.zero;
            return;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Brick")
        {
            collectedObjects++;
            Debug.Log("Hit brick trigger!");
            Destroy(other.gameObject);
            if (collectedObjects == LevelGrid.NO_BRICKS)
            {
                NetworkController.taskDone4 = true;
                --NetworkController.activeTaskCnt;
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    /*public void OnPointerDown(PointerEventData eventData)
    {
         pressed = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
         pressed = true;
    }*/
}
