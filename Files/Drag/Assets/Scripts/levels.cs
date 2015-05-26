using UnityEngine;
using System.Collections;

public class levels : MonoBehaviour {
	public int subLevel = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetInt("SubLevel", subLevel);
	}
}
