using UnityEngine;
using System.Collections;
using System.IO;

public class GameOver : MonoBehaviour {

	public PlayerStat playerStat;
	float currentEnergy;
	float currentHappiness;
	float currentTime;
	int currentLevel;

	void Start () {
		playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();
	}

	void Update () {
		currentEnergy = playerStat.getEnergy();
		currentHappiness = playerStat.getHappiness();
		currentTime = playerStat.getTime();
		currentLevel = playerStat.getLevel ();

		if (currentEnergy <= 0 || currentHappiness <= 0 || currentTime <= 0) {
			Application.LoadLevel ("retry");
			PlayerPrefs.SetInt ("_lastLevel", currentLevel);
		}
	}
}
