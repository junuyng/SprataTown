using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpButton : MonoBehaviour
{
    [SerializeField] private GameObject popupUI;
    private bool isTimeStopped;

    public void ShowPopUpWindow()
    {
        popupUI.SetActive(true);
    }

    public void HidePopUpWindow()
    {
        popupUI.SetActive(false);
    }

    public void StopTime()
    {
        Time.timeScale = 0f;
    }

    public void StartTime()
    {
        Time.timeScale = 1f;
    }
}