using UnityEngine;
using System.Collections;

public class AnimatedWater : MonoBehaviour {

	public int materialIndex = 0;
	public Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );
	public string textureName = "_MainTex";
	public float timerMax = 1;

	private float timer = 0;
	Vector2 uvOffset;
	void LateUpdate() 
	{
		timer += Time.deltaTime;
		if (timer >= timerMax) 
		{
			uvAnimationRate.x
			*= -1;
			timer = 0;
		}

		uvOffset += ( uvAnimationRate * Time.deltaTime );

		if( GetComponent<Renderer>().enabled )
		{
			GetComponent<Renderer>().materials[ materialIndex ].SetTextureOffset( textureName, uvOffset );
		}
	}
}
