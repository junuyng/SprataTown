using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public Transform MyPlayer { get; private set; }
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

        MyPlayer = GameObject.FindGameObjectWithTag("MyPlayer").transform;
        Time.timeScale = 0;
    }
    

    


}