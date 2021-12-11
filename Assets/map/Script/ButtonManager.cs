using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public ChoiceManager choiceManager;
    public int num;

    public void OnButtonClick()
    {
        choiceManager.buttonClick = true;
        choiceManager.buttonId = num;
        //GetComponent<AudioSource>().Play();
    }
}
