using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {

	public string levelName;

	public void StartGame(){
		Application.LoadLevel (levelName);

	}
}
