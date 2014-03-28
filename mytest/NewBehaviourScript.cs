using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public Rigidbody2D backgroundProp;
	public Transform brick;
	public int i=0;
	// Use this for initialization
	void Start () {
		Random.seed = System.DateTime.Today.Millisecond;

		// Start the Spawn coroutine.
		//StartCoroutine("Spawn");
		print ("Start is go on");
	//	bool b;
	//	b = GameObject.Find ("ameObject");
	//	print(b);

	}
	void Update(){
		//print ("Update" + i++);	
	}
	IEnumerator Spawn ()
	{
		Vector3 spawnPos = new Vector3(0,0,0);
		Rigidbody2D propInstance = Instantiate(backgroundProp, spawnPos, Quaternion.identity) as Rigidbody2D;
		print (propInstance.transform.position.x);
		print (propInstance.transform.position.y);
		print (propInstance.transform.position.z);
		print (propInstance.transform.localScale.x);
		print (propInstance.transform.localScale.y);

		yield return new WaitForSeconds (5);
		Vector3 scale = propInstance.transform.localScale;
		print (scale.x);
		print (scale.y);
		print (scale.z);
		scale.x *= -1;
		propInstance.transform.localScale = scale;
		print (scale.x);
		print (scale.y);
		print (scale.z);
		propInstance.velocity = new Vector2 (3, 0);

		if(propInstance != null)
		Destroy (propInstance.gameObject,10);

		yield return null;
	}
}
