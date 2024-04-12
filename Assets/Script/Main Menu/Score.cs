using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject ScoreMenu;

    public void Timesup()
    {
        ScoreMenu.SetActive(true);
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
