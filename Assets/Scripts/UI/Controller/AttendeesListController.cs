using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttendeesListController : UIController
{
    private List<PlayerInfo> attendees = new List<PlayerInfo>();
    public GameObject attendeeItemPrefab;
    public Transform content;


    void Start()
    {
        attendees = DataManager.instance.attendeesInfo;
        UpdateAttendeesList();
        UIManager.instance.OnNameInput += UpdateAttendeesList;
    }


    private void UpdateAttendeesList()
    {
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }

        foreach (PlayerInfo attendee in attendees)
        {
            GameObject newItem = Instantiate(attendeeItemPrefab, content);
            newItem.GetComponent<Text>().text = attendee.playerName;
        }
    }
}