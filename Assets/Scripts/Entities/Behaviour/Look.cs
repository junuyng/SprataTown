using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    private TownCharacterController controller;
    private Vector2 direction;
    [SerializeField] private SpriteRenderer spriteRenderer; 
    
    
    private void Awake()
    {
        controller = GetComponent<TownCharacterController>();
    }

    private void Start()
    {
        controller.OnLookEvent += SetDirection;
    }
    
    private void Update()
    {
        Flip();
    }
    
    private void Flip()
    {
        if (direction.x < 0)
            spriteRenderer.flipX = true;
        else
            spriteRenderer.flipX = false;
    }

    
    private void SetDirection(Vector2 value)
    {
        direction = value;
    }

    
}
