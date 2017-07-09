using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnergyIndicator : MonoBehaviour {
    
    public PlayerStat playerStat;
    private Slider sliderObject;

    void Start()
    {
        playerStat = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();
        sliderObject = GetComponent<Slider>();
        sliderObject.maxValue = playerStat.getEnergy();
    }

    void Update()
    {
        sliderObject.value = playerStat.getEnergy();
    }
}
