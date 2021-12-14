using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionManager : MonoBehaviour
{
    public SoundManager soundManager;

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
}
