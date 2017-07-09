using UnityEngine;
using System.Collections;

public class KitchenInteraction : MonoBehaviour {

	public PlayerStat playerStat;
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
		if (flag == 1) {
			if (Input.GetKeyDown (KeyCode.Z)) {
				currentEnergy += 0.5f;
				currentHappiness += 0.5f; 
				playerStat.setEnergy (currentEnergy);
				playerStat.setHappiness (currentHappiness);
			}
		}
	}
}
