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
                            petname.text = "<������ ������ ���׸�>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESTP
                        {
                            petname.text = "<������ ���� ����� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ESF
                    {
                        if (Mbti[6] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<�米���� �ܱ��� ���׸�>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESFP
                        {
                            petname.text = "<�����ο� ��ȥ�� ������ ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else
                    {
                        petname.text = "<���׸�>";
                    }
                }
                else if (Mbti[2] < Mbti[3])  //EN
                {
                    if (Mbti[4] > Mbti[5])  //ENT
                    {
                        if (Mbti[6] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<����� ����� ���׸�>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENTP
                        {
                            petname.text = "<�߰ſ� ������ ���� ���а� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ENF
                    {
                        if (Mbti[6] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<���Ƿο� ��ȸ��� ���׸�>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENFP
                        {
                            petname.text = "<���߶��� Ȱ���� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else
                    {
                        petname.text = "<���׸�>";
                    }
                }
                else
                {
                    petname.text = "<���׸�>";
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
                            petname.text = "<û�Ű���� �������� ���׸�>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISTP
                        {
                            petname.text = "<���� ���ֲ� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ISF
                    {
                        if (Mbti[6] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<�밨�� ��ȣ�� ���׸�>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISFP
                        {
                            petname.text = "<ȣ��� ���� ������ ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else
                    {
                        petname.text = "<���׸�>";
                    }
                }
                else if (Mbti[2] < Mbti[3])  //IN
                {
                    if (Mbti[4] > Mbti[5])  //INT
                    {
                        if (Mbti[6] > Mbti[7])  //INTJ
                        {
                            petname.text = "<�����ֵ��� ������ ���׸�>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INTP
                        {
                            petname.text = "<������ ����� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //INF
                    {
                        if (Mbti[6] > Mbti[7])  //INFJ
                        {
                            petname.text = "<������ ��ȣ�� ���׸�>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INFP
                        {
                            petname.text = "<�������� ������ ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else
                    {
                        petname.text = "<���׸�>";
                    }
                }
                else
                {
                    petname.text = "<���׸�>";
                }
            }
            else
            {
                petname.text = "<���׸�>";
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
                            petname.text = "<������ ������ �����>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESTP
                        {
                            petname.text = "<������ ���� ����� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ESF
                    {
                        if (Mbti[6] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<�米���� �ܱ��� �����>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESFP
                        {
                            petname.text = "<�����ο� ��ȥ�� ������ �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else
                    {
                        petname.text = "<�����>";
                    }
                }
                else if (Mbti[2] < Mbti[3])  //EN
                {
                    if (Mbti[4] > Mbti[5])  //ENT
                    {
                        if (Mbti[6] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<����� ����� �����>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENTP
                        {
                            petname.text = "<�߰ſ� ������ ���� ���а� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ENF
                    {
                        if (Mbti[6] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<���Ƿο� ��ȸ��� �����>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENFP
                        {
                            petname.text = "<���߶��� Ȱ���� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else
                    {
                        petname.text = "<�����>";
                    }
                }
                else
                {
                    petname.text = "<�����>";
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
                            petname.text = "<û�Ű���� �������� �����>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISTP
                        {
                            petname.text = "<���� ���ֲ� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ISF
                    {
                        if (Mbti[6] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<�밨�� ��ȣ�� �����>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISFP
                        {
                            petname.text = "<ȣ��� ���� ������ �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else
                    {
                        petname.text = "<�����>";
                    }
                }
                else if (Mbti[2] < Mbti[3])  //IN
                {
                    if (Mbti[4] > Mbti[5])  //INT
                    {
                        if (Mbti[6] > Mbti[7])  //INTJ
                        {
                            petname.text = "<�����ֵ��� ������ �����>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INTP
                        {
                            petname.text = "<������ ����� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //INF
                    {
                        if (Mbti[6] > Mbti[7])  //INFJ
                        {
                            petname.text = "<������ ��ȣ�� �����>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INFP
                        {
                            petname.text = "<�������� ������ �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else
                    {
                        petname.text = "<�����>";
                    }
                }
                else
                {
                    petname.text = "<�����>";
                }
            }
            else
            {
                petname.text = "<�����>";
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
                            petname.text = "<������ ������ �׸��>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESTP
                        {
                            petname.text = "<������ ���� ����� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ESF
                    {
                        if (Mbti[6] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<�米���� �ܱ��� �׸��>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ESFP
                        {
                            petname.text = "<�����ο� ��ȥ�� ������ �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else
                    {
                        petname.text = "<�׸��>";
                    }
                }
                else if (Mbti[2] < Mbti[3])  //EN
                {
                    if (Mbti[4] > Mbti[5])  //ENT
                    {
                        if (Mbti[6] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<����� ����� �׸��>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENTP
                        {
                            petname.text = "<�߰ſ� ������ ���� ���а� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ENF
                    {
                        if (Mbti[6] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<���Ƿο� ��ȸ��� �׸��>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ENFP
                        {
                            petname.text = "<���߶��� Ȱ���� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else
                    {
                        petname.text = "<�׸��>";
                    }
                }
                else
                {
                    petname.text = "<�׸��>";
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
                            petname.text = "<û�Ű���� �������� �׸��>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISTP
                        {
                            petname.text = "<���� ���ֲ� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //ISF
                    {
                        if (Mbti[6] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<�밨�� ��ȣ�� �׸��>";
                        }
                        else if (Mbti[6] < Mbti[7])  //ISFP
                        {
                            petname.text = "<ȣ��� ���� ������ �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else
                    {
                        petname.text = "<�׸��>";
                    }
                }
                else if (Mbti[2] < Mbti[3])  //IN
                {
                    if (Mbti[4] > Mbti[5])  //INT
                    {
                        if (Mbti[6] > Mbti[7])  //INTJ
                        {
                            petname.text = "<�����ֵ��� ������ �׸��>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INTP
                        {
                            petname.text = "<������ ����� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else if (Mbti[4] < Mbti[5])  //INF
                    {
                        if (Mbti[6] > Mbti[7])  //INFJ
                        {
                            petname.text = "<������ ��ȣ�� �׸��>";
                        }
                        else if (Mbti[6] < Mbti[7])  //INFP
                        {
                            petname.text = "<�������� ������ �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else
                    {
                        petname.text = "<�׸��>";
                    }
                }
                else
                {
                    petname.text = "<�׸��>";
                }
            }
            else
            {
                petname.text = "<�׸��>";
            }
        }
    }

    // ���� ���� mbti ���
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

        // ���� ����
        endingtext.text = a + b + c + d;
    }

    public void AfterEnding()
    {
        Start();
    }
}
