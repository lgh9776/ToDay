using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    public int id;
    public int textNum;

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
