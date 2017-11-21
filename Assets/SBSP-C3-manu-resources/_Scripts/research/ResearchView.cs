using UnityEngine.UI;

public class ResearchView
{
    private Text _researchName;
    private Text _description;
    private Button _researchButton;
    private Text _timeText;

    public ResearchView(Text name, Text description, Button button, Text timer)
    {
        _researchName = name;
        _description = description;
        _researchButton = button;
        _timeText = timer;
    }

    public void SetName(string name)
    {
        _researchName.text = name;
    }

    public void SetDescription(string description)
    {
        _description.text = description;
    }

    public Button GetResearchButton()
    {
        return _researchButton;
    }

    public void DisableResearchButton()
    {
        _researchButton.gameObject.SetActive(false);
    }

    public void EnableResearchButton()
    {
       _researchButton.gameObject.SetActive(true);
    }

    public void SetTimerText(string value)
    {
        _timeText.text = value;
    }

    public Text GetTimeButton()
    {
        return _timeText;
    }
	
}
