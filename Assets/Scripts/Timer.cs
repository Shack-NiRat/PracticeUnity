using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public sealed class Timer : MonoBehaviour
{

    public static Timer Instance {get; private set;}

    public float timeRemaining = 10;

    private bool timerIsRunning = false;
    [SerializeField] private TextMeshProUGUI timeText;



    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        timerIsRunning = true;
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

                SaveScore();

                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            }
        }
    }

    private void SaveScore()
    {
        PlayerPrefs.SetFloat("PlayerScore", ScoreCounter.Instance.Score);
    }

    public void ResetTime()
    {
        timeRemaining = 10;
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}