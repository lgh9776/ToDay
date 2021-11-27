using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> backgroundData;
    public Sprite[] backPlace;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        backgroundData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(0, new string[] {"[공원 도착]", "오랜만에 산책하러 공원에 오니 너무 좋아요! 무엇부터 할까요?"});
        talkData.Add(1, new string[] {"[주말 농장을 신청하는 중]", "00님은 농장을 어떻게 꾸미실건가요?"});
        talkData.Add(2, new string[] {"[박물관 도착]", "00님 저희는 어디서부터 볼까요?"});
        talkData.Add(3, new string[] {"00님 백화점에 오는건 정말 오랜만인 것 같아요! 어디부터 둘러 보실 건가요?"});
        talkData.Add(4, new string[] {"[식당가 도착]", "00님 오늘은 뭘 먹으면 좋을까요?"});
        talkData.Add(5, new string[] {"[자전거를 타고 가는 중 횡단보도 신호가 바뀌었다.]", "00님 이 횡단보도를 건너야 해요!"});
        talkData.Add(6, new string[] {"[학교 갈 준비하는 상황]", "00님 내일 준비물을 챙겨가야 하는데 언제 준비하면 될까요?"});
        talkData.Add(7, new string[] {"[오랜만에 긴 연휴로 바다에 가기로 한 00과 (펫이름)]", "태어나서 바다는 처음 보러 가는데 정말 기대돼요! 보통 바다에 가면 무엇을 하나요?"});

        backgroundData.Add(0, backPlace[0]);
        backgroundData.Add(1, backPlace[1]);
        backgroundData.Add(2, backPlace[2]);
        backgroundData.Add(3, backPlace[3]);
        backgroundData.Add(4, backPlace[4]);
        backgroundData.Add(5, backPlace[5]);
        backgroundData.Add(6, backPlace[6]);
        backgroundData.Add(7, backPlace[7]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if(talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public Sprite GetBackground(int id)
    {
        return backgroundData[id];
    }
}
