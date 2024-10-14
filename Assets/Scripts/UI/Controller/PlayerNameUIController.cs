using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameUIController : UIController
{
    [SerializeField]private Text nameText;
    [SerializeField]private RectTransform namePanelRectTransform;
    [SerializeField] private float paddingRatio = 1.5f;

    private Transform targetPos;
 
    private void Start()
    {
        targetPos = GameManager.instance.MyPlayer;
        UIManager.instance.OnNameInput += SetNameCanvas;
    }

    private void Update()
    {
        transform.position = targetPos.position + Vector3.up;
    }


    private void SetNameCanvas()
    {
        nameText.text = GameManager.instance.MyPlayer.GetComponent<PlayerInfo>().playerName;
        Vector2 panelSize = namePanelRectTransform.sizeDelta;
        panelSize.x = nameText.preferredWidth  * paddingRatio;
        namePanelRectTransform.sizeDelta = panelSize;
    }
    
    

}

