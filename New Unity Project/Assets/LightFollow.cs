using UnityEngine;
using System.Collections;

public class LightFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Input.mousePosition.ToString ());

		float mouseX = 0;		
		mouseX = 4 * ((Input.mousePosition.x - Screen.width ) / (Screen.width / 2));

		float mouseY = 0;		
		mouseY = 4 * ((Input.mousePosition.y - Screen.height / 2) / (Screen.height / 2));

		this.transform.position = new Vector3 ((float)mouseX, (float)mouseY, -2.78f);
	}
}
