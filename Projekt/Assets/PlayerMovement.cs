using UnityEngine;
using Photon.Pun;
public class PlayerMovement : MonoBehaviourPun
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    [HideInInspector]
    public GameController gameController;
    Vector2 movement = Vector2.zero;
    public bool bodyblock = false;
    public Collision2D coli;
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
        if (!bodyblock)
        {
            if (photonView.IsMine)
            {
                rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            }
        }
        else
        {
            Vector2 positionRelative = transform.InverseTransformPoint(coli.transform.position);
            float moveRelative = Vector2.Distance(positionRelative, movement);
            if (photonView.IsMine && moveRelative > 5f)
            {
                rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            bodyblock = true;
            coli = collision;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (bodyblock)
        {
            bodyblock = false;
            coli = null;
        }
    }
}
