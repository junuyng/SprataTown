using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static public UIManager instance { get; private set; }
    
    public event Action  OnNameInput;
    public event Action<int>  OnSelectionCharacter;

    
    private void Awake()
    {
        if (instance != null )
        {
            Destroy(gameObject); 
        }
        
        else
        {
            instance = this;
        }
        
        DontDestroyOnLoad(this);
    }
    
    
    public void CallOnNameInputEvent()
    {
        OnNameInput?.Invoke();
    }

    public void CallOnSelectionCharacterEvent(int num)
    {
        OnSelectionCharacter?.Invoke(num);
    }
    

}