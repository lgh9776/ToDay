using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextEffect : MonoBehaviour
{
    private TextMeshProUGUI textVariable;
    float span = 1;
    float delta = 0;
    bool isChange;
    private void Awake(){
        textVariable = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        if(this.delta > this.span && isChange == true){
            textVariable.fontSize = 40;
            isChange = false;
            this.delta = 0;
        }
        
        if(this.delta > this.span && isChange == false){
            textVariable.fontSize = 50;
            isChange = true;
            this.delta = 0;
        }
    }
}