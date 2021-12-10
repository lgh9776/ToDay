using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//플레이어가 건물 앞, 뒤로 유연하게 움직이기
//바다에는 나가지 못하게 + 화면 밖으로 탈출하지 못하게
//대화 시 두번째부터 버튼 클릭 안해도 스페이스바 작동함

public class PlayerAction : MonoBehaviour
{
    public float Speed;
    public TextManager manager;
    public ChoiceManager choiceManager;

    Rigidbody2D rigid;
    Animator animator;

    float h; //수평
    float v; //상하
    bool isHorizonMove; //수평이동중
    Vector3 dirVec;
    GameObject scanPlace;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(choiceManager.isAction != true){
            h = manager.isAction ? 0 : Input.GetAxisRaw("Horizontal");
            v = manager.isAction ? 0 : Input.GetAxisRaw("Vertical");
        }

        bool hDown = manager.isAction ? false : Input.GetButtonDown("Horizontal");
        bool vDown = manager.isAction ? false : Input.GetButtonDown("Vertical");
        bool hUp = manager.isAction ? false : Input.GetButtonUp("Horizontal");
        bool vUp = manager.isAction ? false : Input.GetButtonUp("Vertical");

        if(hDown || vUp)
            isHorizonMove = true;
        else if(vDown || hUp)
            isHorizonMove = false;

        //방향
        if(vDown && v == 1)
            dirVec = Vector3.up;
        else if(vDown && v == -1)
            dirVec = Vector3.down;
        else if(hDown && h == -1)
            dirVec = Vector3.left;
        else if(hDown && h == 1)
            dirVec = Vector3.right;

        //Scan_Ray
        if(choiceManager.isAction != true){
            if(Input.GetButtonDown("Jump") && scanPlace != null){
                manager.Action(scanPlace);
                GetComponent<AudioSource>().Play();
            }
        }
        
        //play animaition
        if(h != 0 || v != 0)
            this.animator.speed = 1;
        else
            this.animator.speed = 0;    
    }

    void FixedUpdate()
    {
        //Move
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.velocity = moveVec * Speed;

        //Ray
        Debug.DrawRay(rigid.position, dirVec * 0.7f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 0.7f, LayerMask.GetMask("Place"));
            
        if(rayHit.collider != null)
            scanPlace = rayHit.collider.gameObject;
        else
            scanPlace = null;
    }
}