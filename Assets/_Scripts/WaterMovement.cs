using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    private float _waterSpeed = 10.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * Time.deltaTime * _waterSpeed);
    }
}
