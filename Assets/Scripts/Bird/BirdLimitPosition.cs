using UnityEngine;

public class BirdLimitPosition : MonoBehaviour
{
    [SerializeField] private CameraBorder _border;

    private void Update()
    {
        _border.LimitPositionInBorder(transform);
    }
}