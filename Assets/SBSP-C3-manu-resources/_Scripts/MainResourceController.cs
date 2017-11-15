using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainResourceController : MonoBehaviour {

    public DroidManager droidManager;
    public ResearchPanelController researchController;

    void Start()
    {

        droidManager.GetDroidManagerModel().SetMainController(this);
        researchController.SetMainController(this);//need to implement MC

    }
    
    public DroidManager GetDroidManager()
    {

        return droidManager;

    }

    //change the name later of this class
    public ResearchPanelController GetResearchController()
    {

        return researchController;

    }

}
