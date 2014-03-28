using UnityEngine;
using System.Collections;

public class UIBombHUD : MonoBehaviour {
	public GameObject gob;
	// Use this for initialization
	void update(){

	}
	void OnEnable()
	{
		EasyTouch.On_TouchUp += On_TouchUp;
	}
	void OnDisable()
	{
		EasyTouch.On_Cancel -= On_TouchUp;
	}
	void OnDestroy()
	{
		EasyTouch.On_Cancel -= On_TouchUp;
	}
	private void  On_TouchUp( Gesture gesture )
	{
		if (this != null) {
						Rect rect = new Rect (transform.position.x, transform.position.y, 84, 70);
						if (gesture.IsInRect (rect, false))
								print ("Inside");	
				} else {
			print ("no");
				}
	
	}
}
