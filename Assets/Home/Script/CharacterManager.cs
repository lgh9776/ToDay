using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//add animator condition
public class CharacterManager : MonoBehaviour
{
    public GameObject character;

    //Animator animator;

    //Set Starting Character Shape 
    public Sprite[] characterSprites;
    SpriteRenderer spriteRenderer;
    int shapeID;

    void Start()
    {
        //this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        shapeID = character.GetComponent<CharacterData>().GetCharacterShapeID();
        StartCharacterShape();
    }

    void StartCharacterShape()
    {
        spriteRenderer = character.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = characterSprites[shapeID];
    }
}
