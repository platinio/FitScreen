using UnityEngine;
using System.Collections;

//simple script for made a sprite fit all the screen

public class FitAllScreen : MonoBehaviour 
{
	void Start()
	{

		SpriteRenderer render = GetComponent<SpriteRenderer> ();

		if(render == null)
			return;

		float worldScreenHeight = Camera.main.orthographicSize * 2;
		float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

		transform.localScale = new Vector3 (worldScreenWidth / render.sprite.bounds.size.x,	worldScreenHeight / render.sprite.bounds.size.y, 1);
	}
}
