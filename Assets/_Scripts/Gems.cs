using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gems : MonoBehaviour
{
    [SerializeField] private TMP_Text _gemsText;


    private void Update()
    {
        _gemsText.text = $"{CoreData.GemsCount}/25";
    }
}
