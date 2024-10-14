using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private TownCharacterController controller;
    private Vector2 movementDirection;
    private Rigidbody2D rb;
    [SerializeField]private float speed = 12f;

    
    private void Awake()
    {
        controller = GetComponent<TownCharacterController>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += SetMovementDirection;
    }

    
    private void FixedUpdate()
    {
        Move(movementDirection);
    }

    private void SetMovementDirection(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void Move(Vector2 direction)
    {
        rb.velocity = direction * speed;
    }

}