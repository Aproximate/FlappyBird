using UnityEngine;

public class TubesBreaker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle tube))
        {
            if (collision.transform.parent != null)
                collision.transform.parent.gameObject.SetActive(false);
        }
    }
}