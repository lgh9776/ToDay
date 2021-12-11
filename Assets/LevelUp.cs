using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public GameObject[] NextLevel;
    // public List<GameObject> NextLevel = new List<GameObject>();

    void Start()
    {
        for(int i=1; i <7; i++)
        {
            NextLevel[i].SetActive(false);
        }
    }

    private void RandomObj()
    {
        int index = Random.Range(1, 3);
        NextLevel[0].SetActive(false);
        NextLevel[index].SetActive(true);
    }
}
