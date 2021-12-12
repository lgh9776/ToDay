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

    public string GetTalk(int id, int talkIndex)
    {
        if(talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public void CheckText(GameObject scanObj)
    {
        ObjectData objData = scanObj.GetComponent<ObjectData>();

        if(objData.id != 9000){
            int n = Random.Range(1, 13);
            objData.textNum = 10;
            objData.textNum *= n;
        }
    }

    public Sprite GetBackground(int id)
    {
        return backgroundData[id];
    }

    void GenerateData()
    {
        talkData.Add(9000 + 10, new string[] {"집으로 갑니다!"});

        //quest Talk
        talkData.Add(1000 + 10, new string[] {"공원에 도착했어요!", "무엇을 할까요?"});
        talkData.Add(1000 + 20, new string[] {"이 공원은 올 때마다 기분이 좋네요!", "무엇이 눈에 띄나요?"});
        talkData.Add(1000 + 30, new string[] {"공원 한 구석에 초록색 이름표를 단 고양이가 웅크리고 있어요.", "배고픈 모양인데..."});
        talkData.Add(1000 + 40, new string[] {"[공원 도착]", "오랜만에 산책하러 공원에 오니 너무 좋아요! 무엇부터 할까요?"});
        talkData.Add(1000 + 50, new string[] {"아이가 붕어빵을 먹고 있군요.", "맛있어 보이는데..."});
        talkData.Add(1000 + 60, new string[] {"모처럼 공원에 와서 그런지 기분이 좋군요.", "그런데... 비가 오네요."});
        talkData.Add(1000 + 70, new string[] {"그네 줄이 끊어져 있어요!", "누군가가 이 그네를 탄다면 다칠지도 몰라요."});
        talkData.Add(1000 + 80, new string[] {"오랜만에 걸었더니 너무 힘들어요...", "쉬었다 가면 안 될까요?"});
        talkData.Add(1000 + 90, new string[] {"사슴 인형이 풍선을 나눠주고 있어요.", "풍선을 받고 싶어 인형 앞에 섰지만, 인형은 날 보지 못한 것 같아요..."});
        talkData.Add(1000 + 100, new string[] {"어라? 익숙한 얼굴이 보입니다.", "어릴 때 함께 놀던 친구 같은걸요."});
        talkData.Add(1000 + 110, new string[] {"공원 한복판에서 공연을 하고 있습니다.", "어떻게 할까요?"});
        talkData.Add(1000 + 120, new string[] {"사람들이 잔뜩 모여 있어요!", "뭘 하는걸까요?", "한 번 볼까요?"});

        talkData.Add(2000 + 10, new string[] {"주민분께서 말을 걸어오네요.", "주민 : 아이고 귀여워라~ 이거 옥수수인데 하나 먹어볼래요? ^^"});
        talkData.Add(2000 + 20, new string[] {"주말농장에 방문했습니다.", "오렌지를 누가누가 많이 따나 내기할까요?"});
        talkData.Add(2000 + 30, new string[] {"어라? 열심히 키운 작물의 상태가 영 좋지 않습니다."});
        talkData.Add(2000 + 40, new string[] {"주말농장을 신청하고 있습니다.", "배정받은 농장을 어떻게 꾸미고 싶은가요?"});
        talkData.Add(2000 + 50, new string[] {"음식을 만들었는데... 양이 너무 많아졌어요.", "어떻게 하죠?"});
        talkData.Add(2000 + 60, new string[] {"즐거운 농장 체험이었어요.", "다음에 또 방문하면 무엇을 할까요? 설렘이 가득합니다."});
        talkData.Add(2000 + 70, new string[] {"스프링클러와 물뿌리개 중 무엇을 사용하고 싶나요?"});
        talkData.Add(2000 + 80, new string[] {"작물에 물을 주던 중, 수도가 고장나고 말았어요.", "언제 고쳐질지도 모르는 상황인데... 어쩌죠?"});
        talkData.Add(2000 + 90, new string[] {"옆 농장 주인분이 놀러왔어요!"});
        talkData.Add(2000 + 100, new string[] {"답답했던 속이 풀리는 것만 같습니다.", "친구는 내일 아침에도 일찍 일어나서 농장에 오는 건 어떻겠냐고 물어오네요."});
        talkData.Add(2000 + 110, new string[] {"옆 농장에서 일하시는 분들이 꽤나 고생하고 있군요.", "이쪽 일은 대충 끝났는데... 어떻게 할까요?"});
        talkData.Add(2000 + 120, new string[] {"밭에 새싹이 쑥쑥 자랐어요.", "슬슬 솎아낼 필요가 있겠군요.", "어떤 걸 솎아내면 좋을까요?"});

        talkData.Add(3000 + 10, new string[] {"박물관에 체험형 전시관이 있군요." ,"인기가 많은지 사람들이 바글거려요."});
        talkData.Add(3000 + 20, new string[] {"미술관에 비치된 한 작가의 작품이 정말 인상적이군요.", "어떤 생각이 드나요?"});
        talkData.Add(3000 + 30, new string[] {"미술관 입구에는 ‘사진 촬영 금지’라는 안내 표지판이 놓여 있습니다."});
        talkData.Add(3000 + 40, new string[] {"박물관에 도착했습니다.", "어디서부터 둘러볼 건가요?"});
        talkData.Add(3000 + 50, new string[] {"전시 해설을 듣던 중, 궁금한 점이 생겼어요."});
        talkData.Add(3000 + 60, new string[] {"박물관의 화석은 무척 거대했습니다.", "무슨 생각이 드나요?"});
        talkData.Add(3000 + 70, new string[] {"박물관 입장료가 생각보다 비싸군요.", "보고 싶었던 전시라 그런지 물러나긴 영 아쉽습니다."});
        talkData.Add(3000 + 80, new string[] {"저기 기념품 스토어가 있네요!", "들어가 볼까요?"});
        talkData.Add(3000 + 90, new string[] {"큐레이터가 다가와 전시 해설을 원하는지 묻네요.", "오늘은 혼자 보고 싶은데..."});
        talkData.Add(3000 + 100, new string[] {"박물관에 사람이 너무 많습니다.", "움직이기가 힘들 정도예요."});
        talkData.Add(3000 + 110, new string[] {"시끄럽게 떠드는 사람들이 있습니다.", "관람에 집중하기가 힘들 정도예요. 어쩌죠?"});
        talkData.Add(3000 + 120, new string[] {"박물관 포토존에 도착했습니다.", "그런데... 사람이 너무 몰려있어요.", "제대로 된 줄도 없어 보이네요.", "사진은 꼭 찍고 싶은데 말이죠!"});

        talkData.Add(4000 + 10, new string[] {"쇼핑몰에서 봤던 디자인과 비슷한 옷을 찾고 있는데 통 안 보이네요."});
        talkData.Add(4000 + 20, new string[] {"이럴수가! 이 가게는 물건이 너무 비싸군요."});
        talkData.Add(4000 + 30, new string[] {"꼭 사고 싶었던 물건이 품절되었다네요.", "빨라도 다음 달에나 구할 수 있다고 합니다."});
        talkData.Add(4000 + 40, new string[] {"백화점에 오는 건 정말 오랜만이군요! 어디부터 둘러볼까요?"});
        talkData.Add(4000 + 50, new string[] {"옷을 구경하던 중, 직원이 말을 걸어옵니다."});
        talkData.Add(4000 + 60, new string[] {"오늘따라 유난히 과자가 맛있어 보이네요."});
        talkData.Add(4000 + 70, new string[] {"오늘 쇼핑에서 8만원 어치를 구매했습니다.", "10만원을 채우면 사은품을 준다네요."});
        talkData.Add(4000 + 80, new string[] {"마음에 드는 물건을 발견했어요.", "사고 싶은데..."});
        talkData.Add(4000 + 90, new string[] {"원하는 물건 앞에 다른 사람이 서 있습니다."});
        talkData.Add(4000 + 100, new string[] {"예쁜 옷이 많군요. 어떤 옷을 살 건가요?"});
        talkData.Add(4000 + 110, new string[] {"백화점 한복판에서 미아가 된 아이를 발견했습니다. 어떻게 하죠?"});
        talkData.Add(4000 + 120, new string[] {"즐거운 쇼핑을 마치고, 이만 백화점을 나서려 합니다."});

        talkData.Add(5000 + 10, new string[] {"식당에 들어왔습니다만... 직원 분들이 바쁜지 날 보지 못한 모양이에요."});
        talkData.Add(5000 + 20, new string[] {"이 식당은 메뉴가 정말 다양하군요!"});
        talkData.Add(5000 + 30, new string[] {"단골 레스토랑에 도착했어요.", "그런데... 가게에 줄을 섰네요?", "적어도 40분은 기다려야겠어요."});
        talkData.Add(5000 + 40, new string[] {"식당가에 도착했어요. 어느 가게로 들어갈까요?"});
        talkData.Add(5000 + 50, new string[] {"식사를 마치고...", "직원 : 식사는 어떠셨어요?"});
        talkData.Add(5000 + 60, new string[] {"오늘 먹은 초밥은 정말 맛있었죠?", "특히 그 연어 초밥 말이에요."});
        talkData.Add(5000 + 70, new string[] {"식사를 마치고, 계산을 위해 카운터 앞에 섰습니다.", "그런데... 초보 아르바이트생인지 포스기를 다루는 데에 무척 서투네요. 어쩌죠?"});
        talkData.Add(5000 + 80, new string[] {"식당에서 저녁 메뉴를 고르고 있습니다.", "무엇을 먹으면 좋을까요?"});
        talkData.Add(5000 + 90, new string[] {"옆 테이블에서 시킨 음식이 무척 맛있어 보이네요. 무슨 메뉴일까요?"});
        talkData.Add(5000 + 100, new string[] {"이런... 새치기 하는 사람이 있군요."});
        talkData.Add(5000 + 110, new string[] {"어라? 아무리 기다려도 주문한 메뉴가 나오지 않아요."});
        talkData.Add(5000 + 120, new string[] {"저녁 식사를 마쳤습니다. 무엇을 할까요?"});

        talkData.Add(6000 + 10, new string[] {"신호를 기다리던 중, 건너편에 친한 친구가 보여요."});
        talkData.Add(6000 + 20, new string[] {"방금 지나간 자동차 멋지게 생겼네요!"});
        talkData.Add(6000 + 30, new string[] {"이럴수가! 약속 시간까지 5분도 채 남지 않았어요. 어쩌죠?"});
        talkData.Add(6000 + 40, new string[] {"자전거를 타고 가던 중 신호가 바뀌었습니다. 어쩌죠?"});
        talkData.Add(6000 + 50, new string[] {"어떤 사람이 무단횡단을 하려고 해요!"});
        talkData.Add(6000 + 60, new string[] {"시간이 없어서인지 옆 친구가 무단횡단을 하려고 합니다."});
        talkData.Add(6000 + 70, new string[] {"횡단보도를 건너고 있습니다.", "그런데... 오토바이가 신호를 무시하고 당신 앞을 지나가네요."});
        talkData.Add(6000 + 80, new string[] {"여기는 불법주차가 심하네요. 길이 꽉 막혀 버렸어요."});
        talkData.Add(6000 + 90, new string[] {"횡단보도의 신호가 초록불인데, 한 차가 자꾸만 출발하려고 하네요."});
        talkData.Add(6000 + 100, new string[] {"급한데... 신호가 왜 안 바뀌는 걸까요?"});
        talkData.Add(6000 + 110, new string[] {"어르신께서 횡단보도를 건너고 계십니다. 곧 빨간불로 바뀔 것 같아요.", "하지만 당신은 이미 지나온 길입니다. 어쩌죠?"});
        talkData.Add(6000 + 120, new string[] {"횡단보도의 초록 불이 고작 5초 남짓이군요.", "달려가서 건널까요?"});

        talkData.Add(7000 + 10, new string[] {"새 학기가 되었어요!", "반에는 처음 보는 친구들밖에 없네요."});
        talkData.Add(7000 + 20, new string[] {"오늘따라 학교 가기가 끔찍이도 싫습니다."});
        talkData.Add(7000 + 30, new string[] {"이럴수가! 명찰을 두고 왔어요. 이대로 가면 벌점을 받을 텐데...", "집에 다녀오기에는 늦었군요. 어쩌죠?"});
        talkData.Add(7000 + 40, new string[] {"선생님 : 내일 수업은 준비물이 있습니다.", "언제쯤 챙기면 좋을까요?"});
        talkData.Add(7000 + 50, new string[] {"친구들과 방과 후에 놀기로 약속했어요! 어디로 갈까요?"});
        talkData.Add(7000 + 60, new string[] {"학교 끝나고 친구들과 떡볶이를 먹기로 약속했어요."});
        talkData.Add(7000 + 70, new string[] {"오늘따라 친구 몸 상태가 좋지 않은 모양입니다."});
        talkData.Add(7000 + 80, new string[] {"오늘은 팀 수업이 진행되는 날입니다.", "한 주제에 대해 토론하고 의견을 정리하여 발표해야 하는데... 어떤 역할을 담당할까요?"});
        talkData.Add(7000 + 90, new string[] {"수학여행을 왔어요!", "레크레이션 시간이 되니 노래가 신나기도 하고, 다같이 춤판이 벌어졌어요."});
        talkData.Add(7000 + 100, new string[] {"A가 B라는 친구와 싸웠다네요. 어떡하죠?"});
        talkData.Add(7000 + 110, new string[] {"웬 일이죠? 선생님께서 자유 시간을 주셨습니다. 어떤 생각이 드나요?"});
        talkData.Add(7000 + 120, new string[] {"오늘 수업 중에 과제를 받았어요. 썩 어려운 과제는 아니군요.", "다음 수업 전까지만 끝내면 되는데, 언제 하면 좋을까요?"});

        talkData.Add(8000 + 10, new string[] {"드디어 팬션에 도착했어요!", "창밖으로 보이는 바다가 참 아름답네요."});
        talkData.Add(8000 + 20, new string[] {"아름다운 경치와 맑은 바다가 시야에 들어옵니다."});
        talkData.Add(8000 + 30, new string[] {"간만에 온 여행인데... 바닷가에 쓰레기가 잔뜩이군요. 어떤 생각이 드나요?"});
        talkData.Add(8000 + 40, new string[] {"정말 기대되는 여행입니다!", "바다에 갈 때 무엇을 준비할 예정인가요?"});
        talkData.Add(8000 + 50, new string[] {"친구와 여행을 떠나기로 결정했어요.", "숙소를 어디로 정할까요?"});
        talkData.Add(8000 + 60, new string[] {"한산한 바닷가의 맑은 공기 덕분에 마음이 편안해집니다."});
        talkData.Add(8000 + 70, new string[] {"어라? 갑자기 비가 오기 시작합니다.", "분명 일기 예보에서 비 소식은 없었는데 말이죠."});
        talkData.Add(8000 + 80, new string[] {"기대하던 바다에 도착했습니다! 바다가 정말 예쁘네요.", "무엇부터 하면 좋을까요?"});
        talkData.Add(8000 + 90, new string[] {"휴양지에서 생긴 친구가 바비큐 파티에 초대해 주었어요!", "그런데... 이 친구 말고는 아는 사람이 없어요."});
        talkData.Add(8000 + 100, new string[] {"모처럼 바닷가에 왔는데, 무엇을 하고 놀까요?"});
        talkData.Add(8000 + 110, new string[] {"바닷물이 시원하고 좋습니다.", "어떤 생각이 드나요?"});
        talkData.Add(8000 + 120, new string[] {"물놀이를 마쳤더니 슬슬 배가 고프네요.", "인근 포장마차에서 뭐라도 먹을까요?"});

        backgroundData.Add(1000, backPlace[0]);
        backgroundData.Add(2000, backPlace[1]);
        backgroundData.Add(3000, backPlace[2]);
        backgroundData.Add(4000, backPlace[3]);
        backgroundData.Add(5000, backPlace[4]);
        backgroundData.Add(6000, backPlace[5]);
        backgroundData.Add(7000, backPlace[6]);
        backgroundData.Add(8000, backPlace[7]);
        backgroundData.Add(9000, backPlace[8]);
    }
}
