using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	//sunears

	public bool used;
	public GUIStyle gst;
	public AudioClip fszaudio;
	public bool playMov=false;
	public string showMessage;

	//sunears
	void OnGUI(){
		if(used)
			if (playMov) {					
				
				GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 100, 100),showMessage,gst);
				
				StartCoroutine("isPlayEnd");
			}		
			

		
		
	}
	public IEnumerator isPlayEnd(){

		if (!audio.isPlaying) {
			audio.clip=fszaudio;			
			audio.Play();
		}	

		yield return new WaitForSeconds (3);
		//mov.Stop ();
		playMov = false;

		
		
		
	}
}
