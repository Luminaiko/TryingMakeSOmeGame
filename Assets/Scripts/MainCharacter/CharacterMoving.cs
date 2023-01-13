using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoving : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    
    [SerializeField] private Rigidbody2D rigidbody2d;
    
    private Vector2 _movement;
    
    private Animator _animator;
    
    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        _animator.SetFloat("Horizontal", _movement.x);
        _animator.SetFloat("Vertical", _movement.y);
        _animator.SetFloat("Speed", _movement.magnitude);
        
    }

    private void FixedUpdate() 
    {
        rigidbody2d.MovePosition(rigidbody2d.position + _movement * moveSpeed * Time.fixedDeltaTime);
    }
}
