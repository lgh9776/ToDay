using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    public int id;
    public int textNum;

    //중복된 상황이 나오지 않도록 수정
    void Awake()
    {
        int n;
        
        if(id != 9000){
            n = Random.Range(1, 12);
            textNum = 10;
            textNum *= n;
        }
    }
}
