using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesirabilityGauge : MonoBehaviour
{
	public Text message;
	public Slider slider;
	public GameObject[] NextLevel = new GameObject[7];
	public GameObject Endingbtn;
	public GameObject[] EndingCharac = new GameObject[12];
	public Text endingtext;
	public MBTIGauage mbtiGauage;

	public int index0 = 3;
	public int index1 = 0;
	public int index2 = 0;
	string a = "E";
	string b = "E";
	string c = "E";
	string d = "E";

	public static int score = 0;
	private int nowvalue = 0;

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

		if (nowvalue < 30)
		{
			NextLevel[index0].SetActive(true);
		}
		else if (nowvalue >= 30 && nowvalue < 70)
		{
			NextLevel[index1].SetActive(true);
		}
		else if (nowvalue >= 70 && nowvalue < 100)
		{
			NextLevel[index2].SetActive(true);
		}

		Function();
	}

	public void ChooseCharac()
    {
		// 캐릭터 선택
		index0 = Random.Range(0, 3);
		if (index0 == 0)
		{
			index1 = Random.Range(3, 5);

			if (index1 == 3)
			{
				index2 = Random.Range(9, 11);
			}
			else if (index1 == 4)
			{
				index2 = Random.Range(11, 13);
			}
		}
		else if (index0 == 1)
		{
			index1 = Random.Range(5, 7);
			if (index1 == 5)
			{
				index2 = Random.Range(13, 15);
			}
			else if (index1 == 6)
			{
				index2 = Random.Range(15, 17);
			}
		}
		else if (index0 == 2)
		{
			index1 = Random.Range(7, 9);
			if (index1 == 7)
			{
				index2 = Random.Range(17, 19);
			}
			else if (index1 == 8)
			{
				index2 = Random.Range(19, 21);
			}
		}
	}

	private void Function()
	{
		nowvalue += score;
		slider.value = nowvalue;
		message.text = nowvalue.ToString();  // show now score

		if (nowvalue >= 30 && nowvalue < 70)
        {
			Debug.Log("1 Level up");
			RandomObj1();
		}
		else if (nowvalue >= 70 && nowvalue < 100)
		{
			Debug.Log("2 Level up");
			RandomObj2();
		}
		else if (nowvalue >= 100)
		{
			Debug.Log("Ending");
			Ending();
		}
		else if (nowvalue >= 20)
		{
			Debug.Log("Ending");
			Ending();
		}
	}

	public void OnClickInterac5()
	{
		score = 5;
		Function();
	}
	public void OnClickInterac10()
	{
		score = 10;
		Function();
	}
	public void OnClickInterac15()
	{
		score = 15;
		Function();
	}

	private void RandomObj1()
	{
		NextLevel[index0].SetActive(false);
		NextLevel[index1].SetActive(true);
	}
	private void RandomObj2()
	{
		NextLevel[index1].SetActive(false);
		NextLevel[index2].SetActive(true);
	}
	public void Ending()
	{
		Endingbtn.SetActive(true);
	}

	public void EndingShow()
    {
		// 펫의 최종모습이 무엇인지
		if (index2 == 9)
        {
			EndingCharac[0].SetActive(true);
		}
		else if (index2 == 10)
		{
			EndingCharac[1].SetActive(true);
		}
		else if (index2 == 11)
		{
			EndingCharac[2].SetActive(true);
		}
		else if (index2 == 12)
		{
			EndingCharac[3].SetActive(true);
		}
		else if (index2 == 13)
		{
			EndingCharac[4].SetActive(true);
		}
		else if (index2 == 14)
		{
			EndingCharac[5].SetActive(true);
		}
		else if (index2 == 15)
		{
			EndingCharac[6].SetActive(true);
		}
		else if (index2 == 16)
		{
			EndingCharac[7].SetActive(true);
		}
		else if (index2 == 17)
		{
			EndingCharac[8].SetActive(true);
		}
		else if (index2 == 18)
		{
			EndingCharac[9].SetActive(true);
		}
		else if (index2 == 19)
		{
			EndingCharac[10].SetActive(true);
		}
		else if (index2 == 20)
		{
			EndingCharac[11].SetActive(true);
		}

		// 펫의 mbti가 뭔지
		if (mbtiGauage.Mbti[0] > mbtiGauage.Mbti[1])
        {
			a = "E";
		}
		else
        {
			a = "I";
		}
		if (mbtiGauage.Mbti[2] > mbtiGauage.Mbti[3])
        {
			b = "S";
		}
		else
        {
			b = "N";
		}
		if (mbtiGauage.Mbti[4] > mbtiGauage.Mbti[5])
        {
			c = "T";
		}
		else
        {
			c = "F";
		}
		if (mbtiGauage.Mbti[6] > mbtiGauage.Mbti[7])
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
}
