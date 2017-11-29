using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class GameRooms : NetworkBehaviour
{

   private NetworkController networkController;
   public NetworkController networkCONTROLLER
   { get { if (networkController == null) networkController = FindObjectOfType<NetworkController>(); return networkController; } }


    private MatchInfoSnapshot match;

    private NetworkManager networkManager;


    public void Start()
    {
        networkManager = NetworkManager.singleton;

        if (networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }
    }

    public void SetMatch(MatchInfoSnapshot getMatch)
    {
        match = getMatch;
        gameObject.transform.GetChild(0).GetComponent<Text>().text = match.currentSize + " / " + match.maxSize;
    }

    //Sends the player to the selected room
   // [ClientRpc]
    public void JoinRoom()
    {
        networkManager.matchMaker.JoinMatch(match.networkId, "", "", "", 0, 0, networkManager.OnMatchJoined);
    }

    public void OnMatchJoined(bool success, string extendedInfo, MatchInfo matchInfo)
    {

    }

}
