using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TownCharacterController : MonoBehaviour
{
    public Action<Vector2> OnMoveEvent;
    public Action<Vector2> OnLookEvent;
    
    protected void Awake()
    {
    }

    
    protected void CallOnMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    protected void CallOnLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}