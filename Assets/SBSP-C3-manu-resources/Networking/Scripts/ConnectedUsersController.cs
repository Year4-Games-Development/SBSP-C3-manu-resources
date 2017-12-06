using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ConnectedUsersController : NetworkBehaviour
{
    //In game network view
    private ConnectedUsersView connectedUsersView;
    public ConnectedUsersView connectedUsersVIEW
    { get { if (connectedUsersView == null) connectedUsersView = FindObjectOfType<ConnectedUsersView>(); return connectedUsersView; } }

    private NetworkManager networkManager;

    public void Start()
    {
        networkManager = NetworkManager.singleton;

        if (networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }

        if (isServer)
        {
            //Debug.Log(" isServer : YES");
            connectedUsersVIEW.BackgroundPanel.gameObject.SetActive(false);

            //Check if this is a local player
            CheckConnectedUsers();
        }

    }

    public void CheckLoggedUser()
    {

    }

    public void ManufactureBtn(GameObject go)
    {
        connectedUsersVIEW.PlayerName = "Manufacture";
        connectedUsersVIEW.BackgroundPanel.SetActive(false);

        //Checking if it is the local player.
        CheckConnectedUsers();

        //Set the player name.
        SetPlayer(connectedUsersVIEW.PlayerName);
    }

    public void EnginersBtn(GameObject go)
    {
        connectedUsersVIEW.PlayerName = "Enginer";
        connectedUsersVIEW.BackgroundPanel.SetActive(false);

        //Checking if it is the local player.
        CheckConnectedUsers();

        //Set the player name.
        SetPlayer(connectedUsersVIEW.PlayerName);
    }

    public void NavigationsBtn(GameObject go)
    {
        connectedUsersVIEW.PlayerName = "Navigation";
        connectedUsersVIEW.BackgroundPanel.SetActive(false);

        //Checking if it is the local player.
        CheckConnectedUsers();

        //Set the player name.
        SetPlayer(connectedUsersVIEW.PlayerName);
    }

    public void CheckConnectedUsers()
    {
        int count = connectedUsersVIEW.ConnectedUsersPanel.childCount;

        for (int i = 0; i < count; i++)
        {
            GameObject go = connectedUsersVIEW.ConnectedUsersPanel.GetChild(i).gameObject;

            bool resault = go.gameObject.GetComponent<NetworkIdentity>().isLocalPlayer;

            if (resault == true)
            {
                //Debug.Log(go.name + " isLocalPlayer : YES");
                connectedUsersVIEW.ThisIsLocalPlayer = go.gameObject;
            }
            else
            {
                // Debug.Log(go.name + " isLocalPlayer : NO");
            }
        }

    }

    public void SetPlayer(string tempName)
    {
        connectedUsersVIEW.ThisIsLocalPlayer.GetComponent<Player>().CmdSetPlayerName(tempName);
        connectedUsersVIEW.ThisIsLocalPlayer.transform.GetChild(0).GetComponent<Text>().text = tempName;
    }

   
}
