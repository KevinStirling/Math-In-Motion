using UnityEngine;
using System.Collections;

public class NumberLearnNumberController : MonoBehaviour {
	public Sprite Num_Over;
	public Sprite Num_Normal;
	public Sprite Num_Clicked;

	private SpriteRenderer spriteRenderer;
	//private Vector3 currrentPos;
	private Vector3 finalPos;

	public NumberLearnGameController NL_Game_Controller;


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
		NL_Game_Controller.addScore (10);
		spriteRenderer.sprite = Num_Clicked;
		audio.Play ();
	}
	void OnMouseUp(){
		spriteRenderer.sprite = Num_Over;
	}
}
