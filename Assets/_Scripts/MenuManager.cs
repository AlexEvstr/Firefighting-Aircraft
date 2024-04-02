using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private int _maxLevel;
    [SerializeField] private GameObject[] _levels;

    private void Start()
    {
        _maxLevel = PlayerPrefs.GetInt("maxLevel", 1);
        CheckLevels();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void CheckLevels()
    {
        for (int i = 0; i < _levels.Length; i++)
        {
            if (int.Parse(_levels[i].gameObject.name) <= _maxLevel)
            {
                _levels[i].GetComponent<Button>().enabled = true;
                _levels[i].GetComponent<Image>().color = new Color(1,1,1,1);
            }
            else
            {
                _levels[i].GetComponent<Button>().enabled = false;
                _levels[i].GetComponent<Image>().color = Color.grey;
            }
        }
    }

}
