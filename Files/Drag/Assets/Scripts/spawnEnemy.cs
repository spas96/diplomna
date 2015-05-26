using UnityEngine;
using System.Collections;

public class spawnEnemy : MonoBehaviour {
	public GameObject spawnn;
	// Use this for initialization
	void Start () {
		Instantiate (spawnn,new Vector3(-2.4f,0,-27.4f),Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
