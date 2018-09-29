using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LocalHost : MonoBehaviour {

	public void StartServer()
	{
		NetworkConnectionError error = Network.InitializeServer(10, 8888, false);
		Debug.Log(error);
		Debug.Log(Network.peerType);
		// Network.
	}
}
