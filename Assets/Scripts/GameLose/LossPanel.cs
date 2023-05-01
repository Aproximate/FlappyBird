using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LossPanel : MonoBehaviour
{
    [Header("Main")]
    [SerializeField] private Score _score;

    [Space]
    [Header("Text")]
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _bestText;

    [Space]
    [Header("Medal")]
    [SerializeField] private Image _medalImage;
    [SerializeField] private Sprite _goldMedal;
    [SerializeField] private Sprite _silverMedal;

    [Space]
    [Header("New Best Image")]
    [SerializeField] private Image _newBestImage;

    private void OnEnable()
    {
        _scoreText.text = _score.Count.ToString();
        _bestText.text = _score.Best.ToString();

        if(_score.Count >= _score.Best)
        {
            _medalImage.sprite = _goldMedal;
        }
        else if(_score.Count >= _score.Best / 2)
        {
            _medalImage.sprite = _silverMedal;
        }
        else
        {
            _medalImage.color = new Color(0, 0, 0, 0);
        }

        _newBestImage.gameObject.SetActive(_score.IsNewBest);
    }
}