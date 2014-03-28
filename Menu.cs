using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public GUIStyle gst;
	private int tapCount=0;
	private bool showMessage=false;
	
	// Update is called once per frame
	void Update () {
		if ( Application.platform == RuntimePlatform.Android &&(Input.GetKeyDown(KeyCode.Escape)))
		{
			tapCount++;

			StartCoroutine("resetTapCount");

			if(tapCount>1){
			Application.Quit();
			}
		}	

	}
	void OnGUI(){
		if (showMessage) {

			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 100, 100), "再按一次退出哟!",gst);
				}
	}
	IEnumerator resetTapCount(){
		showMessage = true;
		yield return new WaitForSeconds(1);
		tapCount =0;
		showMessage = false;
	}
}
