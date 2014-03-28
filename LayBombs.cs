using UnityEngine;
using System.Collections;

public class LayBombs : MonoBehaviour
{
	[HideInInspector]
	public bool bombLaid = false;		// Whether or not a bomb has currently been laid.
	public int bombCount = 0;			// How many bombs the player has.
	public AudioClip bombsAway;			// Sound for when the player lays a bomb.
	public GameObject bomb;				// Prefab of the bomb.


	private GUITexture bombHUD;			// Heads up display of whether the player has a bomb or not.
	private GUIText bombCountTxt;

	void Awake ()
	{
		// Setting up the reference.
		bombHUD = GameObject.Find("ui_bombHUD").guiTexture;
		bombCountTxt = GameObject.Find ("bombCountShow").guiText;
	}


	void Update ()
	{


		// The bomb heads up display should be enabled if the player has bombs, other it should be disabled.
		bombHUD.enabled = bombCount > 0;
		bombCountTxt.enabled = bombHUD.enabled;
	}
	void OnGUI () {


	}
	void OnEnable()
	{
		EasyTouch.On_TouchUp += On_TouchUp;
	}
	void OnDisable()
	{
		EasyTouch.On_TouchUp -= On_TouchUp;
	}
	void OnDestroy()
	{
		EasyTouch.On_TouchUp -= On_TouchUp;
	}
	private void  On_TouchUp( Gesture gesture )
	{
		if (bombHUD.enabled) {
			if (gesture.IsInRect (bombHUD.GetScreenRect(),false)&& !bombLaid && bombCount > 0){
				bombCount--;
				// Set bombLaid to true.
				bombLaid = true;
				// Play the bomb laying sound.
				AudioSource.PlayClipAtPoint(bombsAway,transform.position);
				// Instantiate the bomb prefab.
				Instantiate(bomb, transform.position, transform.rotation);
			}
				
		}
	}
}
