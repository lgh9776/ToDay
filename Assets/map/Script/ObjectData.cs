using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    public int id;
    public int textNum;

    void Awake()
    {
        textNum = 10;
    }
}