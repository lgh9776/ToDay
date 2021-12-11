using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public ChoiceText choiceText;
    public ScoreManager scoreManager;
    public GameObject[] button;
    public Text[] text;

    public bool isAction;
    public bool buttonClick;
    public int buttonId;
    int choiceNum;
    int textId;

    void Update()
    {
        if(buttonClick){
            scoreManager.ChoiceScore(textId + buttonId);
            GetComponent<AudioSource>().Play();

            this.isAction = false;
            buttonId = 0;
            buttonClick = false;
        }

        for(int i = 0; i < choiceNum; i++){
            button[i].SetActive(this.isAction);
        }
    }

    public void Action(int id)
    {
        this.textId = id;
        this.choiceNum = choiceText.GetChoiceNum(textId);

        TextScreen(textId);
    }

    void TextScreen(int id)
    {
        for(int i = 0; i < choiceNum; i++){
            string textData = choiceText.GetText(id, i);

            text[i].text = textData;
            this.isAction = true;
        }
    }
}
