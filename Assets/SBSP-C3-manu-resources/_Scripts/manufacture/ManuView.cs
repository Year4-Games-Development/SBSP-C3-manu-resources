using UnityEngine.UI;

public class ManuView
{
    private Text _name;
    private Text _description;
    private Text _cost;
    private Button _manufactureButton;


    public ManuView(Text name, Text description, Button button, Text cost)
    {
        _name = name;
        _description = description;
        _manufactureButton = button;
        _cost = cost;
    }

    public void SetName(string name)
    {
        _name.text = name;
    }

    public void SetDescription(string description)
    {
        _description.text = description;
    }

    public void SetCost(string cost)
    {
        _cost.text = cost;
    }

    public Text GetManufacturNutton()
    {
        return _cost;
    }

    public Button GetManufactureButton()
    {
        return _manufactureButton;
    }

    public void DisableResearchButton()
    {
        _manufactureButton.gameObject.SetActive(false);
    }

    public void EnableResearchButton()
    {
        _manufactureButton.gameObject.SetActive(true);
    }
}