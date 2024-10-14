using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterSelectionController : UIController
{
    private void Start()
    { 
        
    }
    
    public void SelectCharacter(int num)
    {
        OnCharacterSelectionEvent(num);
    }


}