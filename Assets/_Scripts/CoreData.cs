using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoreData : MonoBehaviour
{
    public static int GemsCount;
    public static int CurrentLevel;
    private int _heartsIndex;
    private int _maxLevel;

    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _winPanel;

    [SerializeField] private TMP_Text _levelNumber;

    [SerializeField] private GameObject[] _hearts;

    private void Start()
    {
        Time.timeScale = 1;
        GemsCount = 0;
        _heartsIndex = 0;
        CurrentLevel = PlayerPrefs.GetInt("currentLevel", 1);
    }

    public void LoseHeart()
    {
        _hearts[_heartsIndex].SetActive(false);
        _heartsIndex++;
        if (_heartsIndex == 5)
        {
            _losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void Update()
    {
        _levelNumber.text = $"Level {CurrentLevel}";
        if (GemsCount == 25)
        {
            _winPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (CurrentLevel > _maxLevel)
        {
            _maxLevel = CurrentLevel;
            PlayerPrefs.SetInt("maxLevel", _maxLevel);
        }
    }
}
