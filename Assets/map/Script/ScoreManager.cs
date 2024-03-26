using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

    public class ScoreManager : MonoBehaviour
{
    Dictionary<int, int[]> score;
    public MBTIGauage mbtiGauage;
    public GameManager gameManager;

    string path;
    string filenamae = "save";

    void Awake()
    {
        path = Application.persistentDataPath + "/";

        score = new Dictionary<int, int[]>();
        GenerateData();
    }

    //수치 변화 시 지도의 캐릭터 데이터 저장 -> 홈과 맵을 이동할 때 유지되도록
    public void ChoiceScore(int id)
    {
        for(int i = 0; i < 8; i++){
            mbtiGauage.Mbti[i] += score[id][i];
            //메인화면 mbti점수 int형 배열[i] += score[id][i];
        }
        gameManager.interactnum--;
        //SaveData();
    }

    /* 캐릭터 데이터 수치 class로 뽑기
    public void SaveData()
    {
        string data = JsonUtility.ToJson(mbtiGauage.Mbti[0]);
        File.WriteAllText(path + filenamae, data);
    }

    public void LoadData()
    {
        string data = File.ReadAllText(path + filenamae);
        playerData = JsonUtility.FromJson<PlayerData>(data);
    }
    */

    void GenerateData()
    {
        //E I S N T F J P
        //장소 id + 대화 id + 버튼 id
        score.Add(1000 + 10 + 1, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(1000 + 10 + 2, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(1000 + 20 + 1, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(1000 + 20 + 2, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(1000 + 30 + 1, new int[] {0, 0, 0, 0, 10, 0, 0, 0});
        score.Add(1000 + 30 + 2, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(1000 + 40 + 1, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(1000 + 40 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(1000 + 50 + 1, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(1000 + 50 + 2, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(1000 + 60 + 1, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(1000 + 60 + 2, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(1000 + 70 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(1000 + 70 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(1000 + 80 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 10});
        score.Add(1000 + 80 + 2, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(1000 + 80 + 3, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(1000 + 90 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(1000 + 90 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(1000 + 100 + 1, new int[] {0, 0, 5, 0, 0, 0, 0, 0});
        score.Add(1000 + 100 + 2, new int[] {0, 0, 0, 5, 0, 0, 0, 0});
        score.Add(1000 + 110 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(1000 + 110 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(1000 + 120 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 10});
        score.Add(1000 + 120 + 2, new int[] {0, 0, 0, 0, 0, 0, 5, 0});
        score.Add(1000 + 120 + 3, new int[] {0, 0, 0, 0, 5, 0, 10, 0});

        score.Add(2000 + 10 + 1, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(2000 + 10 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(2000 + 20 + 1, new int[] {0, 0, 0, 5, 0, 0, 0, 0});
        score.Add(2000 + 20 + 2, new int[] {0, 0, 5, 0, 0, 0, 0, 0});
        score.Add(2000 + 30 + 1, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(2000 + 30 + 2, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(2000 + 40 + 1, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(2000 + 40 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(2000 + 50 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(2000 + 50 + 2, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(2000 + 60 + 1, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(2000 + 60 + 2, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(2000 + 70 + 1, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(2000 + 70 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(2000 + 80 + 1, new int[] {0, 0, 0, 0, 5, 0, 5, 0});
        score.Add(2000 + 80 + 2, new int[] {0, 0, 0, 5, 0, 0, 0, 10});
        score.Add(2000 + 80 + 3, new int[] {0, 0, 5, 0, 5, 0, 10, 0});
        score.Add(2000 + 90 + 1, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(2000 + 90 + 2, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(2000 + 100 + 1, new int[] {0, 0, 5, 10, 0, 0, 0, 0});
        score.Add(2000 + 100 + 2, new int[] {0, 0, 10, 5, 0, 0, 0, 0});
        score.Add(2000 + 110 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(2000 + 110 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(2000 + 120 + 1, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(2000 + 120 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 5});
        score.Add(2000 + 120 + 3, new int[] {0, 0, 0, 0, 0, 0, 0, 20});

        score.Add(3000 + 10 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(3000 + 10 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(3000 + 20 + 1, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(3000 + 20 + 2, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(3000 + 30 + 1, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(3000 + 30 + 2, new int[] {0, 0, 0, 0, 10, 0, 0, 0});
        score.Add(3000 + 40 + 1, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(3000 + 40 + 2, new int[] {0, 0, 0, 0, 0, 0, 5, 5});
        score.Add(3000 + 40 + 3, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(3000 + 50 + 1, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(3000 + 50 + 2, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(3000 + 60 + 1, new int[] {0, 0, 0, 5, 0, 0, 0, 0});
        score.Add(3000 + 60 + 2, new int[] {0, 0, 5, 0, 0, 0, 0, 0});
        score.Add(3000 + 70 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(3000 + 70 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(3000 + 80 + 1, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(3000 + 80 + 2, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(3000 + 90 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(3000 + 90 + 2, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(3000 + 100 + 1, new int[] {0, 0, 5, 5, 0, 0, 0, 0});
        score.Add(3000 + 100 + 2, new int[] {0, 0, 10, 5, 0, 0, 0, 0});
        score.Add(3000 + 110 + 1, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(3000 + 110 + 2, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(3000 + 120 + 1, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(3000 + 120 + 2, new int[] {0, 0, 0, 0, 0, 0, 10, 0});

        score.Add(4000 + 10 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(4000 + 10 + 2, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(4000 + 20 + 1, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(4000 + 20 + 2, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(4000 + 30 + 1, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(4000 + 30 + 2, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(4000 + 40 + 1, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(4000 + 40 + 2, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(4000 + 40 + 3, new int[] {0, 0, 0, 0, 0, 5, 0, 10});
        score.Add(4000 + 50 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(4000 + 50 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(4000 + 60 + 1, new int[] {0, 0, 0, 5, 0, 0, 0, 0});
        score.Add(4000 + 60 + 2, new int[] {0, 0, 5, 0, 0, 0, 0, 0});
        score.Add(4000 + 70 + 1, new int[] {0, 0, 0, 0, 10, 0, 0, 0});
        score.Add(4000 + 70 + 2, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(4000 + 80 + 1, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(4000 + 80 + 2, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(4000 + 90 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(4000 + 90 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(4000 + 100 + 1, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(4000 + 100 + 2, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(4000 + 110 + 1, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(4000 + 110 + 2, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(4000 + 120 + 1, new int[] {0, 0, 0, 0, 5, 0, 10, 0});
        score.Add(4000 + 120 + 2, new int[] {0, 0, 0, 5, 0, 0, 0, 10});

        score.Add(5000 + 10 + 1, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(5000 + 10 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(5000 + 20 + 1, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(5000 + 20 + 2, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(5000 + 30 + 1, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(5000 + 30 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(5000 + 40 + 1, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(5000 + 40 + 2, new int[] {0, 0, 0, 0, 5, 0, 10, 0});
        score.Add(5000 + 40 + 3, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(5000 + 50 + 1, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(5000 + 50 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(5000 + 60 + 1, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(5000 + 60 + 2, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(5000 + 70 + 1, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(5000 + 70 + 2, new int[] {0, 0, 0, 0, 10, 0, 0, 0});
        score.Add(5000 + 80 + 1, new int[] {0, 0, 0, 5, 0, 0, 0, 10});
        score.Add(5000 + 80 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 5});
        score.Add(5000 + 80 + 3, new int[] {0, 0, 5, 0, 0, 0, 10, 0});
        score.Add(5000 + 90 + 1, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(5000 + 90 + 2, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(5000 + 100 + 1, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(5000 + 100 + 2, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(5000 + 110 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(5000 + 110 + 2, new int[] {0, 0, 0, 0, 10, 0, 0, 0});
        score.Add(5000 + 120 + 1, new int[] {0, 5, 0, 0, 0, 0, 10, 0});
        score.Add(5000 + 120 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(5000 + 120 + 3, new int[] {5, 0, 0, 0, 0, 0, 10, 0});

        score.Add(6000 + 10 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(6000 + 10 + 2, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(6000 + 20 + 1, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(6000 + 20 + 2, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(6000 + 30 + 1, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(6000 + 30 + 2, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(6000 + 40 + 1, new int[] {0, 0, 0, 0, 0, 0, 5, 0});
        score.Add(6000 + 40 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 5});
        score.Add(6000 + 50 + 1, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(6000 + 50 + 2, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(6000 + 60 + 1, new int[] {0, 0, 10, 5, 0, 0, 0, 0});
        score.Add(6000 + 60 + 2, new int[] {0, 0, 5, 10, 0, 0, 0, 0});
        score.Add(6000 + 70 + 1, new int[] {0, 0, 0, 0, 10, 0, 0, 0});
        score.Add(6000 + 70 + 2, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(6000 + 80 + 1, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(6000 + 80 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(6000 + 90 + 1, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(6000 + 90 + 2, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(6000 + 100 + 1, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(6000 + 100 + 2, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(6000 + 110 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(6000 + 110 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(6000 + 120 + 1, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(6000 + 120 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 10});

        score.Add(7000 + 10 + 1, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(7000 + 10 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(7000 + 20 + 1, new int[] {0, 0, 5, 0, 0, 0, 0, 0});
        score.Add(7000 + 20 + 2, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(7000 + 30 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(7000 + 30 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(7000 + 40 + 1, new int[] {0, 0, 0, 0, 0, 0, 5, 0});
        score.Add(7000 + 40 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(7000 + 40 + 3, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(7000 + 50 + 1, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(7000 + 50 + 2, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(7000 + 60 + 1, new int[] {0, 0, 0, 5, 0, 0, 0, 0});
        score.Add(7000 + 60 + 2, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(7000 + 70 + 1, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(7000 + 70 + 2, new int[] {0, 0, 0, 0, 10, 0, 0, 0});
        score.Add(7000 + 80 + 1, new int[] {0, 0, 0, 0, 5, 0, 10, 0});
        score.Add(7000 + 80 + 2, new int[] {0, 5, 0, 0, 0, 0, 0, 5});
        score.Add(7000 + 80 + 3, new int[] {5, 0, 0, 0, 0, 0, 10, 0});
        score.Add(7000 + 90 + 1, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(7000 + 90 + 2, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(7000 + 100 + 1, new int[] {0, 0, 5, 0, 0, 0, 0, 0});
        score.Add(7000 + 100 + 2, new int[] {0, 0, 0, 5, 0, 0, 0, 0});
        score.Add(7000 + 110 + 1, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(7000 + 110 + 2, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(7000 + 120 + 1, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(7000 + 120 + 2, new int[] {0, 0, 0, 0, 0, 0, 5, 0});
        score.Add(7000 + 120 + 3, new int[] {0, 0, 0, 0, 0, 0, 5, 0});

        score.Add(8000 + 10 + 1, new int[] {5, 0, 0, 0, 0, 0, 0, 0});
        score.Add(8000 + 10 + 2, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(8000 + 20 + 1, new int[] {0, 0, 5, 10, 0, 0, 0, 0});
        score.Add(8000 + 20 + 2, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(8000 + 30 + 1, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(8000 + 30 + 2, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(8000 + 40 + 1, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(8000 + 40 + 2, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(8000 + 50 + 1, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(8000 + 50 + 2, new int[] {0, 5, 0, 0, 0, 0, 0, 0});
        score.Add(8000 + 60 + 1, new int[] {0, 0, 5, 5, 0, 0, 0, 0});
        score.Add(8000 + 60 + 2, new int[] {0, 0, 5, 5, 0, 0, 0, 0});
        score.Add(8000 + 70 + 1, new int[] {0, 0, 0, 0, 0, 5, 0, 0});
        score.Add(8000 + 70 + 2, new int[] {0, 0, 0, 0, 5, 0, 0, 0});
        score.Add(8000 + 80 + 1, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
        score.Add(8000 + 80 + 2, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(8000 + 80 + 3, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(8000 + 90 + 1, new int[] {10, 0, 0, 0, 0, 0, 0, 0});
        score.Add(8000 + 90 + 2, new int[] {0, 10, 0, 0, 0, 0, 0, 0});
        score.Add(8000 + 100 + 1, new int[] {0, 0, 10, 0, 0, 0, 0, 0});
        score.Add(8000 + 100 + 2, new int[] {0, 0, 0, 10, 0, 0, 0, 0});
        score.Add(8000 + 110 + 1, new int[] {0, 0, 0, 0, 10, 0, 0, 0});
        score.Add(8000 + 110 + 2, new int[] {0, 0, 0, 0, 0, 10, 0, 0});
        score.Add(8000 + 120 + 1, new int[] {0, 0, 0, 0, 0, 0, 10, 0});
        score.Add(8000 + 120 + 2, new int[] {0, 0, 0, 0, 0, 0, 0, 10});
    }
}
