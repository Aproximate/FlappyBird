using UnityEngine;
using UnityEngine.Events;

public class GameLoss : MonoBehaviour
{
    [SerializeField] private UnityEvent _onLosed;

    public bool IsLosed { get; private set; }

    public void TryDoLose()
    {
        if (IsLosed == false)
        {
            _onLosed?.Invoke();
            IsLosed = true;
        }
    }
}