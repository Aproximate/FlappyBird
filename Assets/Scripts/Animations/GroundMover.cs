using UnityEngine;

public class GroundMover : HorizontalMovingAnimation
{
    [SerializeField] private float _maxOffset;

    private Vector2 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    protected override void Move()
    {
        if (transform.position.x > _maxOffset)
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
        else
        {
            transform.position = _startPosition;
        }
    }
}
