using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public string levelName;
	public PlayerStat playerStat;
	float currentProgress;

	void Start()
	{
		playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();
	}

	void Update () {
		currentProgress = playerStat.getProgress();
	}

	void OnTriggerEnter2D(Collider2D col){
		if (currentProgress == 100f) {
			Application.LoadLevel (levelName);
		}
	}
}
