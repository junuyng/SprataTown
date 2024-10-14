using System;
using UnityEngine;
using UnityEngine.UI;

public class DialogueProvider : MonoBehaviour
{
    [SerializeField] private string dialogueContent;
    [SerializeField] private string providerName;

    [SerializeField] private Text dialogueText;
    [SerializeField] private Text dialogueProviderNameText;

    private void Start()
    {
        if (GetComponent<PlayerInfo>() != null)
              providerName = GetComponent<PlayerInfo>().playerName;
    }


    public void SetDialogueText()
    {
        dialogueProviderNameText.text = providerName;
        dialogueText.text = dialogueContent;
    }
}