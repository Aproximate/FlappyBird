using UnityEngine;

public class BirdSkinRotation : MonoBehaviour
{
    [Range(15f, 35f)]
    [SerializeField] private float _rotateAngle = 25f;
    [SerializeField] private Rigidbody2D _rigidbody;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        float angle = _rotateAngle;

        if (_rigidbody.velocity.y < 0)
            angle *= -1;
        else if (_rigidbody.velocity.y == 0)
            angle = 0;

        var rotation = transform.eulerAngles;
        rotation.z = angle;
        transform.localRotation = Quaternion.Euler(rotation);
    }
}
