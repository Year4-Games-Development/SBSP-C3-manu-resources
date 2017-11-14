
using UnityEngine;

public class ResearchModel
{

    private int ironAmount = 2400;
    private bool[] scienceLvReseached = { false, false, false };
    private bool[] combatLvReseached = { false, false, false };
    private bool[] enginLvResearched = { false, false, false };

    public string GetResearchTime()
    {
        return researchTime;
    }

    private string[] scienceLevels = { "Science", "Faster Mining Rate", "Larger Droid Area", "Extra Droids" };
    private string[] combatLevels = { "Combat", "More Damage", "Better Sheids", "More Efficient"};
    private string[] enginLevels = { "Engineering", "Better Engins", "Better Reactor", "Better Speed"};

    private int[] BlueprintCost = { };
    private int[] BlueprintLevel = { };
    private int[] BlueprintResearchTime = { };

    private string[] BlueprintName = { };

    string researchTime = "not researching";

    /// <summary>
    /// science getter methods 
    /// </summary>
    /// <returns></returns>
    public string GetScienceText()
    {
        return scienceLevels[0];
    }
    public string GetScienceLevel1()
    {
        return scienceLevels[1];
    }
    public string GetScienceLevel2()
    {
        return scienceLevels[2];
    }
    public string GetScienceLevel3()
    {
        return scienceLevels[3];
    }
    /// <summary>
    /// combat getter methods
    /// </summary>
    /// <returns></returns>
    public string GetCombatText()
    {
        return combatLevels[0];
    }
    public string GetCombatLevel1()
    {
        return combatLevels[1];
    }
    public string GetCombatLevel2()
    {
        return combatLevels[2];
    }
    public string GetCombatLevel3()
    {
        return combatLevels[3];
    }

    /// <summary>
    /// engineering getter methods 
    /// </summary>
    /// <returns></returns>
    public string GetEnginText()
    {
        return enginLevels[0];
    }
    public string GetEnginLevel1()
    {
        return enginLevels[1];
    }
    public string GetEnginLevel2()
    {
        return enginLevels[2];
    }
    public string GetEnginLevel3()
    {
        return enginLevels[3];
    }
    //************************************
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
    //changing file so git recognizes it 

}
