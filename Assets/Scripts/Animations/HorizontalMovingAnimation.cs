using UnityEngine;

public abstract class HorizontalMovingAnimation : MonoBehaviour
{
    [Min(0)]
    [SerializeField] protected float _speed;

    protected bool _isActivatedMove;

    private void Update()
    {
        if (_isActivatedMove)
            Move();
    }

    public void MoveAcivated(bool isActivated)
    {
        _isActivatedMove = isActivated;
    }

    protected abstract void Move();
}
