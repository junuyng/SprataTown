using System;
using System.Collections.Generic;
using UnityEngine;


public enum CharacterType
{
    Penguin,
    Dragon
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public List<PlayerInfo> attendeesInfo = new List<PlayerInfo>();

    private void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        InitAttendeesList();
    }

    private void InitAttendeesList()
    {        
        attendeesInfo.Add(GameManager.instance.MyPlayer.GetComponent<PlayerInfo>());
       
        var attendees = GameObject.FindGameObjectsWithTag("Player");
        foreach (var attendee in attendees)
        {
            PlayerInfo playerInfo = attendee.GetComponent<PlayerInfo>();
            attendeesInfo.Add(playerInfo);
        }
        
    }


}