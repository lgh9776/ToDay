using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    public int id;
    public int textNum;

    void Awake()
    {
        int n = Random.Range(1, 13);
        textNum = 10;
        textNum *= n;
    }
}
