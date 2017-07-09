using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressIndicator : MonoBehaviour {

	public PlayerStat playerStat;
	private Slider sliderObject;

	void Start()
	{
		playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();
		sliderObject = GetComponent<Slider>();
		sliderObject.maxValue = 100f ;
	}

	void Update()
	{
		sliderObject.value = playerStat.getProgress();
	}
}
