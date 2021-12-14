using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayScript : MonoBehaviour
{
    public Text date;
    private static int day = 1;

    public void OnClickSleep()
    {
        day += 1;  // 날짜 더하기
        date.text = "D+" + day;
    }

    public void Start()
    {
        date.text = "D+" + day;
    }

    public void AfterEnding()
    {
        day = 1;
    }
}
