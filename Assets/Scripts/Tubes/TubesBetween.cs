using UnityEngine;

public class TubesBetween : MonoBehaviour
{
    [Header("Between Settings")]
    [Min(0.5f)]
    [SerializeField] private float _minBetween;
    [Min(0.5f)]
    [SerializeField] private float _maxBetween;

    [Space]
    [Header("Links")]
    [SerializeField] private BoxCollider2D _trigger;
    [SerializeField] private GameObject _upTube;
    [SerializeField] private GameObject _downTube;
    
    private void OnEnable()
    {
        SetBetween();
    }

    private void SetBetween()
    {
        var fullBetween = Random.Range(_minBetween, _maxBetween);
        var halfBetween = fullBetween / 2;
       
        _upTube.transform.localPosition = Vector2.up * halfBetween;
        _downTube.transform.localPosition = Vector2.down * halfBetween;

        var triggerSize = _trigger.size;
        triggerSize.y = fullBetween;
        _trigger.size = triggerSize;
    }
}