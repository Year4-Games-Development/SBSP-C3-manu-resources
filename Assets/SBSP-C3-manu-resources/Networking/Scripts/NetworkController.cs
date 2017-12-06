using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkController : MonoBehaviour
{
    private List<Transform> localPlayers;
    public List<Transform> LocalPlayers { get { return localPlayers; } set { localPlayers = value; } }

    //[SyncVar]
    private bool connectedCommander = false;
    public bool ConnectedCommander { get { return connectedCommander; } set { connectedCommander = value; } }

    // [SyncVar]
    private bool connectedManufacture = false;
    public bool ConnectedManufacture { get { return connectedManufacture; } set { connectedManufacture = value; } }

    // [SyncVar]
    private bool connectedEnginer = false;
    public bool ConnectedEnginer { get { return connectedEnginer; } set { connectedEnginer = value; } }

    // [SyncVar]
    private bool connectedNavigation = false;
    public bool ConnectedNavigation { get { return connectedNavigation; } set { connectedNavigation = value; } }

}
