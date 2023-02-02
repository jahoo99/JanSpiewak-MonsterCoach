using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 _screenBounds;
    private SpriteRenderer _sr;
    private Vector2 _objectSize;
    void Awake()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        _sr = GetComponent<SpriteRenderer>();
        _objectSize.x = _sr.bounds.size.x/2;
        _objectSize.y = _sr.bounds.size.y/2;
    }
    void LateUpdate()
    {
        Vector3 playerCoor = transform.position;
        playerCoor.y = Mathf.Clamp(playerCoor.y, _screenBounds.y * -1 + _objectSize.y, _screenBounds.y - _objectSize.y);
        playerCoor.x = Mathf.Clamp(playerCoor.x, _screenBounds.x * -1 + _objectSize.x, _screenBounds.x - _objectSize.x);
        transform.position = playerCoor;
    }
}
