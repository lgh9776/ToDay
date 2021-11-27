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
        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
    }
} //플레이어 x좌표로 따라다님 -> 화면 밖이 나오지 않도록 이동 제한

