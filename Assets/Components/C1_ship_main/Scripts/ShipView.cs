using UnityEngine;
using UnityEngine.UI;

public class ShipView : MonoBehaviour 
{
    public Text textBridgeHealth;

    private ShipController shipController;
    private ShipModel shipModel;
    void Awake()
    {
        shipController = GetComponent<ShipController>();
    }

	void Start () 
    {
		shipModel = shipController.GetShipModel();
		UpdateViews();
	}
	
    void Update () 
    {
        UpdateViews();
	}

    private void UpdateViews()
    {
        textBridgeHealth.text = shipModel.GetHealthBridge() + "%";
        
    }
}
