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
                            petname.text = "<������ ������ ���׸�>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESTP
                        {
                            petname.text = "<������ ���� ����� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ESF
                    {
                        if (Mbti[3] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<�米���� �ܱ��� ���׸�>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESFP
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
                else if (Mbti[1] < Mbti[5])  //EN
                {
                    if (Mbti[2] > Mbti[6])  //ENT
                    {
                        if (Mbti[3] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<����� ����� ���׸�>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENTP
                        {
                            petname.text = "<�߰ſ� ������ ���� ���а� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ENF
                    {
                        if (Mbti[3] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<���Ƿο� ��ȸ��� ���׸�>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENFP
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
            else if (Mbti[0] < Mbti[4])  //I
            {
                if (Mbti[1] > Mbti[5])  //IS
                {
                    if (Mbti[2] > Mbti[6])  //IST
                    {
                        if (Mbti[3] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<û�Ű���� �������� ���׸�>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISTP
                        {
                            petname.text = "<���� ���ֲ� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ISF
                    {
                        if (Mbti[3] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<�밨�� ��ȣ�� ���׸�>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISFP
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
                else if (Mbti[1] < Mbti[5])  //IN
                {
                    if (Mbti[2] > Mbti[6])  //INT
                    {
                        if (Mbti[3] > Mbti[7])  //INTJ
                        {
                            petname.text = "<�����ֵ��� ������ ���׸�>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INTP
                        {
                            petname.text = "<������ ����� ���׸�>";
                        }
                        else
                        {
                            petname.text = "<���׸�>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //INF
                    {
                        if (Mbti[3] > Mbti[7])  //INFJ
                        {
                            petname.text = "<������ ��ȣ�� ���׸�>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INFP
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
                            petname.text = "<������ ������ �����>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESTP
                        {
                            petname.text = "<������ ���� ����� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ESF
                    {
                        if (Mbti[3] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<�米���� �ܱ��� �����>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESFP
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
                else if (Mbti[1] < Mbti[5])  //EN
                {
                    if (Mbti[2] > Mbti[6])  //ENT
                    {
                        if (Mbti[3] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<����� ����� �����>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENTP
                        {
                            petname.text = "<�߰ſ� ������ ���� ���а� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ENF
                    {
                        if (Mbti[3] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<���Ƿο� ��ȸ��� �����>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENFP
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
            else if (Mbti[0] < Mbti[4])  //I
            {
                if (Mbti[1] > Mbti[5])  //IS
                {
                    if (Mbti[2] > Mbti[6])  //IST
                    {
                        if (Mbti[3] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<û�Ű���� �������� �����>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISTP
                        {
                            petname.text = "<���� ���ֲ� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ISF
                    {
                        if (Mbti[3] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<�밨�� ��ȣ�� �����>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISFP
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
                else if (Mbti[1] < Mbti[5])  //IN
                {
                    if (Mbti[2] > Mbti[6])  //INT
                    {
                        if (Mbti[3] > Mbti[7])  //INTJ
                        {
                            petname.text = "<�����ֵ��� ������ �����>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INTP
                        {
                            petname.text = "<������ ����� �����>";
                        }
                        else
                        {
                            petname.text = "<�����>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //INF
                    {
                        if (Mbti[3] > Mbti[7])  //INFJ
                        {
                            petname.text = "<������ ��ȣ�� �����>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INFP
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
            if (Mbti[0] > Mbti[4])  //E
            {
                if (Mbti[1] > Mbti[5])  //ES
                {
                    if (Mbti[2] > Mbti[6])  //EST
                    {
                        if (Mbti[3] > Mbti[7])  //ESTJ
                        {
                            petname.text = "<������ ������ �׸��>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESTP
                        {
                            petname.text = "<������ ���� ����� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ESF
                    {
                        if (Mbti[3] > Mbti[7])  //ESFJ
                        {
                            petname.text = "<�米���� �ܱ��� �׸��>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ESFP
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
                else if (Mbti[1] < Mbti[5])  //EN
                {
                    if (Mbti[2] > Mbti[6])  //ENT
                    {
                        if (Mbti[3] > Mbti[7])  //ENTJ
                        {
                            petname.text = "<����� ����� �׸��>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENTP
                        {
                            petname.text = "<�߰ſ� ������ ���� ���а� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ENF
                    {
                        if (Mbti[3] > Mbti[7])  //ENFJ
                        {
                            petname.text = "<���Ƿο� ��ȸ��� �׸��>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ENFP
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
            else if (Mbti[0] < Mbti[4])  //I
            {
                if (Mbti[1] > Mbti[5])  //IS
                {
                    if (Mbti[2] > Mbti[6])  //IST
                    {
                        if (Mbti[3] > Mbti[7])  //ISTJ
                        {
                            petname.text = "<û�Ű���� �������� �׸��>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISTP
                        {
                            petname.text = "<���� ���ֲ� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //ISF
                    {
                        if (Mbti[3] > Mbti[7])  //ISFJ
                        {
                            petname.text = "<�밨�� ��ȣ�� �׸��>";
                        }
                        else if (Mbti[3] < Mbti[7])  //ISFP
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
                else if (Mbti[1] < Mbti[5])  //IN
                {
                    if (Mbti[2] > Mbti[6])  //INT
                    {
                        if (Mbti[3] > Mbti[7])  //INTJ
                        {
                            petname.text = "<�����ֵ��� ������ �׸��>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INTP
                        {
                            petname.text = "<������ ����� �׸��>";
                        }
                        else
                        {
                            petname.text = "<�׸��>";
                        }
                    }
                    else if (Mbti[2] < Mbti[6])  //INF
                    {
                        if (Mbti[3] > Mbti[7])  //INFJ
                        {
                            petname.text = "<������ ��ȣ�� �׸��>";
                        }
                        else if (Mbti[3] < Mbti[7])  //INFP
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
}
