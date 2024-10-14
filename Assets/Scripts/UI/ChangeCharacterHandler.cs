using System;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacterHandler : UIController
{
    private Image image;
    [SerializeField] private Sprite[] sprites;


    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        UIManager.instance.OnSelectionCharacter += ChangeImage;
    }

    private void ChangeImage(int num)
    {
        image.sprite = sprites[num];
    }
}