
using UnityEngine;

public class ResearchModel
{
    /// <summary>
    /// science branch variables 
    /// </summary>
    private string scienceText = "Science";
    private string scienceLevel1 = "Faster Mining Rate";
    private string scienceLevel2 = "Larger Droids Area";
    private string scienceLevel3 = "Extra Droids";

  
    /// <summary>
    /// combat branch variables
    /// </summary>
    private string combatText = "Combat";
    private string combatLevel1 = "More Damage";
    private string combatLevel2 = "Better Shields";
    private string combatLevel3 = "More efficient";
    /// <summary>
    /// engineering branch variables
    /// </summary>
    private string enginText = "Engineering";
    private string enginLevel1 = "Better engins";
    private string enginLevel2 = "Better reactor";
    private string enginLevel3 = "Unknown";
    
    /// <summary>
    /// research time for each level 
    /// </summary>
    private float researchTimeLv1 = 10;
    private float researchTimeLv3 = 20;
    private float researchTimeLv2 = 30;


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

    /// <summary>
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

}
