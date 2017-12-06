using UnityEngine.UI;


public class ResearchModel{

    private ResearchPanelController _panelController;
    private ManuController manuController;
    private Research _research;

    private ResearchView _researchView;
    private RechargeTimer _timer;

    public ResearchModel(Text name, Text description, Button button, Text timerText)
    {
        _researchView = new ResearchView(name, description, button, timerText);
        _timer = new RechargeTimer();
    }


    public void SetResearch(Research research)
    {
        _research = research;

        //update the view when research is added
        _researchView.SetName(_research.GetName());
        _researchView.SetDescription(_research.GetDescription());
        _researchView.SetTimerText("Time to learn: " + _research.GetTime());
    }

    public void SetPanelController(ResearchPanelController controller)
    {
        _panelController = controller;
    }

    public ResearchPanelController GetMainController()
    {
        return _panelController;
    }

    public ResearchView GetResearchView()
    {
        return _researchView;
    }

    public RechargeTimer GetTimer()
    {
        return _timer;
    }

    public Research GetResearch()
    {
        return _research;
    }
}
