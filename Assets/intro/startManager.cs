using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startManager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.anyKeyDown){
            GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("Main");
        }
    }
}
