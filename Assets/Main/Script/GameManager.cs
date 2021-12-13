using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] InteractList = new GameObject[9];
    public Button sleepbtn;
    public GameObject MainInteractbtn;
    public SoundManager soundManager;

    public int interactnum = 3;
    public int maininteract = 1;
    public int mainInteractrandomnumber = 0;

    public void Start()
    {
        for (int i = 0; i < InteractList.Length; i++)
        {
            InteractList[i].SetActive(false);
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ClearToDoList()
    {
        if (interactnum == 0 && maininteract == 0)
        {
            sleepbtn.interactable = true;
        }
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
        Application.Quit();
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("MapScene");
    }

    public void ChooseInteract()
    {
        mainInteractrandomnumber = Random.Range(0, 9);
        InteractList[mainInteractrandomnumber].SetActive(true);
        Debug.Log(mainInteractrandomnumber);
    }
}
