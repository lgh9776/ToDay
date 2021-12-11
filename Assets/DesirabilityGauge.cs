using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesirabilityGauge : MonoBehaviour
{
	public Text message;
	public Slider slider;
	public GameObject[] NextLevel = new GameObject[7];
	// NextLevel = GameObject.FindGameObjectsWithTag("Character");

	private int index0 = 0;
	private int index1 = 0;
	private int index2 = 0;

	public static int score = 0; // 늘어나는 양
	private int nowvalue = 0; // 현재 애정도 수치

	void Start()
    {
		for (int i = 0; i < NextLevel.Length; i++)
		{
			NextLevel[i].SetActive(false);
		}
		index0 = Random.Range(0, 3);
		NextLevel[index0].SetActive(true);

		Function();

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
		// 슬라이더 움직이기
		slider.value = nowvalue;
		// 값 출력하기
		Debug.Log("현재 애정도:" + nowvalue);
		message.text = nowvalue.ToString();  // 슬라이더 값 출력

		if (nowvalue >= 30 && nowvalue < 70)
        {
			Debug.Log("1단계로 성장");
			RandomObj1();
		}
		else if (nowvalue >= 70 && nowvalue < 100)
		{
			Debug.Log("2단계로 성장");
			RandomObj2();
		}
		else if (nowvalue >= 100)
		{
			Debug.Log("엔딩");
		}
	}

	public void OnClickInterac5()
	{
		score = 5;  // 인터렉션 폴더 클릭하면 5점 더하기
		Debug.Log("5만큼 애정도를 얻었다.");
		Function();
	}
	public void OnClickInterac10()
	{
		score = 10;  // 인터렉션 폴더 클릭하면 10점 더하기
		Debug.Log("10만큼 애정도를 얻었다.");
		Function();
	}
	public void OnClickInterac15()
	{
		score = 15;  // 인터렉션 폴더 클릭하면 15점 더하기
		Debug.Log("15만큼 애정도를 얻었다.");
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
}
