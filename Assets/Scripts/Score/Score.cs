using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public bool IsNewBest { get; private set; }
    public int Count => _count;
    public int Best => _best;

    public event UnityAction<int> OnScoreChanged;

    private int _count;
    private int _best;

    private void Awake()
    {
        _best = PlayerPrefs.GetInt("Best");
    }

    public void Increase(int count)
    {
        if (count <= 0)
            return;

        _count += count;
        TrySetBest();
        OnScoreChanged?.Invoke(_count);
    }

    private void TrySetBest()
    {
        if (_count > _best)
        {
            _best = _count;
            IsNewBest = true;
            PlayerPrefs.SetInt("Best", _best);
        }
    }
}