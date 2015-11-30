using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

	
	public static int score = 0;
	private Text myText;
	void Start() {
		myText = GetComponent<Text>();
		reset();
	}
	
	public void Score(int points) {
	Debug.Log("Scored pints");
		score += points;
		myText.text = "Score: " + score.ToString();
	}
	
	public static void reset() {
		score = 0;
	}
}
