using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

//[SyncVar] Uses NetworkBehaviour not MonoBehaviour
public class Player : NetworkBehaviour
{
    //In game network view
    private ConnectedUsersView connectedUsersView;
    public ConnectedUsersView connectedUsersVIEW
    { get { if (connectedUsersView == null) connectedUsersView = FindObjectOfType<ConnectedUsersView>(); return connectedUsersView; } }

    [SyncVar]
    private string playerName = "Commander";

    public void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Text>().text = "" + playerName;
        SetPlayerParent();
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<Image>().color = Color.green;
    }

    void SetPlayerParent()
    {
        gameObject.transform.SetParent(connectedUsersVIEW.transform);
    }

    [Command]
    public void CmdSetPlayerName(string name)
    {
        playerName = name;
        gameObject.transform.GetChild(0).GetComponent<Text>().text = "" + playerName;
    }
}
