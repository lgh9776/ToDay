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
    public Text petname;

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
        MBTINaming();
    }

    public void MBTINaming()
    {
        //C
        if (DesirabilityGauge.index0 == 0)
        {
            if (Mbti[0] > Mbti[4])  //E
            {
                if (Mbti[1] > Mbti[5])  //ES
                {
                    if (Mbti[2] > Mbti[6])  //EST
                    {
                        if (Mbti[3] > Mbti[7])  //ESTJ
                        {
                            petname.text = "<엄격한 관리자 동그리>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESTP
                        {
                            petname.text = "<모험을 즐기는 사업가 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ESF
                    {
                        if (Mbti[3] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<사교적인 외교관 동그리>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESFP
                        {
                            petname.text = "<자유로운 영혼의 연예인 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else
                    {
                        petname.text = "<동그리>";
                    }
                }
                else if (Mbti[1] < Mbti[5])  //EN
                {
                    if (Mbti[2] > Mbti[6])  //ENT
                    {
                        if (Mbti[3] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<대담한 통솔자 동그리>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENTP
                        {
                            petname.text = "<뜨거운 논쟁을 즐기는 변론가 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ENF
                    {
                        if (Mbti[3] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<정의로운 사회운동가 동그리>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENFP
                        {
                            petname.text = "<재기발랄한 활동가 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else
                    {
                        petname.text = "<동그리>";
                    }
                }
                else
                {
                    petname.text = "<동그리>";
                }
            }
            else if (Mbti[0] < Mbti[4])  //I
            {
                if (Mbti[1] > Mbti[5])  //IS
                {
                    if (Mbti[2] > Mbti[6])  //IST
                    {
                        if (Mbti[3] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<청렴결백한 논리주의자 동그리>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISTP
                        {
                            petname.text = "<만능 재주꾼 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ISF
                    {
                        if (Mbti[3] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<용감한 수호자 동그리>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISFP
                        {
                            petname.text = "<호기심 많은 예술가 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else
                    {
                        petname.text = "<동그리>";
                    }
                }
                else if (Mbti[1] < Mbti[5])  //IN
                {
                    if (Mbti[2] > Mbti[6])  //INT
                    {
                        if (Mbti[3] > Mbti[7])  //INTJ
                        {
                            petname.text = "<용의주도한 전략가 동그리>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INTP
                        {
                            petname.text = "<논리적인 사색가 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //INF
                    {
                        if (Mbti[3] > Mbti[7])  //INFJ
                        {
                            petname.text = "<선의의 옹호자 동그리>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INFP
                        {
                            petname.text = "<열정적인 중재자 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else
                    {
                        petname.text = "<동그리>";
                    }
                }
                else
                {
                    petname.text = "<동그리>";
                }
            }
            else
            {
                petname.text = "<동그리>";
            }
        }

        //T
        else if (DesirabilityGauge.index0 == 2)
        {
            if (Mbti[0] > Mbti[4])  //E
            {
                if (Mbti[1] > Mbti[5])  //ES
                {
                    if (Mbti[2] > Mbti[6])  //EST
                    {
                        if (Mbti[3] > Mbti[7])  //ESTJ
                        {
                            petname.text = "<엄격한 관리자 세모몽>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESTP
                        {
                            petname.text = "<모험을 즐기는 사업가 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ESF
                    {
                        if (Mbti[3] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<사교적인 외교관 세모몽>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESFP
                        {
                            petname.text = "<자유로운 영혼의 연예인 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else
                    {
                        petname.text = "<세모몽>";
                    }
                }
                else if (Mbti[1] < Mbti[5])  //EN
                {
                    if (Mbti[2] > Mbti[6])  //ENT
                    {
                        if (Mbti[3] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<대담한 통솔자 세모몽>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENTP
                        {
                            petname.text = "<뜨거운 논쟁을 즐기는 변론가 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ENF
                    {
                        if (Mbti[3] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<정의로운 사회운동가 세모몽>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENFP
                        {
                            petname.text = "<재기발랄한 활동가 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else
                    {
                        petname.text = "<세모몽>";
                    }
                }
                else
                {
                    petname.text = "<세모몽>";
                }
            }
            else if (Mbti[0] < Mbti[4])  //I
            {
                if (Mbti[1] > Mbti[5])  //IS
                {
                    if (Mbti[2] > Mbti[6])  //IST
                    {
                        if (Mbti[3] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<청렴결백한 논리주의자 세모몽>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISTP
                        {
                            petname.text = "<만능 재주꾼 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ISF
                    {
                        if (Mbti[3] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<용감한 수호자 세모몽>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISFP
                        {
                            petname.text = "<호기심 많은 예술가 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else
                    {
                        petname.text = "<세모몽>";
                    }
                }
                else if (Mbti[1] < Mbti[5])  //IN
                {
                    if (Mbti[2] > Mbti[6])  //INT
                    {
                        if (Mbti[3] > Mbti[7])  //INTJ
                        {
                            petname.text = "<용의주도한 전략가 세모몽>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INTP
                        {
                            petname.text = "<논리적인 사색가 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //INF
                    {
                        if (Mbti[3] > Mbti[7])  //INFJ
                        {
                            petname.text = "<선의의 옹호자 세모몽>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INFP
                        {
                            petname.text = "<열정적인 중재자 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else
                    {
                        petname.text = "<세모몽>";
                    }
                }
                else
                {
                    petname.text = "<세모몽>";
                }
            }
            else
            {
                petname.text = "<세모몽>";
            }
        }

        //S
        else
        {
            if (Mbti[0] > Mbti[4])  //E
            {
                if (Mbti[1] > Mbti[5])  //ES
                {
                    if (Mbti[2] > Mbti[6])  //EST
                    {
                        if (Mbti[3] > Mbti[7])  //ESTJ
                        {
                            petname.text = "<엄격한 관리자 네모미>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESTP
                        {
                            petname.text = "<모험을 즐기는 사업가 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ESF
                    {
                        if (Mbti[3] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<사교적인 외교관 네모미>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESFP
                        {
                            petname.text = "<자유로운 영혼의 연예인 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else
                    {
                        petname.text = "<네모미>";
                    }
                }
                else if (Mbti[1] < Mbti[5])  //EN
                {
                    if (Mbti[2] > Mbti[6])  //ENT
                    {
                        if (Mbti[3] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<대담한 통솔자 네모미>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENTP
                        {
                            petname.text = "<뜨거운 논쟁을 즐기는 변론가 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ENF
                    {
                        if (Mbti[3] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<정의로운 사회운동가 네모미>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENFP
                        {
                            petname.text = "<재기발랄한 활동가 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else
                    {
                        petname.text = "<네모미>";
                    }
                }
                else
                {
                    petname.text = "<네모미>";
                }
            }
            else if (Mbti[0] < Mbti[4])  //I
            {
                if (Mbti[1] > Mbti[5])  //IS
                {
                    if (Mbti[2] > Mbti[6])  //IST
                    {
                        if (Mbti[3] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<청렴결백한 논리주의자 네모미>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISTP
                        {
                            petname.text = "<만능 재주꾼 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ISF
                    {
                        if (Mbti[3] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<용감한 수호자 네모미>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISFP
                        {
                            petname.text = "<호기심 많은 예술가 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else
                    {
                        petname.text = "<네모미>";
                    }
                }
                else if (Mbti[1] < Mbti[5])  //IN
                {
                    if (Mbti[2] > Mbti[6])  //INT
                    {
                        if (Mbti[3] > Mbti[7])  //INTJ
                        {
                            petname.text = "<용의주도한 전략가 네모미>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INTP
                        {
                            petname.text = "<논리적인 사색가 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //INF
                    {
                        if (Mbti[3] > Mbti[7])  //INFJ
                        {
                            petname.text = "<선의의 옹호자 네모미>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INFP
                        {
                            petname.text = "<열정적인 중재자 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else
                    {
                        petname.text = "<네모미>";
                    }
                }
                else
                {
                    petname.text = "<네모미>";
                }
            }
            else
            {
                petname.text = "<네모미>";
            }
        }
    }
}
