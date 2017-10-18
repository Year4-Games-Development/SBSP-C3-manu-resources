using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchController : MonoBehaviour
{
    private ResearchModel researchModel;
    private RechargeTimer rechargeTimer;

	// Use this for initialization
	void Awake ()
    {
        researchModel = new ResearchModel();
        rechargeTimer = new RechargeTimer();
	}

    public ResearchModel GetResearchModel()
    {
        return researchModel;
    }

    public RechargeTimer GetRechargeTimer()
    {
        return rechargeTimer;
    }
}
