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
    public SoundManager soundManager;

    public int interactnum = 3;
    public int maininteract = 1;
    public int mainInteractrandomnumber = 0;

    public void Start()
    {
        Interacta.SetActive(false);
        Interactb.SetActive(false);
        Interactc.SetActive(false);
        InteractList.Add(0);
        InteractList.Add(1);
        InteractList.Add(2);
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

    public void OnClickInteract()
    {
        maininteract--;
        Debug.Log(maininteract);
        ChooseInteract();
    }

    public void OnClickbtnMute()
    {
        if (soundManager.bgmPlayer.mute == false)
        {
            soundManager.bgmPlayer.mute = true;
        }
        else
        {
            soundManager.bgmPlayer.mute = false;
        }
    }

    public void GameExit()
    {
        //Application.Quit();
        SceneManager.LoadScene("StartScene");
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("MapScene");
    }

    public void AfterEnding()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void ChooseInteract()
    {
        Debug.Log("리스트 출력");
        for (int i = 0; i < InteractList.Count; i++)
        {
            Debug.Log(InteractList[i]);
        }

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

        mainInteractrandomnumber = Random.Range(0, 3);
        if (InteractList[mainInteractrandomnumber] == 0)
        {
            Interacta.SetActive(true);
            InteractList[0] = -1;
        }
        else if (InteractList[mainInteractrandomnumber] == 1)
        {
            Interactb.SetActive(true);
            InteractList[1] = -1;
        }
        else if (InteractList[mainInteractrandomnumber] == 2)
        {
            Interactc.SetActive(true);
            InteractList[2] = -1;
        }
        Debug.Log("리스트 출력");
        for (int i = 0; i < InteractList.Count; i++)
        {
            Debug.Log(InteractList[i]);
        }
    }
}
