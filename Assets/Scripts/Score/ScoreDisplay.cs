using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private Score _score;

    [Space]
    [SerializeField] private UnityEvent OnUpdateScoreDisplay;

    private void OnEnable()
    {
        UpdateText(0);
        _score.OnScoreChanged += UpdateText;
    }
    private void OnDisable() => _score.OnScoreChanged -= UpdateText;

    private void UpdateText(int scoreCount)
    {
        _scoreText.text = scoreCount.ToString();

        if (scoreCount > 0)
            OnUpdateScoreDisplay?.Invoke();
    }
}