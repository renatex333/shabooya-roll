using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour

{
    public float timeRemaining = 80;
    public TextMeshProUGUI timerText;

    private int minutes;
    private int seconds;

    void Update()
    {
        if (timeRemaining <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
        timeRemaining -= Time.deltaTime;

        minutes = Mathf.FloorToInt(timeRemaining / 60);
        seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

    }

}
