using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchController : MonoBehaviour
{
    private ResearchModel researchModel;
    public int ironAmount = 600;
    public bool scienceLv1Researched = false;
    public bool scienceLv2Researched = false;
    public bool scienceLv3Researched = false;

    /// <summary>
    /// /Science button references
    /// </summary>
    public Button scienceLv1;
    public Button scienceLv2;
    public Button scienceLv3;

    /// <summary>
    /// /Combat button references
    /// </summary>
    public Button combatLv1;
    public Button combatLv2;
    public Button combatLv3;

    /// <summary>
    /// /Engin button reference
    /// </summary>
    public Button enginLv1;
    public Button enginLv2;
    public Button enginLv3;

    // Use this for initialization
    void Awake ()
    {
        researchModel = new ResearchModel();
	}

    public ResearchModel GetResearchModel()
    {
        return researchModel;
    }

    public void ScienceLv1Upgrade()
    {
        ironAmount -= 100;
        scienceLv1Researched = true;
        Debug.Log("scienceLv1 Called " + ironAmount);
    }

    public void ScienceLv2Upgrade()
    {
        ironAmount -= 200;
        scienceLv2Researched = true;
        Debug.Log("scienceLv2 Called " + ironAmount);
    }

    public void ScienceLv3Upgrade()
    {
        ironAmount -= 300;
        scienceLv3Researched = true;
        Debug.Log("scienceLv3 Called " + ironAmount);
    }
}
