using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 400f;
    
    private Animator _animator;
    
    private Rigidbody2D _rigidbody2D;

    private Vector2 _movement;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        _animator.SetFloat("Speed", _movement.magnitude);
        _animator.SetFloat("Horizontal", _movement.x);
        _animator.SetFloat("Vertical", _movement.y);
        
        if (_movement.x == 1 || _movement.x == -1 || _movement.y == 1 || _movement.y == -1)
        {
            _animator.SetFloat("LastMovementHorizontal", _movement.x);
            _animator.SetFloat("LastMovementVertical", _movement.y);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = _movement * speed * Time.fixedDeltaTime;
    }
}
