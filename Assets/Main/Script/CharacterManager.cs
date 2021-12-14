using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
	public int index0 = 0;
	public int index1 = 0;
	public int index2 = 0;

	private int index = 0; // 0
	private int indexc; // 1
	private int indexs;
	private int indext;
	private int indexc3; // 2
	private int indexc4;
	private int indexs5;
	private int indexs6;
	private int indext7;
	private int indext8;

	//public DesirabilityGauge desirabilitygauge;
	
	public void Awake()
    {
		//Debug.Log(index1);
		index = Random.Range(0, 3); // 0
		indexc = Random.Range(3, 5); // 1
		indexs = Random.Range(5, 7);
		indext = Random.Range(7, 9);
		indexc3 = Random.Range(9, 11); // 2
		indexc4 = Random.Range(11, 13);
		indexs5 = Random.Range(13, 15);
		indexs6 = Random.Range(15, 17);
		indext7 = Random.Range(17, 19);
		indext8 = Random.Range(19, 21);
	
	}
	
	public void Start()
	{
		/*
		index = Random.Range(0, 3); // 0
		indexc = Random.Range(3, 5); // 1
		indexs = Random.Range(5, 7);
		indext = Random.Range(7, 9);
		indexc3 = Random.Range(9, 11); // 2
		indexc4 = Random.Range(11, 13);
		indexs5 = Random.Range(13, 15);
		indexs6 = Random.Range(15, 17);
		indext7 = Random.Range(17, 19);
		indext8 = Random.Range(19, 21);
		*/

		if (index == 0)
		{
			index0 = 0;

			if (indexc == 3)
			{
				index1 = 3;
				if (indexc3 == 9)
                {
					index2 = 9;
                }
				else if (indexc3 == 10)
                {
					index2 = 10;
				}
			}
			else if (indexc == 4)
			{
				index1 = 4;
				if (indexc4 == 11)
				{
					index2 = 11;
				}
				else if (indexc4 == 12)
				{
					index2 = 12;
				}
			}
		}
		else if (index == 1)
		{
			index0 = 1;

			if (indexs == 5)
			{
				index1 = 5;
				if (indexs5 == 13)
				{
					index2 = 13;
				}
				else if (indexs5 == 14)
				{
					index2 = 14;
				}
			}
			else if (indexs == 6)
			{
				index1 = 6;
				if (indexs6 == 15)
				{
					index2 = 15;
				}
				else if (indexs6 == 16)
				{
					index2 = 16;
				}
			}
		}
		else if (index == 2)
		{
			index0 = 2;

			if (indext == 7)
			{
				index1 = 7;
				if (indext7 == 17)
				{
					index2 = 17;
				}
				else if (indext7 == 18)
				{
					index2 = 18;
				}
			}
			else if (indext == 8)
			{
				index1 = 8;
				if (indext8 == 19)
				{
					index2 = 19;
				}
				else if (indext8 == 20)
				{
					index2 = 20;
				}
			}
		}

		Debug.Log("index0 : " + index0 + "   index1 : " + index1 + "   index2 : " + index2);
		//desirabilitygauge.ShowCharacter();
		//desirabilitygauge.AfterLevelUp();
		//gameObject.SetActive(false);
	}

	public void AfterEnding()
	{
		Awake();
		Start();
	}
}
