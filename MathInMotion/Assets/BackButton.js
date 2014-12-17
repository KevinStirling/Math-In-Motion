//var Button_Over: Sprite;
//var Button_Down: Sprite;
//var Button: Sprite;
var upAmount = 0.5;
var speed = 0.5;

//var spriterenderer: SpriteRenderer;
//private var downPos : Vector3;
//private var upPos : Vector3;
//private var curPos : Vector3;

//function Start(){
//	spriterenderer = GetComponent(SpriteRenderer);
//	spriterenderer.sprite = Button;
//	print("back button start");
//}

//function onMouseEnter()
//{
//	print("onMouseEnter");
//	spriterenderer.sprite = Button_Over;	
//}

//function OnMouseExit()
//{
//	print("onMouseExit");
//	spriterenderer.sprite = Button;
//}


function OnMouseDown()
{
Application.LoadLevel("GameSelect");
}