using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Student3Interaction : MonoBehaviour {
	public PlayerStat playerStat;
	float currentProgress;
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
		currentProgress = playerStat.getProgress();
		if (flag == 1 && flag2 != 1) {
			if (Input.GetKeyDown (KeyCode.A)) {
				ActionInfoTextUI.text = "Wrong";
			}
			if (Input.GetKeyDown (KeyCode.B)) {
				ActionInfoTextUI.text = "Wrong";
			}
			if (Input.GetKeyDown (KeyCode.C)) {
				currentProgress += 10f;
				playerStat.setProgress (currentProgress);
				ActionInfoTextUI.text = "Your answer is correct !";
				flag2 = 1;
			}
			if (Input.GetKeyDown (KeyCode.D)) {
				ActionInfoTextUI.text = "Wrong";
			}
		}
	}
}
