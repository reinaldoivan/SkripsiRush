using UnityEngine;
using System.Collections;
using System.IO;

public class LastLevelController : MonoBehaviour {

	string levelName;
	int lastLevel;

	void Start(){
		lastLevel = PlayerPrefs.GetInt ("_lastLevel");

		if (lastLevel == 1) {
			levelName = "part1";
		} else if (lastLevel == 2) {
			levelName = "part2";
		} else if (lastLevel == 3) {
			levelName = "part3";
		}
	}

	public void ContinueGame(){
		Application.LoadLevel (levelName);
	}
}
