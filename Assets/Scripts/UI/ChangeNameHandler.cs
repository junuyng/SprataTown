using UnityEngine.UI;

public class ChangeNameHandler : UIController
{
    private InputField inputField;
    
    private void Awake()
    {
        inputField =GetComponent<InputField>();
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