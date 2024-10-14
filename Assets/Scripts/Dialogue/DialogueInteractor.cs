using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteractor : MonoBehaviour
{
    [SerializeField] private GameObject startDialogueButton;


    private void OnTriggerEnter2D(Collider2D other)
    {
        DialogueProvider provider = other.GetComponentInChildren<DialogueProvider>();

        if (provider != null)
        {
            provider.SetDialogueText();
            startDialogueButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        startDialogueButton.SetActive(false);
    }
}