using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    private GameObject player;
    static public float x_min;
    static public float x_max;
    static public float y_min;
    static public float y_max;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float camera_x = Mathf.Clamp(player.transform.position.x, x_min, x_max);
        float camera_y = Mathf.Clamp(player.transform.position.y, y_min, y_max);
        gameObject.transform.position = new Vector3(camera_x, camera_y, gameObject.transform.position.z);
    }
}
