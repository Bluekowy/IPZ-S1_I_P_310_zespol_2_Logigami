using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
       Debug.Log("You've entered the trigger!");
       if (Input.GetKey(KeyCode.E))
          {
            string task_scene = this.gameObject.name.Substring(0,7);
            ++NetworkController.activeTaskCnt;
            SceneManager.LoadScene(task_scene);
          }
    }
}
