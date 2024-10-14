using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : AnimtaionController
{ 
    private readonly int isMove = Animator.StringToHash("isMove");
    private readonly float magnitudeThreshold = 0.5f;

   public RuntimeAnimatorController[] runtimeAnimatorArray;

    
    public void Start()
    {
        controller.OnMoveEvent += Move;
        UIManager.instance.OnSelectionCharacter += ChangeRuntimeAnimatorController;
    }
    
    private void Move(Vector2 value)
    {
        bool isMoving = value.magnitude > magnitudeThreshold;
        animator.SetBool(isMove,isMoving);    
    }
    
    
    public void ChangeRuntimeAnimatorController(int num)
    {
        animator.runtimeAnimatorController = runtimeAnimatorArray[num];
    }

}
