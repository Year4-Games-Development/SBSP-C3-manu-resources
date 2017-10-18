using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchView : MonoBehaviour
{
    /// <summary>
    /// /science upgrades
    /// </summary>
    public Text scienceText;
    public Text scienceTier1;
    public Text scienceTier2;
    public Text scienceTier3;

    /// <summary>
    /// /combat updrades
    /// </summary>
    public Text combatText;
    public Text combatTier1;
    public Text combatTier2;
    public Text combatTier3;
  
    /// <summary>
    /// /engineering updrades
    /// </summary>
    public Text enginText;
    public Text enginTier1;
    public Text enginTier2;
    public Text enginTier3;

    private ResearchController researchController;
    private ResearchModel researchModel;

    void Awake()
    {
        researchController = GetComponent<ResearchController>();
    }

    // Use this for initialization
    void Start ()
    {
        researchModel = researchController.GetResearchModel();
        UpdateViews();
    }

    // Update is called once per frame
    void Update ()
    {
        UpdateViews();
	}
    
    
    private void UpdateViews()
    {
        ///science setters 
        scienceText.text = researchModel.GetscienceText();
        scienceTier1.text = researchModel.GetscienceTier1();
        scienceTier2.text = researchModel.GetscienceTier2();
        scienceTier3.text = researchModel.GetscienceTier3();

        ///combat setters
        combatText.text = researchModel.GetcombatText();
        combatTier1.text = researchModel.GetcombatTier1();
        combatTier2.text = researchModel.GetcombatTier2();
        combatTier3.text = researchModel.GetcombatTier3();

        ///engineering setters
        enginText.text = researchModel.GetenginText();
        enginTier1.text = researchModel.GetenginTier1();
        enginTier2.text = researchModel.GetenginTier2();
        enginTier3.text = researchModel.GetenginTier3();
    }
    
}
