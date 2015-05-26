using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class networkCharacter : Photon.MonoBehaviour {
	public Vector3 realPosition = Vector3.zero;
	public Vector3 positionAtLastPacket = Vector3.zero;
	public double currentTime = 0.0;
	public double currentPacketTime = 0.0;
	public double lastPacketTime = 0.0;
	public double timeToReachGoal = 0.0;
	
	void Update ()
	{
		if (!photonView.isMine)
		{
			timeToReachGoal = (currentPacketTime-5) / lastPacketTime;
			currentTime += Time.deltaTime;
			transform.position = Vector3.Lerp(positionAtLastPacket, realPosition, (float)(currentTime / timeToReachGoal));
		}
	}
	
	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting)
		{
			stream.SendNext((Vector3)transform.position);
		}
		else
		{
			currentTime = 0.0;
			positionAtLastPacket = transform.position;
			realPosition = (Vector3)stream.ReceiveNext();
			lastPacketTime = currentPacketTime;
			currentPacketTime = info.timestamp;
		}
	}
}
