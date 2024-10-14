using TMPro;
using UnityEngine;

public class ChangeNameHandlerByTMP : UIController
{
    private TMP_InputField inputField;
    
    private void Awake()
    {
         inputField =GetComponent<TMP_InputField>();
    }


    private void Start()
    {
        inputField.onEndEdit.AddListener(ChangeName);
    }
    
    private void ChangeName(string name)
    {        
        GameManager.instance.MyPlayer.GetComponent<PlayerInfo>().playerName = name;
        OnNameInputEvent();
    }
    
}