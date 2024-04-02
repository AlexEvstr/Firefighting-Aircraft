using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayButtons : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    public void PauseGame()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void NextLevel()
    {
        CoreData.CurrentLevel++;
        PlayerPrefs.SetInt("currentLevel", CoreData.CurrentLevel);
        SceneManager.LoadScene("SampleScene");
    }
}
