using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public TalkManager talkManager;
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
        Talk(objData.id);

        talkPanel.SetActive(isAction);
    }

    void Talk(int id)
    {
        string talkData = talkManager.GetTalk(id, talkIndex);

        if(talkData == null){
            isAction = false;
            talkIndex = 0;
            return;
        }

        talkText.text = talkData;

        backgroundImg.sprite = talkManager.GetBackground(id);
        backgroundImg.color = new Color(1, 1, 1, 1);
        isAction = true;
        talkIndex++;
    }
}
