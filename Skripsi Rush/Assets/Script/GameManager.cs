using UnityEngine;
using System.Collections;
using System.IO;

public class GameManager : MonoBehaviour {

	public PlayerStat playerStat;
    public GameObject player;

	public void SaveStat () {
		if (playerStat == null)
			return;

		// setter harus sesuai dengan tipedata dan ingat key valuenya! 
		float currentEnergy = playerStat.getEnergy();
		float currentTime = playerStat.getTime();
        float currentX = player.transform.position.x;
        float currentY = player.transform.position.y;
        float currentZ = player.transform.position.z;
        PlayerPrefs.SetFloat ("_energy", currentEnergy);
		PlayerPrefs.SetFloat ("_timeLeft", currentTime);
        PlayerPrefs.SetFloat("_posX", currentX);
        PlayerPrefs.SetFloat("_posY", currentY);
        PlayerPrefs.SetFloat("_posY", currentZ);

        // SAVE(); you might want to write the PlayerPrefs at sensible 'checkpoints' in your game. 
        // This function will write to disk potentially causing a small hiccup, 
        // therefore it is not recommended to call during actual gameplay.
        PlayerPrefs.Save ();
	}

	public void LoadStat() {
		if (playerStat == null)
			return;

		// apakah sudah perna disimpan sebelumnya? sehingga punya key _hp?
		if (PlayerPrefs.HasKey ("_energy") == false)
			return;

		// getter harus sesuai dengan tipe data dan key value
		playerStat.setEnergy(PlayerPrefs.GetFloat ("_energy"));
		playerStat.setTime(PlayerPrefs.GetFloat ("_timeLeft"));

        playerStat.x = PlayerPrefs.GetFloat("_posX");
        playerStat.y = PlayerPrefs.GetFloat("_posY");
        playerStat.z = PlayerPrefs.GetFloat("_posZ");
        Vector3 posVec = new Vector3(playerStat.x, playerStat.y, playerStat.z);
        player.transform.position = posVec;


        //pengecekan load
        float energy = PlayerPrefs.GetFloat("_energy");
        print(energy);
    }

}
