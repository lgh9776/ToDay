using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    List<int> InteractList = new List<int>();
    public GameObject Interacta;
    public GameObject Interactb;
    public GameObject Interactc;
    public Button sleepbtn;
    public GameObject MainInteractbtn;

    public int interactnum = 3;
    private static int maininteract = 1;
    public int mainInteractrandomnumber = 0;

    public CharacterManager charactermanager;

    public void Start()
    {
        InteractaFalse();
        InteractbFalse();
        InteractcFalse();
        MainInteractSet();

        InteractList.Add(0);
        InteractList.Add(1);
        InteractList.Add(2);
    }

    public void OnClickSleep()
    {
        interactnum = 3;
        maininteract = 1;
        MainInteractSet();
    }

    public void MainInteractSet()
    {
        if (maininteract == 1)
        {
            MainInteractbtn.SetActive(true);
        }
        else
        {
            MainInteractbtn.SetActive(false);
        }
    }

    // 인터렉 버튼 누르면 인터렉 횟수 -1
    public void OnClickInteract()
    {
        maininteract--;
        ChooseInteract();
    }

    // 지도 버튼 누르면 지도씬으로
    public void SceneChange()
    {
        SceneManager.LoadScene("MapScene");
    }

    // 엔딩 후에 인트로로
    public void AfterEnding()
    {
        interactnum = 3;
        maininteract = 1;
        SceneManager.LoadScene("StartScene");
    }

    // 인터렉 리스트에서 1개 고르고 보이기, 해당 리스트 -1로
    // 전부 -1이면 처음으로 리셋
    public void ChooseInteract()
    {
        /*Debug.Log("리스트 출력");
        for (int i = 0; i < InteractList.Count; i++)
        {
            Debug.Log(InteractList[i]);
        }*/

        if (InteractList[0] == -1)
        {
            if (InteractList[1] == -1)
            {
                if (InteractList[2] == -1)
                {
                    InteractList[0] = 0;
                    InteractList[1] = 1;
                    InteractList[2] = 2;
                }
            }
        }

        while (true)
        {
            mainInteractrandomnumber = Random.Range(0, 3);
            if (InteractList[mainInteractrandomnumber] == 0)
            {
                Interacta.SetActive(true);
                InteractList[0] = -1;
                break;
            }
            else if (InteractList[mainInteractrandomnumber] == 1)
            {
                Interactb.SetActive(true);
                InteractList[1] = -1;
                break;
            }
            else if (InteractList[mainInteractrandomnumber] == 2)
            {
                Interactc.SetActive(true);
                InteractList[2] = -1;
                break;
            }
        }

        Debug.Log("리스트 출력");
        for (int i = 0; i < InteractList.Count; i++)
        {
            Debug.Log(InteractList[i]);
        }
    }

    // 해당 인터렉 숨기기
    public void InteractaFalse()
    {
        Interacta.SetActive(false);
    }
    public void InteractbFalse()
    {
        Interactb.SetActive(false);
    }
    public void InteractcFalse()
    {
        Interactc.SetActive(false);
    }
}
