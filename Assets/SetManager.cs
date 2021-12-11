using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetManager : MonoBehaviour
{
    public GameObject btnImage;

    void Start()
    {
        btnImage.SetActive(false);
    }
}
