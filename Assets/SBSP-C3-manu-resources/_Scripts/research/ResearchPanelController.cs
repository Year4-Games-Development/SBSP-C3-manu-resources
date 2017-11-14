using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchPanelController : MonoBehaviour
{
    public GameObject researchPrefab;
    private List<Research> _researches;

    void Awake()
    {
        _researches = new List<Research>();
        _researches.Add(new Research("More Bays", "You can build more bays", AllResearches.More_Bays, 20));
        _researches.Add(new Research("Machineguns", "You can build machineguns", AllResearches.Machinegun, 15));
        _researches.Add(new Research("Rockets", "Learn to make rockets", AllResearches.Rockets, 60));
    }

    void Start()
    {
        //generate UI for each research
        GenerateResearches();
    }

    private void GenerateResearches()
    {
        for (int i = 0; i < _researches.Count; i++)
        {
            GameObject newResearchGameObject = Instantiate(researchPrefab);
            newResearchGameObject.transform.SetParent(gameObject.transform);
            newResearchGameObject.transform.localScale = new Vector3(1, 1, 1);

            ResearchController researchController = newResearchGameObject.GetComponent<ResearchController>();
            researchController.GetResearchModel().SetResearch(_researches[i]);
        }
    }

}
