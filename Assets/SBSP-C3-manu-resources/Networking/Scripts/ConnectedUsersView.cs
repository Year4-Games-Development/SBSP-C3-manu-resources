using UnityEngine;
using UnityEngine.Networking;

public class ConnectedUsersView : NetworkBehaviour
{
    [SerializeField]
    private GameObject backgroundPanel;
    public GameObject BackgroundPanel { get { return backgroundPanel; } set { backgroundPanel = value; } }

    [SerializeField]
    private GameObject thisIsLocalPlayer;
    public GameObject ThisIsLocalPlayer { get { return thisIsLocalPlayer; } set { thisIsLocalPlayer = value; } }

    [SerializeField]
    private Transform manufacture;
    public Transform Manufacture { get { return manufacture; } set { manufacture = value; } }

    [SerializeField]
    private Transform enginers;
    public Transform Enginers { get { return enginers; } set { enginers = value; } }

    [SerializeField]
    private Transform navigations;
    public Transform Navigations { get { return navigations; } set { navigations = value; } }

    [SerializeField]
    private Transform connectedUsersPanel;
    public Transform ConnectedUsersPanel{ get { return connectedUsersPanel; } set { connectedUsersPanel = value; } }

    private string playerName;
    public string PlayerName { get { return playerName; } set { playerName = value; } }

    private bool checkIsLocalPlayer = false;
    public bool CheckIsLocalPlayer { get { return checkIsLocalPlayer; } set { checkIsLocalPlayer = value; } }

}
