using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class input : MonoBehaviour {
	public InputField inputField;
	public Text userName;
	public Text buttonName;
	public Button FBloginButton;
	public Image fbimg;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void Update () {
		buttonName.text = PlayerPrefs.GetString ("name");


	}

	public void field(){
		Debug.Log ("clicked");
		inputField.gameObject.SetActive (true);
		FBloginButton.gameObject.SetActive (true);
	}

	public void nameSet() {
		Debug.Log ("clicked");
		PlayerPrefs.SetString ("name", inputField.text);
		inputField.gameObject.SetActive (false);
		FBloginButton.gameObject.SetActive (false);

	}

	public void fb() {
		Debug.Log ("clicked");
		inputField.gameObject.SetActive (false);
		FBloginButton.gameObject.SetActive (false);
		
	}



}

