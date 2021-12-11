using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayScript : MonoBehaviour
{
    public Text date;
    public Button sleepbtn;
    private int day = 0;

    void Start()
    {
        NextDay();
    }

    public void NextDay()
    {
        date.text = "D+" + day;
        sleepbtn.interactable = false;
    }

    public void OnClickSleep()
    {
        day += 1;  // 날짜 더하기
        NextDay();
    }

    public void AllDayDone()
    {
        sleepbtn.interactable = true;
    }
}
