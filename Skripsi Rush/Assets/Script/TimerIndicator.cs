using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerIndicator : MonoBehaviour {
    
    public PlayerStat playerStat;
    private Text textObject;

    void Start()
    {
        playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent <PlayerStat>();
        textObject = GetComponent<Text>();
    }

    void Update()
    {
        textObject.text = "Time left : " + Mathf.Floor(playerStat.getTime());
    }
}
