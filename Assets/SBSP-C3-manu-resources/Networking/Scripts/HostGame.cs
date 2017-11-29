using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class HostGame : MonoBehaviour
{
    private NetworkController networkController;
    public NetworkController networkCONTROLLER
    { get { if (networkController == null) networkController = FindObjectOfType<NetworkController>(); return networkController; } }

    private uint roomSize = 5;

    private string roomName = "New Room";

    private NetworkManager networkManager;

    public void Start()
    {
        networkManager = NetworkManager.singleton;

        if (networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }
    }

    public void SetRoomName(string name)
    {
        roomName = name;
    }

    public void CreateRoom()
    {
        if (roomName != "")
        {
            //Debug.Log("Room created");
            networkManager.matchMaker.CreateMatch(roomName, roomSize, true, "", "", "", 0, 0, networkManager.OnMatchCreate);
        }
    }

    public void OnMatchCreate(bool success, string extendedInfo, List<MatchInfoSnapshot> matchInfo)
    {


    }


}
