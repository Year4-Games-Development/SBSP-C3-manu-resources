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
    public Text scienceLevel1;
    public Text scienceLevel2;
    public Text scienceLevel3;

    /// <summary>
    /// /combat updrades
    /// </summary>
    public Text combatText;
    public Text combatLevel1;
    public Text combatLevel2;
    public Text combatLevel3;
  
    /// <summary>
    /// /engineering updrades
    /// </summary>
    public Text enginText;
    public Text enginLevel1;
    public Text enginLevel2;
    public Text enginLevel3;

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
        UpdateResearchable();
	}
    
    
    private void UpdateViews()
    {
        ///science setters 
        scienceText.text = researchModel.GetScienceText();
        scienceLevel1.text = researchModel.GetScienceLevel1();
        scienceLevel2.text = researchModel.GetScienceLevel2();
        scienceLevel3.text = researchModel.GetScienceLevel3();

        ///combat setters
        combatText.text = researchModel.GetCombatText();
        combatLevel1.text = researchModel.GetCombatLevel1();
        combatLevel2.text = researchModel.GetCombatLevel2();
        combatLevel3.text = researchModel.GetCombatLevel3();

        ///engineering setters
        enginText.text = researchModel.GetEnginText();
        enginLevel1.text = researchModel.GetEnginLevel1();
        enginLevel2.text = researchModel.GetEnginLevel2();
        enginLevel3.text = researchModel.GetEnginLevel3();
    }

    private void UpdateResearchable()
    {
        if (researchController.ironAmount < 100 || researchController.scienceLv1Researched == true)
        {
            researchController.scienceLv1.GetComponent<Button>().enabled = false;
        }
        else
        {
            researchController.scienceLv1.GetComponent<Button>().enabled = true;
        }

        if (researchController.ironAmount < 200 || researchController.scienceLv2Researched == true || researchController.scienceLv1Researched == false)
        {
            researchController.scienceLv2.GetComponent<Button>().enabled = false;
        }
        else
        {
            researchController.scienceLv2.GetComponent<Button>().enabled = true;
        }

        if (researchController.ironAmount < 300 || researchController.scienceLv3Researched == true || researchController.scienceLv2Researched == false)
        {
            researchController.scienceLv3.GetComponent<Button>().enabled = false;
        }
        else
        {
            researchController.scienceLv3.GetComponent<Button>().enabled = true;
        }
    }
    
}
