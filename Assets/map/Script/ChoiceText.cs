using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceText : MonoBehaviour
{
    Dictionary<int, string[]> choiceText;

    void Awake()
    {
        choiceText = new Dictionary<int, string[]>();
        GenerateData();
    }

    public string GetText(int id, int textIndex)
    {
        if(textIndex == choiceText[id].Length)
            return null;
        else
            return choiceText[id][textIndex];
    }

    public int GetChoiceNum(int id)
    {
        return choiceText[id].Length;
    }

    void GenerateData()
    {
        choiceText.Add(1000 + 10, new string[] {"한적한 벤치에 앉아 주위를 구경한다.", "재밌게 수다를 떨고 있는 사람들 틈에 낀다."});
        choiceText.Add(1000 + 20, new string[] {"평화로운 공원 분위기", "소꿉놀이하는 아이들"});
        choiceText.Add(1000 + 30, new string[] {"고양이의 주인이 누구인지 궁금해진다.", "편의점에서 고양이 밥을 사 온다."});
        choiceText.Add(1000 + 40, new string[] {"공원의 구조를 생각하며 어디까지 걷고 쉴지 정한다.", "일단 길을 따라서 걷는다."});
        choiceText.Add(1000 + 50, new string[] {"어디서 샀는지 물어본다.", "스스로 붕어빵 트럭을 찾는다."});
        choiceText.Add(1000 + 60, new string[] {"비가 오는구나.", "좋은 영감이 떠올랐어!"});
        choiceText.Add(1000 + 70, new string[] {"혹시 모르니 ‘위험’이라고 쓴 포스트잇을 붙인다.", "경비실에 찾아가 고쳐달라고 건의한다."});
        choiceText.Add(1000 + 80, new string[] {"주변에 보이는 벤치를 찾아 쉰다.", "중앙광장이 얼마 남지않았으니 도착하면 쉬자.", "힘드니 먼저 앉아 있는다."});
        choiceText.Add(1000 + 90, new string[] {"저 풍선 주세요!", "사슴 인형이 날 볼 때까지 기다린다."});
        choiceText.Add(1000 + 100, new string[] {"이제 남남이니까...", "오랜만이다! 인사해야지."});
        choiceText.Add(1000 + 110, new string[] {"즐겁게 공연을 구경하고 모자에 돈을 넣는다.", "이런 곳에서 공연을 해도 되는 걸까? 궁금하다."});
        choiceText.Add(1000 + 120, new string[] {"궁금하니 한 번 가 본다.", "궁금해서 흘깃 보고 가던 길을 간다.", "가던 길을 계속 가는 것이 중요하므로 지나간다."});

        choiceText.Add(2000 + 10, new string[] {""});
        choiceText.Add(2000 + 20, new string[] {""});
        choiceText.Add(2000 + 30, new string[] {""});
        choiceText.Add(2000 + 40, new string[] {""});
        choiceText.Add(2000 + 50, new string[] {""});
        choiceText.Add(2000 + 60, new string[] {""});
        choiceText.Add(2000 + 70, new string[] {""});
        choiceText.Add(2000 + 80, new string[] {""});
        choiceText.Add(2000 + 90, new string[] {""});
        choiceText.Add(2000 + 100, new string[] {""});
        choiceText.Add(2000 + 110, new string[] {""});
        choiceText.Add(2000 + 120, new string[] {""});

        choiceText.Add(3000 + 10, new string[] {""});
        choiceText.Add(3000 + 20, new string[] {""});
        choiceText.Add(3000 + 30, new string[] {""});
        choiceText.Add(3000 + 40, new string[] {""});
        choiceText.Add(3000 + 50, new string[] {""});
        choiceText.Add(3000 + 60, new string[] {""});
        choiceText.Add(3000 + 70, new string[] {""});
        choiceText.Add(3000 + 80, new string[] {""});
        choiceText.Add(3000 + 90, new string[] {""});
        choiceText.Add(3000 + 100, new string[] {""});
        choiceText.Add(3000 + 110, new string[] {""});
        choiceText.Add(3000 + 120, new string[] {""});

        choiceText.Add(4000 + 10, new string[] {""});
        choiceText.Add(4000 + 20, new string[] {""});
        choiceText.Add(4000 + 30, new string[] {""});
        choiceText.Add(4000 + 40, new string[] {""});
        choiceText.Add(4000 + 50, new string[] {""});
        choiceText.Add(4000 + 60, new string[] {""});
        choiceText.Add(4000 + 70, new string[] {""});
        choiceText.Add(4000 + 80, new string[] {""});
        choiceText.Add(4000 + 90, new string[] {""});
        choiceText.Add(4000 + 100, new string[] {""});
        choiceText.Add(4000 + 110, new string[] {""});
        choiceText.Add(4000 + 120, new string[] {""});

        choiceText.Add(5000 + 10, new string[] {""});
        choiceText.Add(5000 + 20, new string[] {""});
        choiceText.Add(5000 + 30, new string[] {""});
        choiceText.Add(5000 + 40, new string[] {""});
        choiceText.Add(5000 + 50, new string[] {""});
        choiceText.Add(5000 + 60, new string[] {""});
        choiceText.Add(5000 + 70, new string[] {""});
        choiceText.Add(5000 + 80, new string[] {""});
        choiceText.Add(5000 + 90, new string[] {""});
        choiceText.Add(5000 + 100, new string[] {""});
        choiceText.Add(5000 + 110, new string[] {""});
        choiceText.Add(5000 + 120, new string[] {""});

        choiceText.Add(6000 + 10, new string[] {""});
        choiceText.Add(6000 + 20, new string[] {""});
        choiceText.Add(6000 + 30, new string[] {""});
        choiceText.Add(6000 + 40, new string[] {""});
        choiceText.Add(6000 + 50, new string[] {""});
        choiceText.Add(6000 + 60, new string[] {""});
        choiceText.Add(6000 + 70, new string[] {""});
        choiceText.Add(6000 + 80, new string[] {""});
        choiceText.Add(6000 + 90, new string[] {""});
        choiceText.Add(6000 + 100, new string[] {""});
        choiceText.Add(6000 + 110, new string[] {""});
        choiceText.Add(6000 + 120, new string[] {""});

        choiceText.Add(7000 + 10, new string[] {""});
        choiceText.Add(7000 + 20, new string[] {""});
        choiceText.Add(7000 + 30, new string[] {""});
        choiceText.Add(7000 + 40, new string[] {""});
        choiceText.Add(7000 + 50, new string[] {""});
        choiceText.Add(7000 + 60, new string[] {""});
        choiceText.Add(7000 + 70, new string[] {""});
        choiceText.Add(7000 + 80, new string[] {""});
        choiceText.Add(7000 + 90, new string[] {""});
        choiceText.Add(7000 + 100, new string[] {""});
        choiceText.Add(7000 + 110, new string[] {""});
        choiceText.Add(7000 + 120, new string[] {""});

        choiceText.Add(8000 + 10, new string[] {""});
        choiceText.Add(8000 + 20, new string[] {""});
        choiceText.Add(8000 + 30, new string[] {""});
        choiceText.Add(8000 + 40, new string[] {""});
        choiceText.Add(8000 + 50, new string[] {""});
        choiceText.Add(8000 + 60, new string[] {""});
        choiceText.Add(8000 + 70, new string[] {""});
        choiceText.Add(8000 + 80, new string[] {""});
        choiceText.Add(8000 + 90, new string[] {""});
        choiceText.Add(8000 + 100, new string[] {""});
        choiceText.Add(8000 + 110, new string[] {""});
        choiceText.Add(8000 + 120, new string[] {""});
    }
}
