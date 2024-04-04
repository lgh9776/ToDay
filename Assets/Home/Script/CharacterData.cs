using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    int shape; //캐릭터 모양 ID
    int love; //애정도
    public int interactNum;
    public int[] MBTI = new int[8]; //E I S N T F J P

    private void Awake()
    {
        SetCharacterShapeID();
        InitInteractNum();
    }

    //게임 시작 시 캐릭터 모양 랜덤 지정
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
