var Button: Sprite;
var Button_Over: Sprite;
//var Button_Down: Sprite;

function OnMouseEnter()
{
GetComponent(SpriteRenderer).sprite = Button_Over;
}

function OnMouseExit()
{
GetComponent(SpriteRenderer).sprite = Button;
}

function OnMouseDown()
{
Application.LoadLevel("NumberLearn");
}