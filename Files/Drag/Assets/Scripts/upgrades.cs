using UnityEngine;
using System.Collections;

public class upgrades : MonoBehaviour {
	public GameObject otherGameObject;
	private shop shopScript;
	// Use this for initialization
	void Start () {
		shopScript = otherGameObject.GetComponent<shop> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("upgrade: "+PlayerPrefs.GetInt("upgrade"));
		//PlayerPrefs.DeleteKey ("upgrade");
	}

	public void tyresUpgrade(){
		if(shopScript.tyres1)
			PlayerPrefs.SetInt("upgrade", 1);
	}

	public void gearboxUpgrade(){
		if(shopScript.gearbox1)
			PlayerPrefs.SetInt("upgrade", 2);
	}

	public void engineUpgrade(){
		if(shopScript.engine1)
			PlayerPrefs.SetInt("upgrade", 3);
	}
}
