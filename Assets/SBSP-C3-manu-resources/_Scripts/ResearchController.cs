using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchController : MonoBehaviour
{
    private ResearchModel researchModel;

	// Use this for initialization
	void Awake ()
    {
        researchModel = new ResearchModel();
	}

    public ResearchModel GetResearchModel()
    {
        return researchModel;
    }

}
