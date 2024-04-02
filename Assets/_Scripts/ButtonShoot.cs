using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShoot : MonoBehaviour
{
    [SerializeField] private GameObject _waterShot;
    [SerializeField] private GameObject _helicopter;

    public void ShootWater()
    {
        GameObject water = Instantiate(_waterShot);
        water.transform.position = new Vector2(_helicopter.transform.position.x,
                                               _helicopter.transform.position.y);
    }
}
