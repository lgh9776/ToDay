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

        choiceText.Add(2000 + 10, new string[] {"헤헷, 감사합니다! 옥수수가 정말... (대화를 이어나간다.)", "앗, 넵. 감사합니다..! 이것도 드셔보실래요?"});
        choiceText.Add(2000 + 20, new string[] {"한번 해보자!", "내가 1등 할 거야!"});
        choiceText.Add(2000 + 30, new string[] {"왜 이러지? 내가 잘못한 게 있었나?", "아쉽지만... 열심히 했으니까 됐어!"});
        choiceText.Add(2000 + 40, new string[] {"배정받은 농장을 나누어 어디에 어떤 것을 심을지 구상한다.", "농장을 배정받고 난 후, 심고 싶은 씨앗부터 구매한다."});
        choiceText.Add(2000 + 50, new string[] {"주민들과 함께 나눠 먹는다.", "혼자 먹고 남은 것은 버린다."});
        choiceText.Add(2000 + 60, new string[] {"시간 많으니 찬찬히 생각해보기로 한다.", "훗날 커다란 농장을 꾸리는 미래를 그린다."});
        choiceText.Add(2000 + 70, new string[] {"한땀한땀 키워낸 작물이 더 뿌듯하다! 물뿌리개", "효율이 중요하다! 스프링클러"});
        choiceText.Add(2000 + 80, new string[] {"수도가 고쳐지길 기다린 후, 줄 수 있는 만큼 물을 준다.", "이번 주에 심은 작물은 포기하고 다음 주를 노린다.", "수도 이외에 물을 길어올 방법을 고민하고, 작물에 물을 줄지 말지 결정한다."});
        choiceText.Add(2000 + 90, new string[] {"먼저 인사할 때까지 기다린다.", "먼저 인사를 건넨다."});
        choiceText.Add(2000 + 100, new string[] {"좋아! 내일도 농장에서 재밌게 놀자!", "내일은 늦잠 자고 싶은데..."});
        choiceText.Add(2000 + 110, new string[] {"돕고 살아야지! 옆 농장을 도와준다.", "도와드리면 덤이라도 주시지 않을까? 호기심이 생긴다."});
        choiceText.Add(2000 + 120, new string[] {"새싹들을 일정한 간격으로 둘 수 있게 솎아낸다.", "눈으로 보고 너무 모여 있는 것들만 솎아낸다.", "그냥 두고 자라나는 것만 키운다."});

        choiceText.Add(3000 + 10, new string[] {"이런 건 지금 아니면 못 하니까!", "재밌어 보이지만 사람이 많아서... 다음 기회에."});
        choiceText.Add(3000 + 20, new string[] {"이 그림의 작가는 19nn년 출생으로 현대미술의 아버지... (중얼중얼)", "나도 꼭 멋진 전시회 하나 열어봐야지!"});
        choiceText.Add(3000 + 30, new string[] {"셔터음이 민폐라서 그런가보다.", "왜 찍으면 안 되는 걸까? 궁금하다."});
        choiceText.Add(3000 + 40, new string[] {"박물관 안내 책자를 보고 동선을 정한다.", "박물관에서 정해둔 관람 순서에 따라 관람한다.", "눈에 띄는 것부터 본다."});
        choiceText.Add(3000 + 50, new string[] {"인터넷에 검색한다.", "큐레이터에게 질문한다."});
        choiceText.Add(3000 + 60, new string[] {"아직까지 살아 있었으면... 으, 상상만 해도 무서워.", "엄청 크네..."});
        choiceText.Add(3000 + 70, new string[] {"멋진 작품이 많아서 그렇겠지?", "뭐가 있길래... 팜플랫을 샅샅이 뒤져본다."});
        choiceText.Add(3000 + 80, new string[] {"바로 간다.", "관람을 마친 후 마지막에 간다."});
        choiceText.Add(3000 + 90, new string[] {"아, 괜찮습니다. ^^", "네...? 아... 넵......"});
        choiceText.Add(3000 + 100, new string[] {"사람이 너무 많은데 어떻게 돌아다니지...", "다음부터 사람 많은 날은 피해 다녀야겠어."});
        choiceText.Add(3000 + 110, new string[] {"조용히 보기나 하지... 눈치를 준다.", "은근슬쩍 이야기를 들으며 동감한다."});
        choiceText.Add(3000 + 120, new string[] {"줄이 없으니 대충 옆에 있다가 때가 되면 사진을 찍는다.", "관람에 방해가 되지 않는 곳에서 줄을 만들어 기다린다."});

        choiceText.Add(4000 + 10, new string[] {"이런 스타일의 옷이 있는지 직원에게 물어본다.", "비슷한 옷을 찾을 때까지 백화점을 계속 배회한다."});
        choiceText.Add(4000 + 20, new string[] {"비싸네...", "대체 얼마를 벌어야 살 수 있는거지...?"});
        choiceText.Add(4000 + 30, new string[] {"인기 많은 상품이었나? 아니었던 것 같은데...", "늦는 이유가 있겠지...? 어쩔 수 없으니 기다리자."});
        choiceText.Add(4000 + 40, new string[] {"눈에 보이는 대로 간다.", "사야 할 물건이 배치된 매장부터 둘러본다.", "금강산도 식후경! 일단 밥부터 먹는다."});
        choiceText.Add(4000 + 50, new string[] {"옷에 대해 궁금한 점을 물어본다.", "아, 다음에 올게요...!"});
        choiceText.Add(4000 + 60, new string[] {"살찌니까 안 돼...", "먹고 싶은 거 다 담자!"});
        choiceText.Add(4000 + 70, new string[] {"뭘 주려는 걸까? 일단 물어본다.", "일단 2만원 어치를 더 산다."});
        choiceText.Add(4000 + 80, new string[] {"마음에 들고, 놔두면 쓸 것 같으니 구매한다.", "마음에 들지만, 실용적인지 생각해보고 구매한다."});
        choiceText.Add(4000 + 90, new string[] {"비켜달라고 말한다.", "비켜줄 때까지 기다린다."});
        choiceText.Add(4000 + 100, new string[] {"지금 입을 옷을 살 거야!", "다음 계절에 입을 옷을 미리 사 둘 거야!"});
        choiceText.Add(4000 + 110, new string[] {"부모님과 마지막으로 만난 곳이 어디인지 물어본다.", "가여워라... 부모님을 함께 찾아준다."});
        choiceText.Add(4000 + 120, new string[] {"쇼핑하다가 놓친 게 있는지 확인하고 떠난다.", "오늘의 쇼핑은 즐겼으니 떠나고 필요한 게 생기면 다시 온다."});

        choiceText.Add(5000 + 10, new string[] {"크게 직원을 불러본다.", "직원의 일이 끝나고, 나를 발견할 때까지 기다린다."});
        choiceText.Add(5000 + 20, new string[] {"뭐 먹지...?", "다음에 또 와서 안 먹은 메뉴 먹어봐야겠다!"});
        choiceText.Add(5000 + 30, new string[] {"오늘따라 바쁘네... 직원분들 힘드시겠다.", "왜 이렇게 바쁘지? 이벤트라도 하나?"});
        choiceText.Add(5000 + 40, new string[] {"아무 곳이나 들어간다.", "전부터 가고 싶었던 맛집으로 간다.", "미리 봐둔 식당으로 들어간다."});
        choiceText.Add(5000 + 50, new string[] {"네! 너무 맛있었어요. 다음에 또 올게요! 잘 먹었습니다~", "아, 네... 맛있었어요! (머쓱)"});
        choiceText.Add(5000 + 60, new string[] {"맞아, 다 맛있어서 기분 좋았어!", "너무 행복... 다음에도 맛집 찾아가야지!"});
        choiceText.Add(5000 + 70, new string[] {"어쩌면 좋아... 함께 안절부절한다.", "그 버튼만 누르면 끝나는데 왜 못하지? 의문이다."});
        choiceText.Add(5000 + 80, new string[] {"먹어보지 않았지만 맛있어 보이는 메뉴에 도전한다.", "오늘의 추천 메뉴를 선택한다.", "항상 먹던 것을 주문한다."});
        choiceText.Add(5000 + 90, new string[] {"메뉴판에서 열심히 찾는다.", "어떤 메뉴인지 옆 테이블 손님에게 물어본다."});
        choiceText.Add(5000 + 100, new string[] {"짜증나! 따지고 올게.", "(속으로) 짜증나..."});
        choiceText.Add(5000 + 110, new string[] {"바쁘신가보다... 기다리자.", "설마 내 주문 잊어버렸나?"});
        choiceText.Add(5000 + 120, new string[] {"다른 계획은 없으니 집으로 돌아간다.", "일단 나가서 걸으며 생각한다.", "집에 돌아가기 아쉬우니 주변에서 할 것을 찾고 나간다."});

        choiceText.Add(6000 + 10, new string[] {"친구야!!! 큰 소리로 불러본다.", "메신저를 통해 ‘네 앞에 나 있다’를 알려본다."});
        choiceText.Add(6000 + 20, new string[] {"햐... 멋지다.", "나도 성공해서 꼭 멋진 자동차를 가져야지!"});
        choiceText.Add(6000 + 30, new string[] {"지름길은 없나? 골똘히 생각한다.", "늦을 것 같다고 솔직하게 이야기한다. 미안하다..."});
        choiceText.Add(6000 + 40, new string[] {"원칙에 따라 자전거에서 내려 끌고 건너간다.", "횡단보도의 자전거 도로를 따라 자전거를 타고 간다."});
        choiceText.Add(6000 + 50, new string[] {"어, 어어...!!!", "저기요! 건너시면 안 돼요!"});
        choiceText.Add(6000 + 60, new string[] {"안돼.", "안돼!!!"});
        choiceText.Add(6000 + 70, new string[] {"깜짝이야! 무슨 급한 일 있나?", "깜짝이야! 사고 나면 어쩌려고..."});
        choiceText.Add(6000 + 80, new string[] {"다른 경로를 탐색한 후 출발한다.", "일단 옆길로 빠진 후 가면서 길을 찾는다."});
        choiceText.Add(6000 + 90, new string[] {"얼른 뛰어 간다.", "째려보면서 간다."});
        choiceText.Add(6000 + 100, new string[] {"지각하면 선생님께 혼나고 친구들한테도 놀림 받고... 수업 끝나면 청소를...", "큰일 났네..."});
        choiceText.Add(6000 + 110, new string[] {"안전하게 건너실 수 있도록 돕는다.", "주변에 차 없으니까 괜찮겠지? 제 갈 길 간다."});
        choiceText.Add(6000 + 120, new string[] {"5초가 지나기 전에 어서 건넌다.", "지금은 힘들 것 같으니 다음 신호를 기다린다."});

        choiceText.Add(7000 + 10, new string[] {"안녕? 나는~.. (반 친구들에게 적극적으로 다가간다.)", "... (누군가 다가오기를 기다린다.)"});
        choiceText.Add(7000 + 20, new string[] {"가지 말자!", "오늘 빠지면 결석이... 나중에 출결이 문제가 될 수도 있고, 또..."});
        choiceText.Add(7000 + 30, new string[] {"선도부 친구들에게 감정으로 호소한다.", "명찰로 눈속임할 만한 것이 없을지 고민한다."});
        choiceText.Add(7000 + 40, new string[] {"조금 일찍 출발해서 등교 전에 준비물을 사 간다.", "학교 가는 길에 준비물을 사 간다.", "전날 미리 준비한다."});
        choiceText.Add(7000 + 50, new string[] {"조용하고 한적한 카페", "떠들썩하고 북적북적한 게임센터"});
        choiceText.Add(7000 + 60, new string[] {"떡볶이는 탄수화물이면서 100g에 200~250 정도의 칼로리로...", "배 터지게 먹고 와!"});
        choiceText.Add(7000 + 70, new string[] {"괜찮아? 보건실에 데려가 준다.", "어제 무리했어? 일단 물어본다."});
        choiceText.Add(7000 + 80, new string[] {"토론을 원활하게 이끌어 가는 진행자 역할", "토론 중 의견을 제시하는 역할", "의견을 모아 정리하고 발표하는 역할"});
        choiceText.Add(7000 + 90, new string[] {"옆에서 박수를 치며 웃는다.", "같이 춤을 춘다."});
        choiceText.Add(7000 + 100, new string[] {"이겼어?", "왜 싸웠어?"});
        choiceText.Add(7000 + 110, new string[] {"무슨 바람이 부신 걸까... 궁금하다.", "선생님...!! 무척 감동한다."});
        choiceText.Add(7000 + 120, new string[] {"일단 오늘은 수업을 들었으니 논다.", "당장 하기는 귀찮으니 마감 하루 전날 한다.", "오늘 수업을 복습하면서 과제를 진행한다."});

        choiceText.Add(8000 + 10, new string[] {"이제 본격적으로 바다에서 놀아볼까?!", "팬션에서 좀 쉬엄쉬엄 놀아야지."});
        choiceText.Add(8000 + 20, new string[] {"오랜만에 쉬어서 그런지 너무 좋다~", "바다가 너무 예쁘다~"});
        choiceText.Add(8000 + 30, new string[] {"도대체 누가 버린거야?", "일단 줍는 게 좋겠지?"});
        choiceText.Add(8000 + 40, new string[] {"놀러 갈 땐 몸만 가면 돼! 뭐 하고 놀 건지도 그때 정하자~", "바다에 가니까 여벌 옷도 챙겨야 하고... 주변 식당도 미리 알아봐야지!"});
        choiceText.Add(8000 + 50, new string[] {"여러 사람을 만날 수 있는 게스트 하우스", "혼자서 푹 쉴 수 있는 호텔"});
        choiceText.Add(8000 + 60, new string[] {"몽글몽글...", "너무 좋다.. 매일 이렇게 쉬었으면!"});
        choiceText.Add(8000 + 70, new string[] {"틀릴 수도 있지~", "비 안 온다면서... 내가 날짜를 잘못 봤나?"});
        choiceText.Add(8000 + 80, new string[] {"어서 바다에 들어가자!", "괜찮은 위치에 자리 잡고 짐 정리부터 하자!", "바다에 들어가기 전에 물놀이할 준비부터 하자!"});
        choiceText.Add(8000 + 90, new string[] {"새로운 친구를 사귈 수 있겠네! 좋아!", "모르는 사람만 가득... 별론데..."});
        choiceText.Add(8000 + 100, new string[] {"수영이랑 서핑이랑... 다 하자!", "시간을 효율적으로 쓰려면 숙소에서 짐을 먼저 챙기고..."});
        choiceText.Add(8000 + 110, new string[] {"날씨가 엄청 더운데 왜 시원할까? 궁금하다.", "시원하다! 역시 여름엔 바다가 최고야~"});
        choiceText.Add(8000 + 120, new string[] {"저녁 먹으러 가는 길이니 참는다.", "당장 배고프니 포장마차에서 간단히 사 먹는다."});
    }
}
