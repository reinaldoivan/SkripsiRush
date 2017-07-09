using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour {

	public Text success;
    public AudioSource audio;

	[SerializeField]
	private float _energy = 100f;
	[SerializeField]
	private float _happiness = 100f;
	[SerializeField]
	private float _progress = 0f;
	[SerializeField]
	private float _timeLeft = 130f;
	[SerializeField]
	private int _level = 1;
    public float x, y, z;

	public float maxEnergy = 100f;
	public float maxHappiness = 100f;
	public float maxProgress = 100f;
	public float maxTime = 60f;

	public float getEnergy() {
		return _energy;
	}

	public float getHappiness() {
		return _happiness;
	}

	public float getProgress() {
		return _progress;
	}
	public float getTime() {
		return _timeLeft;
	}
	public int getLevel() {
		return _level;
	}

	public void setEnergy(float value) {
		_energy = value;

		if (_energy > maxEnergy)
			_energy = maxEnergy;
	}

	public void setHappiness(float value) {
		_happiness = value;

		if (_happiness > maxHappiness)
			_happiness = maxHappiness;
	}

	public void setProgress(float value) {
		_progress = value;

		if (_progress > maxProgress)
			_progress = maxProgress;
	}

	public void setTime( float value ) {
		_timeLeft = value;

		if (_timeLeft > maxTime)
			_timeLeft = maxTime;
	}

    void Update()
    {
		if (_progress < 100) {
			if (_timeLeft > 0) {
				_timeLeft -= Time.deltaTime * 1f;

				if (_timeLeft <= 0) {
					_timeLeft = 0f;
				}
			}

			if (_energy > 0) {
				_energy -= Time.deltaTime * 0.5f;

				if (_energy <= 0) {
					_energy = 0f;
				}
			}

			if (_happiness > 0) {
				_happiness -= Time.deltaTime * 0.25f;

				if (_happiness <= 0) {
					_happiness = 0f;
				}
			}

            if (_progress >= 100)
            {
                _progress = 100f;
            }
		}
        else {
            success.text = "You have completed your progress ! Proceed to main door to continue";
            audio.Play();
        }
    }

}
