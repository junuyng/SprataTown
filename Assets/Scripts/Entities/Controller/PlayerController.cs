using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : TownCharacterController
{
    
    [SerializeField] private Camera _camera;
    
    
    
    public void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>().normalized;
        CallOnMoveEvent(direction);
    }

    public void OnLook(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(direction);
        direction = (worldPos - (Vector2)transform.position).normalized;
        CallOnLookEvent(direction);
    }
    
}