using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesirabilityGauge : MonoBehaviour
{
	public Text message;
	public Slider slider;

	public Sprite[] nextlevel;
	public Image image;

	public static int des;
	private int nowvalue = 0;

	void Start()
    {
		Function();
	}

	private void Funciton_RandomImage()
	{
		int index = Random.Range(0, nextlevel.Length);
		Sprite select = nextlevel[index];
		image.sprite = select;
	}

	private void Function()
	{
		// ���� �ޱ�
		// ���� ���ϱ�
		nowvalue += des;
		// �����̴� �����̱�
		slider.value = nowvalue;
		// �� ����ϱ�
		Debug.Log("���� ������:" + nowvalue);
		message.text = nowvalue.ToString();  // �����̴� �� ���

		if (nowvalue >= 30 && nowvalue < 70)
        {
			Debug.Log("1�ܰ�� ����");
			Funciton_RandomImage();
			// �ش�ĳ����.SetActive(true)
			// ����ĳ����.SetActive(false)
		}
		else if (nowvalue >= 70 && nowvalue < 100)
		{
			Debug.Log("2�ܰ�� ����");
		}
		else if (nowvalue >= 100)
		{
			Debug.Log("����");
		}
	}

	public void OnClickInterac5()
	{
		des += 5;  // ���ͷ��� ���� Ŭ���ϸ� 5�� ���ϱ�
		Debug.Log("5��ŭ �������� �����.");
		Function();
	}
	public void OnClickInterac10()
	{
		des += 10;  // ���ͷ��� ���� Ŭ���ϸ� 10�� ���ϱ�
		Debug.Log("10��ŭ �������� �����.");
		Function();
	}
	public void OnClickInterac15()
	{
		des += 15;  // ���ͷ��� ���� Ŭ���ϸ� 15�� ���ϱ�
		Debug.Log("15��ŭ �������� �����.");
		Function();
	}
}
