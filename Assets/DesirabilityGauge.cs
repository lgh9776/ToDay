using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesirabilityGauge : MonoBehaviour
{
	public Text message;
	public Slider slider;

	public static int des;
	private int nowvalue = 0;

	void Start()
    {
		Function();
	}
	private void Function()
	{
		// 점수 받기
		// 점수 더하기
		nowvalue += des;
		// 슬라이더 움직이기
		slider.value = nowvalue;
		// 값 출력하기
		Debug.Log("현재 애정도:" + nowvalue);
		message.text = nowvalue.ToString();  // 슬라이더 값 출력

		if (nowvalue >= 30)
        {
			if (nowvalue >= 70)
            {
				if (nowvalue >= 100)
                {

                }
			}

		}
	}

	public void OnClickInterac5()
	{
		des += 5;  // 인터렉션 폴더 클릭하면 5점 더하기
		Debug.Log("5만큼 애정도를 얻었다.");
		Function();
	}
	public void OnClickInterac10()
	{
		des += 10;  // 인터렉션 폴더 클릭하면 10점 더하기
		Debug.Log("10만큼 애정도를 얻었다.");
		Function();
	}
	public void OnClickInterac15()
	{
		des += 15;  // 인터렉션 폴더 클릭하면 15점 더하기
		Debug.Log("15만큼 애정도를 얻었다.");
		Function();
	}
}
