using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {
	public GameObject statMenuGameObject;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	public void ClickTest() {
		Debug.Log ("exit");
		Application.Quit();
	}

	void OnApplicationQuit() {
		PlayerPrefs.DeleteKey ("stat");
		statMenuGameObject.gameObject.SetActive (false);
	}

}
