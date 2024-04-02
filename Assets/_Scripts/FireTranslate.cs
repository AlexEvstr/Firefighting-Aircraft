using UnityEngine;

public class FireTranslate : MonoBehaviour
{
    private float _fireSpeed = 3.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _fireSpeed);
    }
}