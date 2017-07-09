using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HappinessIndicator : MonoBehaviour {

	public PlayerStat playerStat;
	private Slider sliderObject;

	void Start()
	{
		playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();
		sliderObject = GetComponent<Slider>();
		sliderObject.maxValue = playerStat.getHappiness();
	}

	void Update()
	{
		sliderObject.value = playerStat.getHappiness();
	}
}
