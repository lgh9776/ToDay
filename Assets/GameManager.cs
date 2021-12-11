using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource bgmPlayer;
    
    public void Start()
    {
        bgmPlayer.Play();
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
        SceneManager.LoadScene("SampleMap");
    }
}
