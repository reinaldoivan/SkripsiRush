using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	Camera playerCam;

	void Start () {
		playerCam = GetComponent<Camera> ();
	}

	void Update () {
	
		playerCam.orthographicSize = (Screen.height/100f)/3.2f;

		if (target) {
			transform.position = Vector3.Lerp (transform.position, target.position, 0.1f)+new Vector3(0,0,-10);
		}
	}
}
