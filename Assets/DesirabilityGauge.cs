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
	private int index11 = 0;
	private int index12 = 0;

	public static int score = 0; // �þ�� ��
	private int nowvalue = 0; // ���� ������ ��ġ

	void Start()
    {
		for (int i = 0; i < NextLevel.Length; i++)
		{
			NextLevel[i].SetActive(false);
		}
		index0 = Random.Range(0, 3);
		NextLevel[index0].SetActive(true);

		Function();

		index1 = Random.Range(1, 3);
		index11 = Random.Range(3, 5);
		index12 = Random.Range(5, 7);
	}
 
	private void Function()
	{
		nowvalue += score;
		// �����̴� �����̱�
		slider.value = nowvalue;
		// �� ����ϱ�
		Debug.Log("���� ������:" + nowvalue);
		message.text = nowvalue.ToString();  // �����̴� �� ���

		if (nowvalue >= 30 && nowvalue < 70)
        {
			Debug.Log("1�ܰ�� ����");
			RandomObj1();
		}
		else if (nowvalue >= 70 && nowvalue < 100)
		{
			Debug.Log("2�ܰ�� ����");
			if (index1 == 1)
			{
				RandomObj11();
			}
			else if (index1 == 2)
			{
				RandomObj12();
			}
		}
		else if (nowvalue >= 100)
		{
			Debug.Log("����");
		}
	}

	public void OnClickInterac5()
	{
		score = 5;  // ���ͷ��� ���� Ŭ���ϸ� 5�� ���ϱ�
		Debug.Log("5��ŭ �������� �����.");
		Function();
	}
	public void OnClickInterac10()
	{
		score = 10;  // ���ͷ��� ���� Ŭ���ϸ� 10�� ���ϱ�
		Debug.Log("10��ŭ �������� �����.");
		Function();
	}
	public void OnClickInterac15()
	{
		score = 15;  // ���ͷ��� ���� Ŭ���ϸ� 15�� ���ϱ�
		Debug.Log("15��ŭ �������� �����.");
		Function();
	}

	private void RandomObj1()
	{
		NextLevel[index0].SetActive(false);
		NextLevel[index1].SetActive(true);
	}
	private void RandomObj11()
	{
		NextLevel[index1].SetActive(false);
		NextLevel[index11].SetActive(true);
	}
	private void RandomObj12()
	{
		NextLevel[index1].SetActive(false);
		NextLevel[index12].SetActive(true);
	}
}
