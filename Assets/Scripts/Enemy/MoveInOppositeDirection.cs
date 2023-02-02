using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class MoveInOppositeDirection : MonoBehaviour
{
    private Vector2 _playerCoor;
    private Rigidbody2D _rb;
    private float _speed = 2f;
    private float _activateDistance = 1f; //distance to object

    private void Awake()
    {
        _rb = transform.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        if (Vector2.Distance(_rb.position, PlayerCoor.playerCoor) < _activateDistance)
        {
            
            _rb.velocity = Vector2.zero;
            Destroy(this);
        }
    }
    private void FixedUpdate()
    {
        Vector2 direction = _rb.position - PlayerCoor.playerCoor;
        
        _rb.velocity = direction.normalized * _speed;
    }
}
