using UnityEngine;
using UnityEngine.UI;

public class NetworkingView : MonoBehaviour {
    
    [SerializeField]
    public Transform roomsPanel;
    public Transform RoomsPanel { get { return roomsPanel; } set { roomsPanel = value; } }

    [SerializeField]
    private GameObject roomPrefab;
    public GameObject RoomPrefab { get { return roomPrefab; } set { roomPrefab = value; } }
}
