﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text myText = GetComponent<Text>();
		myText.text = "Score: " + ScoreKeeper.score.ToString();
		ScoreKeeper.reset();
	}
}
