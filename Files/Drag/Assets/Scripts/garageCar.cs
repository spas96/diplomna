using UnityEngine;
using System.Collections;

public class garageCar : MonoBehaviour {
	public GameObject cylinder;

	// Use this for initialization
	void Start () {

		cylinder.transform.position = new Vector3 (Screen.width/2, Screen.height/2-55, 392f);
	}
	
	// Update is called once per frame
	void Update () {
		cylinder.transform.Rotate(new Vector3(0,10,0) * Time.deltaTime);
	}
}
