using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NetworkManager : MonoBehaviour {

	public static int connected;
	private float position=2.4f;
	public static bool ttt = false;
	// Use this for initialization
	void Start () {
		Connect ();
	}
	
	void Connect() {
		PhotonNetwork.ConnectUsingSettings ("asd");
	}

	void OnGUI() {
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString ());
	}

	void OnJoinedLobby() {
		PhotonNetwork.JoinRandomRoom ();

	}

	void OnPhotonRandomJoinFailed() {
		PhotonNetwork.CreateRoom (null);

	}

	void OnJoinedRoom(){
		SpawnMyPlayer ();
	}

	void OnPhotonPlayerConnected(PhotonPlayer connectedq){
		Debug.Log (connectedq.ID);
		ttt = true;
	}
	
		
	void SpawnMyPlayer() {
		GameObject myPlayerGO = (GameObject) PhotonNetwork.Instantiate ("PlayerController4",new Vector3(position,0,0),Quaternion.identity,0);
		connected++;//"PlayerController"
		((MonoBehaviour)myPlayerGO.GetComponent ("move")).enabled = true;
		//((MonoBehaviour)myPlayerGO.GetComponent ("prob")).enabled = true;
		//((MonoBehaviour)myPlayerGO.transform.FindChild ("Main_Body").GetComponent ("prob")).enabled = true;
		//((MonoBehaviour)myPlayerGO.transform.FindChild ("Plane").GetComponent ("prob")).enabled = true;
		//((MonoBehaviour)myPlayerGO.transform.FindChild ("Plane_001").GetComponent ("prob")).enabled = true;
		//((MonoBehaviour)myPlayerGO.transform.FindChild ("Plane_000").GetComponent ("prob")).enabled = true;
		//((MonoBehaviour)myPlayerGO.transform.FindChild ("Plane_004").GetComponent ("prob")).enabled = true;
		//((MonoBehaviour)myPlayerGO.GetComponent ("MouseLook")).enabled = true;
		myPlayerGO.transform.FindChild ("Main Cam").gameObject.SetActive (true);
	}

	void Update() {
		connected = PhotonNetwork.countOfPlayers;
		if(connected == 2)
			position = -2.4f;
		Debug.Log ("connected: " + connected);
	}


	

}
