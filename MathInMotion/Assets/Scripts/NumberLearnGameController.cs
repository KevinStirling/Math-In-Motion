using UnityEngine;
using System.Collections;

public class NumberLearnGameController : MonoBehaviour {
	public int score;
	public GUIText scoreText;
	public AudioClip voicePrompts ;

	// Use this for initialization
	void Start () {
		score = 0;
		updateScore ();
		audio.clip = voicePrompts;
		audio.Play();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addScore(int newScoreValue)
	{
		score += newScoreValue;
		updateScore ();
	}

	void updateScore()
	{
		scoreText.text = "Score: " + score;
	}
}
