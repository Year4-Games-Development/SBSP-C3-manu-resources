using UnityEngine;
using UnityEngine.UI;
public class ResearchController : MonoBehaviour, ITimeable
{
    public Text researchName;
    public Text description;
    public Button researchButton;
    public Text timeText;

    private ResearchModel _researchModel;

    void Awake()
    {
        _researchModel = new ResearchModel(researchName, description, researchButton, timeText);
        _researchModel.GetResearchView().GetResearchButton().onClick.AddListener(LearnResearch);
    }

    public ResearchModel GetResearchModel()
    {
        return _researchModel;
    }

    public void LearnResearch()
    {
        Debug.Log("Learning: " + _researchModel.GetResearch().GetName());
        StartCoroutine(_researchModel.GetTimer().StartTimerCouroutine(_researchModel.GetResearch().GetTime(), this));
    }

    public void OnStartTimer()
    {
        _researchModel.GetResearchView().DisableResearchButton();
        _researchModel.GetResearchView().GetTimeButton().text = "Time left: " + _researchModel.GetTimer().GetRemainingSecondsInt();
    }

    public void OnIncrementTimer()
    {
        _researchModel.GetResearchView().GetTimeButton().text = "Time left: " + _researchModel.GetTimer().GetRemainingSecondsInt();
    }

    public void OnFinishTimer()
    {
        _researchModel.GetResearchView().GetTimeButton().text = "Researched";
        _researchModel.GetResearch().SetLearned(true);
        _researchModel.GetMainController().OnResearchFinishedEvent();
    }

}



