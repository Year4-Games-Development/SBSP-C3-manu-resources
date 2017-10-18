
using UnityEngine;

public class ResearchModel
{
    /// <summary>
    /// science branch variables 
    /// </summary>
    private string scienceText = "Science";
    private string scienceTier1 = "Faster Mining Rate";
    private string scienceTier2 = "Larger Droids Area";
    private string scienceTier3 = "Extra Droids";
    /// <summary>
    /// combat branch variables
    /// </summary>
    private string combatText = "Combat";
    private string combatTier1 = "More Damage";
    private string combatTier2 = "Better Shields";
    private string combatTier3 = "More efficient";
    /// <summary>
    /// engineering branch variables
    /// </summary>
    private string enginText = "Engineering";
    private string enginTier1 = "Better engins";
    private string enginTier2 = "Better reactor";
    private string enginTier3 = "Unknown";


    /// <summary>
    /// science getter methods 
    /// </summary>
    /// <returns></returns>
    public string GetscienceText()
    {
        return scienceText;
    }
    public string GetscienceTier1()
    {
        return scienceTier1;
    }
    public string GetscienceTier2()
    {
        return scienceTier2;

    }
    public string GetscienceTier3()
    {
        return scienceTier3;
    }
    /// <summary>
    /// combat getter methods
    /// </summary>
    /// <returns></returns>
    public string GetcombatText()
    {
        return combatText;
    }
    public string GetcombatTier1()
    {
        return combatTier1;
    }
    public string GetcombatTier2()
    {
        return combatTier2;
    }
    public string GetcombatTier3()
    {
        return combatTier3;
    }
    /// <summary>
    /// engineering getter methods 
    /// </summary>
    /// <returns></returns>
    public string GetenginText()
    {
        return enginText;
    }
    public string GetenginTier1()
    {
        return enginTier1;
    }
    public string GetenginTier2()
    {
        return enginTier2;
    }
    public string GetenginTier3()
    {
        return enginTier3;
    }

}
