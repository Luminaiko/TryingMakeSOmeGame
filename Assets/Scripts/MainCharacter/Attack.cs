using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            AttackEnemy();
        }
    }

    private void AttackEnemy()
    {
        _animator.SetTrigger("Attack_No_Weapon");
    }
    
}
