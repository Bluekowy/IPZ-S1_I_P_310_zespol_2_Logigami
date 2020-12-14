using UnityEngine;
using Photon.Pun;
public class PlayerMovement : MonoBehaviourPun
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    [HideInInspector]
    public GameController gameController;
    Vector2 movement;
    void Update()
    {
        //if (photonView.IsMine && !gameController.IsChatActive)
        if (photonView.IsMine)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (photonView.IsMine)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
