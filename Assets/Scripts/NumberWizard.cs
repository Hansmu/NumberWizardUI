using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	private int max;
	private int min;
	private int guess;

	public int maxGuessesAllowed = 5;
	public Text guessText;

	void Start () {
		StartGame();
    }

	void StartGame() {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max+1);
	}

	public void GuessHigher() {
		min = guess;
		NextGuess();
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}

	void NextGuess() {
		guess = Random.Range(min, max+1);
		guessText.text = guess.ToString();
		maxGuessesAllowed--;

		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
