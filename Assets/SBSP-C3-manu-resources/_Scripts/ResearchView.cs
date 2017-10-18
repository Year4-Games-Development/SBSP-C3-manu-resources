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
   // private RechargeTimer rechargeTimer; not in use till research timer is implemented 

    void Awake()
    {
        researchController = GetComponent<ResearchController>();
    }

    // Use this for initialization
    void Start ()
    {
        researchModel = researchController.GetResearchModel();
        rechargeTimer = researchController.GetRechargeTimer();
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
        //timer needs to be added to each button. (using hover over pop up maybe )
        //material needed needs to be added to the buttons. (using hover over pop up maybe )

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
