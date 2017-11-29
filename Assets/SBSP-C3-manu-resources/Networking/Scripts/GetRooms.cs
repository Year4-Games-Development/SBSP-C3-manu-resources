using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using System.Collections.Generic;
using System;

public class GetRooms : MonoBehaviour
{
    private NetworkingView networkingView;
    public NetworkingView networkingVIEW
    { get { if (networkingView == null) networkingView = FindObjectOfType<NetworkingView>(); return networkingView; } }

    private NetworkManager networkManager;

    public void Start()
    {
        networkManager = NetworkManager.singleton;

        if (networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }

        DisplayRoom();
    }

    public void DisplayRoom()
    {
        //Number of rooms to display
        networkManager.matchMaker.ListMatches(0, 5, "", true, 0, 0, OnMatchList);
    }

    public void OnMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matches)
    {
        if (success && matches != null && matches.Count > 0)
        {
            Debug.Log("Match available!");

            foreach (MatchInfoSnapshot match in matches)
            {
                GameObject go = Instantiate(networkingVIEW.RoomPrefab);

                go.transform.SetParent(networkingVIEW.RoomsPanel.transform);
                go.GetComponent<GameRooms>().SetMatch(match);
            }

        }
        else if (!success)
        {
            Debug.LogError("List match failed: " + extendedInfo);
        }

       
    }



}
