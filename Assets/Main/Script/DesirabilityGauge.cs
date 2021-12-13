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

	public static int index0 = 3;
	private int index1 = 0;
	private int index2 = 0;

	public static int score = 0;
	private int nowvalue = 0;

	void Start()
    {
		for (int i = 0; i < NextLevel.Length; i++)
		{
			NextLevel[i].SetActive(false);
		}
		
		if (index0 == 3)
        {
			index0 = Random.Range(0, 3);
		}
		NextLevel[index0].SetActive(true);

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


		Function();
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
		/*else if (nowvalue >= 5)
        {
			Ending();
		}*/
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
	private void Ending()
	{
		Endingbtn.SetActive(true);
	}
}
