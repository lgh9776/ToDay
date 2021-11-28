using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;

        if(playerPos.y <= -3 || playerPos.y >= 3){
            if(playerPos.x <= -7.5 || playerPos.x >= 8.5)
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            else
                transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
        }
        else if(playerPos.x <= -7.5 || playerPos.x >= 8.5){
            transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
        }
        else{
            transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
        }
    }
}

