using UnityEngine;
using System.Collections;

public class NumberRecGameController : MonoBehaviour {
	public int score;
	public GUIText scoreText;
	public int currentNumber; //current number that the player was prompted to select
	public AudioClip[] voicePrompts ;

	// Use this for initialization
	void Start () {
		score = 0;
		updateScore ();
		currentNumber = -2; //no prompt yet; -1 means in delay

	}
	
	// Update is called once per frame
	void Update () {
		if(currentNumber == -2)	StartCoroutine(DelayBetweenPrompts());
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

	public IEnumerator DelayBetweenPrompts()
	{
		currentNumber = -1; //flag for delay waiting
		yield return new WaitForSeconds (2);
		currentNumber = Random.Range (0,10);//select a random number between 0 and 9 inclusive
		audio.clip = voicePrompts [currentNumber];//use voiceprompt for current number
		audio.Play ();//speak the current number
	}

	public int getCurrentNumber()
	{
		return currentNumber;
		}
}
