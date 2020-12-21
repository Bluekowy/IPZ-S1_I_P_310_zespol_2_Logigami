using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{
    public float timeRemaining = 15;
    public bool timerIsRunning = false;
    private TextMesh timeText;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        timeText = gameObject.AddComponent<TextMesh>();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                SceneManager.LoadScene("Task_04");
            }
        }
    }

    public void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float miliSeconds = (timeToDisplay % 1) * 1000;
        timeText.GetComponent<TextMesh>();
        timeText.color = Color.red;
        timeText.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
        timeText.fontSize = 40;
        Vector2 temp = new Vector2(10, -4);
        timeText.transform.position = temp;
        timeText.text = string.Format("{0:00}", seconds);
    }
}
