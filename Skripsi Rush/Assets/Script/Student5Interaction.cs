using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Student5Interaction : MonoBehaviour {

	public PlayerStat playerStat;
	float currentHappiness;
	int flag, flag2;
	public Text ActionInfoTextUI;

	void Start()
	{
		playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();

	}

	void OnTriggerEnter2D(Collider2D col){
		flag = 1;
		if (flag2 == 1) {
			ActionInfoTextUI.text = "The question has been answered";
		}

	}

	void OnTriggerExit2D(Collider2D col){
		flag = 0;
		ActionInfoTextUI.text = "";
	}

	void Update () {
		currentHappiness = playerStat.getHappiness();
		if (flag == 1 && flag2 != 1) {
			if (Input.GetKeyDown (KeyCode.A)) {
				currentHappiness += 10f;
				playerStat.setHappiness (currentHappiness);
				flag2 = 1;
			}
			if (Input.GetKeyDown (KeyCode.B)) {
				currentHappiness += 12.5f;
				playerStat.setHappiness (currentHappiness);
				flag2 = 1;
			}
			if (Input.GetKeyDown (KeyCode.C)) {
				currentHappiness += 17.5f;
				playerStat.setHappiness (currentHappiness);
				flag2 = 1;
			}
			if (Input.GetKeyDown (KeyCode.D)) {
				currentHappiness += 20f;
				playerStat.setHappiness (currentHappiness);
				flag2 = 1;
			}
		}
	}
}
