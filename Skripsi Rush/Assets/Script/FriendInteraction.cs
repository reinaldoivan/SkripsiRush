using UnityEngine;
using System.Collections;

public class FriendInteraction : MonoBehaviour {

	public PlayerStat playerStat;
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
		currentHappiness = playerStat.getHappiness();
		if (flag == 1) {
			if (Input.GetKeyDown (KeyCode.Z)) {
				currentHappiness += 0.5f; 
				playerStat.setHappiness (currentHappiness);
			}
		}
	}
}
