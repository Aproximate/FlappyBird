using UnityEngine;

public class TubesVerticalOffset : MonoBehaviour
{
    [SerializeField] private float _maxOffset;

    private void OnEnable()
    {
        SetOffset();
    }

    private void SetOffset()
    {
        var position = transform.position;
        position.y = Random.Range(-_maxOffset, _maxOffset);

        transform.position = position;
    }
}