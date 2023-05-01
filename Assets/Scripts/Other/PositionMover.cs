using UnityEngine;

public class PositionMover : MonoBehaviour
{
    [Min(0)]
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _moveVector;

    private GameLoss _gameLoss;

    private void Start()
    {
        _gameLoss = FindObjectOfType<GameLoss>();
    }

    private void Update()
    {
        if (_gameLoss.IsLosed == false)
            transform.Translate(_moveVector * _speed * Time.deltaTime);
    }
}