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
    private RechargeTimer rechargeTimer;

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
        scienceText.text = researchModel.GetScienceText();//text on each branch of the research tree
        scienceLevel1.text = researchModel.GetScienceLevel1();//text on the buttons 
        scienceLevel2.text = researchModel.GetScienceLevel2();//text on the buttons 
        scienceLevel3.text = researchModel.GetScienceLevel3();//text on the buttons 
     

        ///combat setters
        combatText.text = researchModel.GetCombatText();//text on each branch of the research tree
        combatLevel1.text = researchModel.GetCombatLevel1();//text on the buttons 
        combatLevel2.text = researchModel.GetCombatLevel2();//text on the buttons 
        combatLevel3.text = researchModel.GetCombatLevel3();//text on the buttons 

        ///engineering setters
        enginText.text = researchModel.GetEnginText();//text on each branch of the research tree
        enginLevel1.text = researchModel.GetEnginLevel1();//text on the buttons 
        enginLevel2.text = researchModel.GetEnginLevel2();//text on the buttons 
        enginLevel3.text = researchModel.GetEnginLevel3();//text on the buttons 
    }

    //Updates reseachable buttons.
    private void UpdateResearchable()
    {
        //Nested if statements to handle button functionality for science tab in the research tree.
        if (!researchController.scienceLv1.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 100)
            {
                researchController.scienceLv1.GetComponent<Button>().enabled = false;//Button is disabled if prerequisites aren't met.
            }
            else
            {
                researchController.scienceLv1.GetComponent<Button>().enabled = true;//Otherwise the button is enabled and my be clicked.
            }
        }

        if (!researchController.scienceLv2.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 200 || researchModel.GetScienceLvReseachedByIndex(1) == true || researchModel.GetScienceLvReseachedByIndex(0) == false)
            {
                researchController.scienceLv2.GetComponent<Button>().enabled = false;
            }
            else
            {
                researchController.scienceLv2.GetComponent<Button>().enabled = true;
            }
        }

        if (!researchController.scienceLv3.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 300 || researchModel.GetScienceLvReseachedByIndex(2) == true || researchModel.GetScienceLvReseachedByIndex(1) == false)
            {
                researchController.scienceLv3.GetComponent<Button>().enabled = false;
            }
            else
            {
                researchController.scienceLv3.GetComponent<Button>().enabled = true;
            }
        }

        //Nested if statements to handle button functionality for combat tab in the research tree.
        if (!researchController.combatLv1.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 100)
            {
                researchController.combatLv1.GetComponent<Button>().enabled = false;
            }
            else
            {
                researchController.combatLv1.GetComponent<Button>().enabled = true;
            }
        }

        if (!researchController.combatLv2.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 200 || researchModel.GetCombatLvReseachedByIndex(1) == true || researchModel.GetCombatLvReseachedByIndex(0) == false)
            {
                researchController.combatLv2.GetComponent<Button>().enabled = false;
            }
            else
            {
                researchController.combatLv2.GetComponent<Button>().enabled = true;
            }
        }

        if (!researchController.combatLv3.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 300 || researchModel.GetCombatLvReseachedByIndex(2) == true || researchModel.GetCombatLvReseachedByIndex(1) == false)
            {
                researchController.combatLv3.GetComponent<Button>().enabled = false;
            }
            else
            {
                researchController.combatLv3.GetComponent<Button>().enabled = true;
            }
        }

        if (!researchController.enginLv1.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 100)
            {
                researchController.enginLv1.GetComponent<Button>().enabled = false;
            }
            else
            {
                researchController.enginLv1.GetComponent<Button>().enabled = true;
            }
        }

        if (!researchController.enginLv2.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 200 || researchModel.GetEnginLvReseachedByIndex(1) == true || researchModel.GetEnginLvReseachedByIndex(0) == false)
            {
                researchController.enginLv2.GetComponent<Button>().enabled = false;
            }
            else
            {
                researchController.enginLv2.GetComponent<Button>().enabled = true;
            }
        }

        if (!researchController.enginLv3.IsDestroyed())
        {
            if (researchModel.GetIronAmount() < 300 || researchModel.GetEnginLvReseachedByIndex(2) == true || researchModel.GetEnginLvReseachedByIndex(1) == false)
            {
                researchController.enginLv3.GetComponent<Button>().enabled = false;
            }
            else
            {
                researchController.enginLv3.GetComponent<Button>().enabled = true;
            }
        }
    }
    

}
