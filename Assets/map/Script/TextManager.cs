using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    public TalkManager talkManager;
    public ChoiceManager choiceManager;

    public GameObject talkPanel;
    public Image backgroundImg;
    public Text talkText;
    
    public GameObject scanObject;
    
    public bool isAction;
    public int talkIndex;

    public void Action(GameObject scanObj)
    {
        scanObject = scanObj;
        ObjectData objData = scanObject.GetComponent<ObjectData>();

        if(objData.id == 9000 && objData.textNum == 10){
            SceneManager.LoadScene("Main");
        }
        Talk(objData.id, objData.textNum, scanObject);

        talkPanel.SetActive(isAction);
    }

    void Talk(int id, int textSetIndex, GameObject scanObj)
    {
        string talkData = talkManager.GetTalk(id + textSetIndex, talkIndex);

        if(talkData == null){
            if(id != 9000)
                choiceManager.Action(id + textSetIndex);
            isAction = false;
            talkIndex = 0;
            talkManager.CheckText(scanObject);
            //count--; 횟수 제한
            return;
        }

        talkText.text = talkData;
        backgroundImg.sprite = talkManager.GetBackground(id);
        backgroundImg.color = new Color(1, 1, 1, 1);
        isAction = true;
        talkIndex++;
    }
}
