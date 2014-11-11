using UnityEngine;
using System.Collections;

public class NumberRecNumberController : MonoBehaviour {
	public Sprite Num_Over;
	public Sprite Num_Normal;
	public Sprite Num_Clicked;

	private SpriteRenderer spriteRenderer;
	//private Vector3 currrentPos;
	private Vector3 finalPos;

	public NumberRecGameController NR_Game_Controller;

	//set in inspector - not by script!
	public int myNumber;//zero indexed value of the number displayed - i.e. the 10 graphic will have a value of 9
	public AudioClip[] sounds ;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = Num_Normal;
		Vector3 currentPos = new Vector3 (20,20);
		Vector3 finalPos = new Vector3 (Random.Range (-10.0F, 10.0F), Random.Range (-4.0F, 4.0F));
		transform.position = finalPos;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() { 
		spriteRenderer.sprite = Num_Over;

	}
	void OnMouseExit() { 
		spriteRenderer.sprite = Num_Normal;
	}

	void OnMouseDown(){
		spriteRenderer.sprite = Num_Clicked;
		if (myNumber == NR_Game_Controller.currentNumber) 
		{
			audio.clip=sounds[0];
			audio.Play();
			NR_Game_Controller.addScore (10);
			NR_Game_Controller.currentNumber = 0;//reset the flag so a new number get chosen
		} else 
		{
			audio.clip=sounds[1];
			audio.Play();
		}
	}
	void OnMouseUp(){
		spriteRenderer.sprite = Num_Over;
	}
}
