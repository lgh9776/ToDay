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

    //스캔된 장소에 맞는 상호작용 화면 호출
    public void Action(GameObject scanObj)
    {
        scanObject = scanObj;
        ObjectData objData = scanObject.GetComponent<ObjectData>();

        //홈 화면으로 이동하는 부분 -> 
        if(objData.id == 9000 && objData.textNum == 10){ //textnum이 10일 경우 홈 클릭한 것
            SceneManager.LoadScene("Main");
        }
        Talk(objData.id, objData.textNum, scanObject); //20일 경우 다른 장소 클릭 (상호작용 횟수 = 0)

        talkPanel.SetActive(isAction);
    }

    //실제 상호작용 화면을 생성하는 부분
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
