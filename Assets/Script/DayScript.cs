using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayScript : MonoBehaviour
{
    public Text date;
    public Button sleepbtn;
    private int day = 0;
    public static int MapConversation = 3;
    public int Interact = 1;

    void Start()
    {
        sleepbtn.interactable = false;
    }
    void Update()
    {
        ToDoList();
    }

    public void OnClickSleep()
    {
        day += 1;  // 날짜 더하기
        date.text = "D+" + day;
        sleepbtn.interactable = false;
        MapConversation = 3;
        Interact = 1;
    }

    public void ToDoList()
    {
        if (MapConversation == 0 && Interact == 0)
        {
            sleepbtn.interactable = true;
        }
    }

    public void OnClickInteract()
    {
        Interact -= 1;
        ToDoList();
    }
}
