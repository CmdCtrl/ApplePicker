using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestStuff : MonoBehaviour {

	public Text scoreText;

	public int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Apple")
		{
			score++;
			scoreText.text = score.ToString ();
			//Destroy(col.gameObject);
		}
	}
}
