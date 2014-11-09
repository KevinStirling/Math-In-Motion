using UnityEngine;
using System.Collections;

public class NumberController : MonoBehaviour {
	public Sprite Num_Over;
	public Sprite Num_Normal;
	public Sprite Num_Clicked;

	public AudioClip click;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = Num_Normal;
		transform.position = new Vector3 (Random.Range (-10.0F, 10.0F), Random.Range (-4.0F, 4.0F));
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
	}
	void OnMouseUp(){
		spriteRenderer.sprite = Num_Over;
	}
}
