using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayScript : MonoBehaviour
{
    public Text date;
    public Button sleepbtn;
    private int day = 0;
    public GameManager gameManager;


    void Update()
    {
        gameManager.ClearToDoList();
    }

    public void OnClickSleep()
    {
        day += 1;  // ��¥ ���ϱ�
        date.text = "D+" + day;
        sleepbtn.interactable = false;
        gameManager.interactnum = 3;
        gameManager.maininteract = 1;
    }

    public void OnClickStart()
    {
        OnClickSleep();
    }

    public void Start()
    {
        day = 0;
        OnClickSleep();
    }
}
