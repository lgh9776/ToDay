using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    int shape; //ĳ���� ��� ID
    int love; //������
    public int interactNum;
    public int[] MBTI = new int[8]; //E I S N T F J P

    private void Awake()
    {
        SetCharacterShapeID();
        InitInteractNum();
    }

    //���� ���� �� ĳ���� ��� ���� ����
    void SetCharacterShapeID()
    {
        shape = Random.Range(0, 3);
    }

    public int GetCharacterShapeID()
    {
        return shape;
    }

    void InitInteractNum()
    {
        interactNum = 3;
    }
}
