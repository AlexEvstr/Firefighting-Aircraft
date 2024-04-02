using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollision : MonoBehaviour
{
    [SerializeField] private GameObject _waterSplash;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            CoreData.GemsCount++;

            GameObject waterSplash = Instantiate(_waterSplash);
            waterSplash.transform.position = new Vector2(collision.transform.position.x, collision.transform.position.y - collision.gameObject.GetComponent<BoxCollider2D>().size.y);
            Destroy(waterSplash, 0.5f);


            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
