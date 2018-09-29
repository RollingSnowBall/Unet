using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class HostGame : MonoBehaviour {

	void Start()
	{

	}

	public void StartServer()
	{
		NetworkManager.singleton.StartMatchMaker();
		NetworkManager.singleton.matchMaker.CreateMatch("helloword", 10, true, "", "", "", 0, 0, NetworkManager.singleton.OnMatchCreate);
	}

	public void StartClient()
	{
		NetworkManager.singleton.StartMatchMaker();
		var manager = NetworkManager.singleton;
    	manager.matchMaker.ListMatches(0, 10, "", true, 0, 0, OnMatchList);
	}

	List<MatchInfoSnapshot> roomList = null;
    public void OnMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matches)
    {
        if (matches == null)
        {
            Debug.Log("null Match List returned from server");
            return;
        }
		Debug.Log(matches.Count);
        roomList = new List<MatchInfoSnapshot>();
        roomList.Clear();
        foreach (MatchInfoSnapshot match in matches)
        {
            roomList.Add(match);
			Debug.Log(match.name);
        }
     }
}
