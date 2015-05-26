using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	// Use this for initialization
	public GameObject spawnn;

	void Start () {
		Instantiate (spawnn,new Vector3(2.4f,0,-30),Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		//Transform t = spawnn.GetComponentInChildren<Transform> ().Find("Main Cam");
		//Transform asdd = t.FindChild ("GameObject");
		//asdd.transform.Rotate (new Vector3 (0, 0, 0));
	}
}
