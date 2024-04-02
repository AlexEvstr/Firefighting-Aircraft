using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _fire;

    private void Start()
    {
        StartCoroutine(SpawnFire());
    }

    private IEnumerator SpawnFire()
    {
        while (true)
        {
            GameObject fire = Instantiate(_fire);
            fire.transform.position = new Vector2(15, -3);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        }
    }
}
