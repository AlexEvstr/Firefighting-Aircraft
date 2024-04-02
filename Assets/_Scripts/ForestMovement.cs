using UnityEngine;

public class ForestMovement : MonoBehaviour
{
    private Vector2 _beginningPos;
    private float _middlePoint;
    private float _forestSpeed = 2.1f;

    private void Start()
    {
        _beginningPos = transform.position;
        _middlePoint = GetComponent<BoxCollider2D>().size.x / 2;
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _forestSpeed);
        if (transform.position.x < (_beginningPos.x - _middlePoint))
            transform.position = _beginningPos;
    }
}