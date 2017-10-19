using UnityEngine;
using UnityEngine.UI;

public class DroidBayView{

    private Button _deployButton;
    private Button _upgradeButton;
    private Button _removeButton;

	public DroidBayView(Button deploy, Button upgrade, Button remove)
    {

        _deployButton = deploy;
        _upgradeButton = upgrade;
        _removeButton = remove;

    }
}
