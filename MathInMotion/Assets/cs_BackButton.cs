using UnityEngine;
using System.Collections;

public class cs_BackButton : MonoBehaviour
{
	public Sprite Button_Over;
	public Sprite Button;
	public Sprite Button_Clicked;
	
	private SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = Button;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void OnMouseEnter() { 
		spriteRenderer.sprite = Button_Over;
		
	}
	void OnMouseExit() { 
		spriteRenderer.sprite = Button;
	}
	
	void OnMouseDown(){
		Application.LoadLevel("GameSelect");
	}
	
	
}

