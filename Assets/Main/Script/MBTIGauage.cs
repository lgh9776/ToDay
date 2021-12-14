using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MBTIGauage : MonoBehaviour
{
    public Text Etext;
    public Text Itext;
    public Text Stext;
    public Text Ntext;
    public Text Ttext;
    public Text Ftext;
    public Text Jtext;
    public Text Ptext;
    public int[] Mbti = new int [8];  // E, I, S, N, T, F, J, P
    public Text petname;
    public Text endingtext;

    string a = "E";
    string b = "E";
    string c = "E";
    string d = "E";

    public CharacterManager characterchoose;

    void Start()
    {
        Etext.text = Mbti[0].ToString();
        Itext.text = Mbti[1].ToString();
        Stext.text = Mbti[2].ToString();
        Ntext.text = Mbti[3].ToString();
        Ttext.text = Mbti[4].ToString();
        Ftext.text = Mbti[5].ToString();
        Jtext.text = Mbti[6].ToString();
        Ptext.text = Mbti[7].ToString();
        MBTINaming();
        /*Debug.Log("Mbti");
        for (int i = 0; i < Mbti.Length; i++)
        {
            Debug.Log(Mbti[i]);
        }*/
    }

    public void MBTINaming()
    {
        //C
        if (characterchoose.index0 == 0)
        {
            if (Mbti[0] > Mbti[1])  //E
            {
                if (Mbti[2] > Mbti[3])  //ES
                {
                    if (Mbti[4] > Mbti[5])  //EST
                    {
                        if (Mbti[6] > Mbti[7])  //ESTJ
                        {
                            petname.text = "<엄격한 관리자 동그리>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESTP
                        {
                            petname.text = "<모험을 즐기는 사업가 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ESF
                    {
                        if (Mbti[6] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<사교적인 외교관 동그리>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESFP
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
                else if (Mbti[2] < Mbti[3])  //EN
                {
                    if (Mbti[4] > Mbti[5])  //ENT
                    {
                        if (Mbti[6] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<대담한 통솔자 동그리>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENTP
                        {
                            petname.text = "<뜨거운 논쟁을 즐기는 변론가 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ENF
                    {
                        if (Mbti[6] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<정의로운 사회운동가 동그리>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENFP
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
            else if (Mbti[0] < Mbti[1])  //I
            {
                if (Mbti[2] > Mbti[3])  //IS
                {
                    if (Mbti[4] > Mbti[5])  //IST
                    {
                        if (Mbti[6] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<청렴결백한 논리주의자 동그리>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISTP
                        {
                            petname.text = "<만능 재주꾼 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ISF
                    {
                        if (Mbti[6] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<용감한 수호자 동그리>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISFP
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
                else if (Mbti[2] < Mbti[3])  //IN
                {
                    if (Mbti[4] > Mbti[5])  //INT
                    {
                        if (Mbti[6] > Mbti[7])  //INTJ
                        {
                            petname.text = "<용의주도한 전략가 동그리>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INTP
                        {
                            petname.text = "<논리적인 사색가 동그리>";
                        }
                        else
                        {
                            petname.text = "<동그리>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //INF
                    {
                        if (Mbti[6] > Mbti[7])  //INFJ
                        {
                            petname.text = "<선의의 옹호자 동그리>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INFP
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
        else if (characterchoose.index0 == 2)
        {
            if (Mbti[0] > Mbti[1])  //E
            {
                if (Mbti[2] > Mbti[3])  //ES
                {
                    if (Mbti[4] > Mbti[5])  //EST
                    {
                        if (Mbti[6] > Mbti[7])  //ESTJ
                        {
                            petname.text = "<엄격한 관리자 세모몽>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESTP
                        {
                            petname.text = "<모험을 즐기는 사업가 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ESF
                    {
                        if (Mbti[6] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<사교적인 외교관 세모몽>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESFP
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
                else if (Mbti[2] < Mbti[3])  //EN
                {
                    if (Mbti[4] > Mbti[5])  //ENT
                    {
                        if (Mbti[6] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<대담한 통솔자 세모몽>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENTP
                        {
                            petname.text = "<뜨거운 논쟁을 즐기는 변론가 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ENF
                    {
                        if (Mbti[6] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<정의로운 사회운동가 세모몽>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENFP
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
            else if (Mbti[0] < Mbti[1])  //I
            {
                if (Mbti[2] > Mbti[3])  //IS
                {
                    if (Mbti[4] > Mbti[5])  //IST
                    {
                        if (Mbti[6] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<청렴결백한 논리주의자 세모몽>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISTP
                        {
                            petname.text = "<만능 재주꾼 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ISF
                    {
                        if (Mbti[6] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<용감한 수호자 세모몽>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISFP
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
                else if (Mbti[2] < Mbti[3])  //IN
                {
                    if (Mbti[4] > Mbti[5])  //INT
                    {
                        if (Mbti[6] > Mbti[7])  //INTJ
                        {
                            petname.text = "<용의주도한 전략가 세모몽>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INTP
                        {
                            petname.text = "<논리적인 사색가 세모몽>";
                        }
                        else
                        {
                            petname.text = "<세모몽>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //INF
                    {
                        if (Mbti[6] > Mbti[7])  //INFJ
                        {
                            petname.text = "<선의의 옹호자 세모몽>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INFP
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
            if (Mbti[0] > Mbti[1])  //E
            {
                if (Mbti[2] > Mbti[3])  //ES
                {
                    if (Mbti[4] > Mbti[5])  //EST
                    {
                        if (Mbti[6] > Mbti[7])  //ESTJ
                        {
                            petname.text = "<엄격한 관리자 네모미>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESTP
                        {
                            petname.text = "<모험을 즐기는 사업가 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ESF
                    {
                        if (Mbti[6] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<사교적인 외교관 네모미>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESFP
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
                else if (Mbti[2] < Mbti[3])  //EN
                {
                    if (Mbti[4] > Mbti[5])  //ENT
                    {
                        if (Mbti[6] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<대담한 통솔자 네모미>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENTP
                        {
                            petname.text = "<뜨거운 논쟁을 즐기는 변론가 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ENF
                    {
                        if (Mbti[6] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<정의로운 사회운동가 네모미>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENFP
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
            else if (Mbti[0] < Mbti[1])  //I
            {
                if (Mbti[2] > Mbti[3])  //IS
                {
                    if (Mbti[4] > Mbti[5])  //IST
                    {
                        if (Mbti[6] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<청렴결백한 논리주의자 네모미>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISTP
                        {
                            petname.text = "<만능 재주꾼 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ISF
                    {
                        if (Mbti[6] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<용감한 수호자 네모미>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISFP
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
                else if (Mbti[2] < Mbti[3])  //IN
                {
                    if (Mbti[4] > Mbti[5])  //INT
                    {
                        if (Mbti[6] > Mbti[7])  //INTJ
                        {
                            petname.text = "<용의주도한 전략가 네모미>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INTP
                        {
                            petname.text = "<논리적인 사색가 네모미>";
                        }
                        else
                        {
                            petname.text = "<네모미>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //INF
                    {
                        if (Mbti[6] > Mbti[7])  //INFJ
                        {
                            petname.text = "<선의의 옹호자 네모미>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INFP
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

    // 펫의 최종 mbti 출력
    public void EndingShow()
    {
        if (Mbti[0] > Mbti[1])
        {
            a = "E";
        }
        else
        {
            a = "I";
        }
        if (Mbti[2] > Mbti[3])
        {
            b = "S";
        }
        else
        {
            b = "N";
        }
        if (Mbti[4] > Mbti[5])
        {
            c = "T";
        }
        else
        {
            c = "F";
        }
        if (Mbti[6] > Mbti[7])
        {
            d = "J";
        }
        else
        {
            d = "P";
        }

        // 최종 문구
        endingtext.text = a + b + c + d;
    }

    public void AfterEnding()
    {
        Start();
    }
}
