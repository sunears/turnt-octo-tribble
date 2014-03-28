using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;					// The player's score.


	private PlayerControl playerControl;	// Reference to the player control script.
	private int previousScore = 0;			// The score in the previous frame.
	private Mine mine;

	void Awake ()
	{
		// Setting up the reference.
		playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
		mine = GameObject.Find ("mine").GetComponent<Mine> ();
	}


	void Update ()
	{
		// Set the score text.
		guiText.text = "Score: " + score;

		// If the score has changed...
		if (previousScore != score)
		{
			// ... play a taunt.
			playerControl.StartCoroutine (playerControl.Taunt ());
			 	mine.playMov=true;
		}
		// Set the previous score to this frame's score.
		previousScore = score;
	}

}
