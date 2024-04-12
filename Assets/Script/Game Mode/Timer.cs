using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    private Score other;
    public float targetTime = 60.0f;
    public TMP_Text valueText;
    public string sceneName;
    public GameObject scoremenu;
    
    void Start()
    {
        targetTime = 60;
        Time.timeScale = 1;
    }

    void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

        UpdateTime();
    }

    void timerEnded()
    {
        Timesup();
    }

    void UpdateTime()
    {
        
        float value = targetTime;

        valueText.text = value.ToString("0");

    }

    public void Timesup()
    {
        scoremenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
        PlayerController.points = 0;
    }

    public void Restart(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
        PlayerController.points = 0;
    }
} 

