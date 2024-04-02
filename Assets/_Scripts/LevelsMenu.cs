using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public void SelectLevel()
    {
        PlayerPrefs.SetInt("currentLevel", int.Parse(gameObject.name));
        SceneManager.LoadScene("SampleScene");
    }
}
