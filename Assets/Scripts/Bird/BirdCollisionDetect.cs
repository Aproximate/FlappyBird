using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdCollisionDetect : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private GameLoss _gameLoss;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            _gameLoss.TryDoLose();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out ScoreUpTrigger scoreUpTrigger))
        {
            _score.Increase(1);
        }
    }
}