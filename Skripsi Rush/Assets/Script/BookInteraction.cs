using UnityEngine;
using System.Collections;

public class BookInteraction : MonoBehaviour {

	public PlayerStat playerStat;
	float currentProgress;
	float currentEnergy;
	float currentHappiness;
	int flag;

	void Start()
	{
		playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();
	}

	void OnTriggerEnter2D(Collider2D col){
		flag = 1;
	}

	void OnTriggerExit2D(Collider2D col){
		flag = 0;
	}

	void Update () {
		currentEnergy = playerStat.getEnergy();
		currentHappiness = playerStat.getHappiness();
		currentProgress = playerStat.getProgress();
		if (flag == 1) {
			if (Input.GetKeyDown (KeyCode.Z)) {
				currentProgress += 0.5f;
				currentEnergy -= 0.5f;
				currentHappiness -= 1f;
				playerStat.setEnergy (currentEnergy);
				playerStat.setHappiness (currentHappiness);
				playerStat.setProgress (currentProgress);
			}
		}
	}
}
