using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    [SerializeField] private CoreData _coreData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire") || collision.gameObject.CompareTag("Water"))
        {
            _coreData.LoseHeart();
        }
    }
}
