using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Rigidbody2D _rb;
    private float _movementY;
    private float _movementX;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        PlayerCoor.playerCoor = _rb.position;
        
        _movementY = Input.GetAxisRaw("Vertical");
        _movementX = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + new Vector2(_movementX, _movementY) * _moveSpeed * Time.fixedDeltaTime); 
    }
}
