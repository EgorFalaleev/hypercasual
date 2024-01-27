using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoundController : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private Collider2D _collider;
    private Vector2 _screenBounds;
    private Vector2 _objectExtents;

    void Start()
    {
        _collider = GetComponent<Collider2D>();

        // get half the size of object
        _objectExtents = new Vector2(_collider.bounds.extents.x, _collider.bounds.extents.y);

        _screenBounds = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, _camera.transform.position.z));
    }

    private void LateUpdate()
    {
        BoundMovement();
    }

    private void BoundMovement()
    {
        Vector3 clampedPosition = transform.position;

        // prevent object from moving off screen
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -_screenBounds.x + _objectExtents.x, _screenBounds.x - _objectExtents.x);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -_screenBounds.y + _objectExtents.y, _screenBounds.y - _objectExtents.y);

        transform.position = clampedPosition;
    }
}
