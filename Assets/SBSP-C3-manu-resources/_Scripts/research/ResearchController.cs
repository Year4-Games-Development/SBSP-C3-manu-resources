using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchController : MonoBehaviour
{
    private ResearchModel researchModel;
    private RechargeTimer rechargeTimer;

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
    /// <summary>
    /// timer methods called during button onclick 
    /// </summary>
    /// <returns></returns>

    public void ScienceLv1Upgrade()
    {
        researchModel.SetIronAmount(100);
        rechargeTimer.ScienceLv1Time();//this makes system wait 10 ecounds 
        researchModel.SetScienceLvReseachedByIndex(0, true);
        Destroy(scienceLv1.gameObject);
        Debug.Log("scienceLv1 Called " + researchModel.GetIronAmount());
    }

    public void ScienceLv2Upgrade()
    {
        researchModel.SetIronAmount(200);
        rechargeTimer.ScienceLv2Time();//this makes system wait 20 ecounds 
        researchModel.SetScienceLvReseachedByIndex(1, true);
        Destroy(scienceLv2.gameObject);
        Debug.Log("scienceLv2 Called " + researchModel.GetIronAmount());
    }

    public void ScienceLv3Upgrade()
    {
        researchModel.SetIronAmount(300);
        rechargeTimer.ScienceLv3Time();//this makes system wait 30 ecounds 
        researchModel.SetScienceLvReseachedByIndex(2, true);
        Destroy(scienceLv3.gameObject);
        Debug.Log("scienceLv3 Called " + researchModel.GetIronAmount());

    }

    public void CombatLv1Upgrade()
    {
        researchModel.SetIronAmount(100);
        rechargeTimer.ScienceLv1Time();//this makes system wait 10 ecounds 
        researchModel.SetCombatLvReseachedByIndex(0, true);
        Destroy(combatLv1.gameObject);
        Debug.Log("combatLv1 Called " + researchModel.GetIronAmount());
    }

    public void CombatLv2Upgrade()
    {
        researchModel.SetIronAmount(200);
        rechargeTimer.ScienceLv2Time();//this makes system wait 20 ecounds 
        researchModel.SetCombatLvReseachedByIndex(1, true);
        Destroy(combatLv2.gameObject);
        Debug.Log("combatLv2 Called " + researchModel.GetIronAmount());
    }

    public void CombatLv3Upgrade()
    {
        researchModel.SetIronAmount(300);
        rechargeTimer.ScienceLv3Time();//this makes system wait 30 ecounds 
        researchModel.SetCombatLvReseachedByIndex(2, true);
        Destroy(combatLv3.gameObject);
        Debug.Log("combatLv3 Called " + researchModel.GetIronAmount());
    }

    public void EnginLv1Upgrade()
    {
        researchModel.SetIronAmount(100);//reduce iron amout
        rechargeTimer.ScienceLv1Time();//this makes system wait 10 ecounds 
        researchModel.SetEnginLvReseachedByIndex(0, true);
        Destroy(enginLv1.gameObject);
        Debug.Log("enginLv1 Called " + researchModel.GetIronAmount());
    }

    public void EnginLv2Upgrade()
    {
        researchModel.SetIronAmount(200);
        rechargeTimer.ScienceLv2Time();//this makes system wait 20 ecounds 
        researchModel.SetEnginLvReseachedByIndex(1, true);
        Destroy(enginLv2.gameObject);
        Debug.Log("enginLv2 Called " + researchModel.GetIronAmount());
    }

    public void EnginLv3Upgrade()
    {
        researchModel.SetIronAmount(300);
        rechargeTimer.ScienceLv3Time();//this makes system wait 30 ecounds 
        researchModel.SetEnginLvReseachedByIndex(2, true);
        Destroy(enginLv3.gameObject);
        Debug.Log("enginLv3 Called " + researchModel.GetIronAmount());
    }
}
