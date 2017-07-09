using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectibeInfo : MonoBehaviour {
	public bool showGUI = false;
	public Texture2D txt;

	void OnTriggerEnter2D(Collider2D col){
		showGUI = true;
	}

	void OnTriggerExit2D(Collider2D col){
		showGUI = false;
	}

	void OnGUI(){
		if(showGUI){
			GUI.DrawTexture (new Rect(210, 785, 690, 100), txt);
		}
	}


}
