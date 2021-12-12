using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource bgmPlayer;
    public GameObject[] InteractList = new GameObject[9];

    public int interactnum = 3;

    public void Start()
    {
        bgmPlayer.Play();

        for (int i = 0; i < InteractList.Length; i++)
        {
            InteractList[i].SetActive(false);
        }
    }

    public void OnClickbtnMute()
    {
        if (bgmPlayer.mute == false)
        {
            bgmPlayer.mute = true;
        }
        else
        {
            bgmPlayer.mute = false;
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
        interactnum = Random.Range(0, 9);
        InteractList[interactnum].SetActive(true);
        Debug.Log(interactnum);
    }
}
