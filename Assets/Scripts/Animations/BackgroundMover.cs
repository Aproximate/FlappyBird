using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class BackgroundMover : HorizontalMovingAnimation
{
    private RawImage _image;

    private void Start()
    {
        _image = GetComponent<RawImage>();
    }

    protected override void Move()
    {
        var rect = _image.uvRect;

        if (rect.x >= 1)
            rect.x = 0;

        rect.x += _speed * Time.deltaTime;
        _image.uvRect = rect;
    }
}