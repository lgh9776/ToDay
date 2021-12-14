using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesirabilityGauge : MonoBehaviour
{
	public Text message;
	public Slider slider;
	public GameObject[] NextLevel = new GameObject[21];
	public GameObject Endingbtn;
	public GameObject[] EndingCharac = new GameObject[12];
	public MBTIGauage mbtiGauage;
	public CharacterManager charactermanager;

	public static int score = 0;
	private static int nowvalue = 0;

	// 배열 오브젝트들 전부 안보이게
	void Start()
    {
		for (int i = 0; i < NextLevel.Length; i++)
		{
			NextLevel[i].SetActive(false);
		}
		for (int i = 0; i < EndingCharac.Length; i++)
		{
			EndingCharac[i].SetActive(false);
		}

		AfterLevelUp();
		// Debug.Log("score : " + score + "  nowvalue : " + nowvalue);
		slider.value = nowvalue;
		message.text = nowvalue.ToString();
	}

	public void AfterLevelUp()
	{
		if (nowvalue < 30)
		{
			Debug.Log("Level 0");
			NextLevel[charactermanager.index0].SetActive(true);
		}
		else if (nowvalue >= 30 && nowvalue < 70)
        {
			Debug.Log("Level 1");
			NextLevel[charactermanager.index0].SetActive(false);
			NextLevel[charactermanager.index1].SetActive(true);
		}
		else if (nowvalue >= 70 && nowvalue < 100)
		{
			Debug.Log("Level 2");
			NextLevel[charactermanager.index1].SetActive(false);
			NextLevel[charactermanager.index2].SetActive(true);
		}
		else if (nowvalue >= 100)
		{
			Debug.Log("Ending");
			Endingbtn.SetActive(true);
		}
		// Debug.Log("score : " + score + "  nowvalue : " + nowvalue);
	}

	public void OnClickInterac5()
	{
		score = 5;
		nowvalue += score;
		slider.value = nowvalue;
		message.text = nowvalue.ToString();  // show now score
		AfterLevelUp();
	}
	public void OnClickInterac10()
	{
		score = 10;
		nowvalue += score;
		slider.value = nowvalue;
		message.text = nowvalue.ToString();  // show now score
		AfterLevelUp();
	}
	public void OnClickInterac15()
	{
		score = 15;
		nowvalue += score;
		slider.value = nowvalue;
		message.text = nowvalue.ToString();  // show now score
		AfterLevelUp();
	}

	public void EndingShow()
    {
		// 펫의 최종모습이 무엇인지
		if (charactermanager.index2 == 9)
        {
			EndingCharac[0].SetActive(true);
		}
		else if (charactermanager.index2 == 10)
		{
			EndingCharac[1].SetActive(true);
		}
		else if (charactermanager.index2 == 11)
		{
			EndingCharac[2].SetActive(true);
		}
		else if (charactermanager.index2 == 12)
		{
			EndingCharac[3].SetActive(true);
		}
		else if (charactermanager.index2 == 13)
		{
			EndingCharac[4].SetActive(true);
		}
		else if (charactermanager.index2 == 14)
		{
			EndingCharac[5].SetActive(true);
		}
		else if (charactermanager.index2 == 15)
		{
			EndingCharac[6].SetActive(true);
		}
		else if (charactermanager.index2 == 16)
		{
			EndingCharac[7].SetActive(true);
		}
		else if (charactermanager.index2 == 17)
		{
			EndingCharac[8].SetActive(true);
		}
		else if (charactermanager.index2 == 18)
		{
			EndingCharac[9].SetActive(true);
		}
		else if (charactermanager.index2 == 19)
		{
			EndingCharac[10].SetActive(true);
		}
		else if (charactermanager.index2 == 20)
		{
			EndingCharac[11].SetActive(true);
		}
	}

	public void AfterEnding()
    {
		score = 0;
		nowvalue = 0;
}
}
