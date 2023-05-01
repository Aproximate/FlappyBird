using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdJump : MonoBehaviour
{
    [Min(0)]
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}