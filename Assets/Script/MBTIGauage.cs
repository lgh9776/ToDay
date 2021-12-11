using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MBTIGauage : MonoBehaviour
{
    public Slider Eslider;
    public Slider Sslider;
    public Slider Tslider;
    public Slider Jslider;
    public Slider Islider;
    public Slider Nslider;
    public Slider Fslider;
    public Slider Pslider;
    public int[] Mbti = new int[8];  // E, S, T, J, I, N, F, P

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Eslider.value = Mbti[0];
        Sslider.value = Mbti[1];
        Tslider.value = Mbti[2];
        Jslider.value = Mbti[3];
        Islider.value = Mbti[4];
        Nslider.value = Mbti[5];
        Fslider.value = Mbti[6];
        Pslider.value = Mbti[7];
    }
}
