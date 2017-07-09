using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BedInteraction : MonoBehaviour {

	public PlayerStat playerStat;
	float currentEnergy;
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
		if (flag == 1) {
			if (Input.GetKeyDown (KeyCode.Z)) {
				currentEnergy += 1f;
				playerStat.setEnergy (currentEnergy);

			}
		}
	}
}
