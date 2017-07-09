using UnityEngine;
using System.Collections;

public class WinSound : MonoBehaviour {
    public PlayerStat playerStat;
    AudioSource audio;
    float currentProgress;

    void Start () {
        playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();
        audio = GetComponent<AudioSource>();
    }

	void Update () {
        
            audio.Play();
    }
}
