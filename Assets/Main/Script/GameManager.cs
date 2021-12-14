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

    public int interactnum = 3;
    private static int maininteract = 1;
    public int mainInteractrandomnumber = 0;

    public CharacterManager charactermanager;

    public void Start()
    {
        InteractaFalse();
        InteractbFalse();
        InteractcFalse();
        MainInteractSet();

        InteractList.Add(0);
        InteractList.Add(1);
        InteractList.Add(2);
    }

    public void OnClickSleep()
    {
        interactnum = 3;
        maininteract = 1;
        MainInteractSet();
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

    // ���ͷ� ��ư ������ ���ͷ� Ƚ�� -1
    public void OnClickInteract()
    {
        maininteract--;
        ChooseInteract();
    }

    // ���� ��ư ������ ����������
    public void SceneChange()
    {
        SceneManager.LoadScene("MapScene");
    }

    // ���� �Ŀ� ��Ʈ�η�
    public void AfterEnding()
    {
        interactnum = 3;
        maininteract = 1;
        SceneManager.LoadScene("StartScene");
    }

    // ���ͷ� ����Ʈ���� 1�� ���� ���̱�, �ش� ����Ʈ -1��
    // ���� -1�̸� ó������ ����
    public void ChooseInteract()
    {
        /*Debug.Log("����Ʈ ���");
        for (int i = 0; i < InteractList.Count; i++)
        {
            Debug.Log(InteractList[i]);
        }*/

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

        while (true)
        {
            mainInteractrandomnumber = Random.Range(0, 3);
            if (InteractList[mainInteractrandomnumber] == 0)
            {
                Interacta.SetActive(true);
                InteractList[0] = -1;
                break;
            }
            else if (InteractList[mainInteractrandomnumber] == 1)
            {
                Interactb.SetActive(true);
                InteractList[1] = -1;
                break;
            }
            else if (InteractList[mainInteractrandomnumber] == 2)
            {
                Interactc.SetActive(true);
                InteractList[2] = -1;
                break;
            }
        }

        Debug.Log("����Ʈ ���");
        for (int i = 0; i < InteractList.Count; i++)
        {
            Debug.Log(InteractList[i]);
        }
    }

    // �ش� ���ͷ� �����
    public void InteractaFalse()
    {
        Interacta.SetActive(false);
    }
    public void InteractbFalse()
    {
        Interactb.SetActive(false);
    }
    public void InteractcFalse()
    {
        Interactc.SetActive(false);
    }
}
