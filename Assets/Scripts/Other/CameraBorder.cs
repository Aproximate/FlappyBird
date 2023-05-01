using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraBorder : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = GetComponent<Camera>();
    }

    public Vector2 Size
    {
        get
        {
            var border = new Vector2(Screen.width, Screen.height);
            return _camera.ScreenToWorldPoint(border);
        }
    }

    public Vector2 SizePerObject(Transform transform)
    {
        return Size - ((Vector2)transform.localScale / 2);
    }

    public void LimitPositionInBorder(Transform transform)
    {
        Vector2 position = transform.position;
        Vector2 border = SizePerObject(transform);

        position.x = Mathf.Clamp(position.x, -border.x, border.x);
        position.y = Mathf.Clamp(position.y, -border.y, border.y);
        
        transform.position = position;
    }
}