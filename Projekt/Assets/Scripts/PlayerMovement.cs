using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private int collectedObjects = 0;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
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
}
