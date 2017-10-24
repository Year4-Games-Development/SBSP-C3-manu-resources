
using UnityEngine;

public class ResearchModel
{
    private int ironAmount = 2400;
    private bool[] scienceLvReseached = { false, false, false };
    private bool[] combatLvReseached = { false, false, false };
    private bool[] enginLvResearched = { false, false, false };
    /// <summary>
    /// science branch variables 
    /// </summary>
    private string scienceText = "Science";
    private string scienceLevel1 = "Faster Mining Rate, Research time 10 secounds";
    private string scienceLevel2 = "Larger Droids Area, Research time 20 secounds";
    private string scienceLevel3 = "Extra Droids, Research time 30 secounds";

    /// <summary>
    /// combat branch variables
    /// </summary>
    private string combatText = "Combat";
    private string combatLevel1 = "More Damage, Research time 10 secounds";
    private string combatLevel2 = "Better Shields, Research time 20 secounds";
    private string combatLevel3 = "More efficient, Research time 30 secounds";

    /// <summary>
    /// engineering branch variables
    /// </summary>
    private string enginText = "Engineering";
    private string enginLevel1 = "Better engins, Research time 10 secounds";
    private string enginLevel2 = "Better reactor, Research time 20 secounds";
    private string enginLevel3 = "Better Speed, Research time 30 secounds";
    
    /// <summary>
    /// research time for each level 
    /// </summary>
    private float researchTimeLv1 = 5.0f;
    private float researchTimeLv3 = 10.0f;
    private float researchTimeLv2 = 15.0f;
    /// <summary>
    /// science getter methods 
    /// </summary>
    /// <returns></returns>
    public string GetScienceText()
    {
        return scienceText;
    }
    public string GetScienceLevel1()
    {
        return scienceLevel1;
    }
    public string GetScienceLevel2()
    {
        return scienceLevel2;
    }
    public string GetScienceLevel3()
    {
        return scienceLevel3;
    }
    /// <summary>
    /// combat getter methods
    /// </summary>
    /// <returns></returns>
    public string GetCombatText()
    {
        return combatText;
    }
    public string GetCombatLevel1()
    {
        return combatLevel1;
    }
    public string GetCombatLevel2()
    {
        return combatLevel2;
    }
    public string GetCombatLevel3()
    {
        return combatLevel3;
    }
    /// <summary>
    /// engineering getter methods 
    /// </summary>
    /// <returns></returns>
    public string GetEnginText()
    {
        return enginText;
    }
    public string GetEnginLevel1()
    {
        return enginLevel1;
    }
    public string GetEnginLevel2()
    {
        return enginLevel2;
    }
    public string GetEnginLevel3()
    {
        return enginLevel3;
    }

    /// <summary>*****************************************************************************************
    /// research time for all level 1 items 
    /// </summary>
    /// <returns></returns>
    public float GetResearchTimeLv1()
    {
        return researchTimeLv1;
    }

    /// <summary>
    /// research time for all level 2 items 
    /// </summary>
    /// <returns></returns>
    public float GetResearchTimeLv2()
    {
        return researchTimeLv2;
    }

    /// <summary>
    /// research time for all level 3 items 
    /// </summary>
    /// <returns></returns>
    public float GetResearchTimeLv3()
    {
        return researchTimeLv3;
    }
    //****************************************************************************************************
    public bool GetScienceLvReseachedByIndex(int i)
    {
        return scienceLvReseached[i];
    }
    
    public void SetScienceLvReseachedByIndex(int i, bool researchComplete)
    {
        scienceLvReseached[i] = researchComplete;
    }

    public bool GetCombatLvReseachedByIndex(int i)
    {
        return combatLvReseached[i];
    }

    public void SetCombatLvReseachedByIndex(int i, bool researchComplete)
    {
        combatLvReseached[i] = researchComplete;
    }

    public bool GetEnginLvReseachedByIndex(int i)
    {
        return enginLvResearched[i];
    }

    public void SetEnginLvReseachedByIndex(int i, bool researchComplete)
    {
        enginLvResearched[i] = researchComplete;
    }

    public int GetIronAmount()
    {
        return ironAmount;
    }

    public void SetIronAmount(int amount)
    {
        ironAmount -= amount;
    }

}
