using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviourPun
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    [HideInInspector]
    public GameController gameController;
    Vector2 movement;
    private int collected_objects = 0;
    private TextMesh winText;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Brick")
        {
            collected_objects++;
            Debug.Log("Hit trigger! " + collected_objects);
            Destroy(other.gameObject);
            if(collected_objects == LevelGrid.NO_BRICKS)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
