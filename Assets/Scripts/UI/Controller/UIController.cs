using System;
using UnityEngine;

public class UIController : MonoBehaviour
{
    
    protected void OnNameInputEvent()
    {
        UIManager.instance.CallOnNameInputEvent();
    }

    protected void OnCharacterSelectionEvent(int num )
    {
        UIManager.instance.CallOnSelectionCharacterEvent(num);
    }

    
}