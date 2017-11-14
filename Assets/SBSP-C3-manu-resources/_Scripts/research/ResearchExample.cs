using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResearchExample : MonoBehaviour {

    private List<Research> _researches;

    void Awake()
    {

        _researches = new List<Research>();

        _researches.Add(new Research("More Bays","You can build more bays",AllResearches.More_Bays,10));
        _researches.Add(new Research("Machineguns", "You can build machineguns", AllResearches.Machinegun,10));

    }

    void Start()
    {

        Debug.Log(IsResearchLearned(AllResearches.Machinegun));
        LearnResearch(AllResearches.Machinegun);
        Debug.Log(IsResearchLearned(AllResearches.Machinegun));

    }

    public bool IsResearchLearned(AllResearches research)
    {

        for(int i = 0; i < _researches.Count; i++)
        {

            if(_researches[i].GetResearch() == research)
            {

                if (_researches[i].IsLearned())
                {

                    return true;

                }

                return false;

            }

        }

        return false;

    }

    public bool LearnResearch(AllResearches research)
    {

        for (int i = 0; i < _researches.Count; i++)
        {

            if (_researches[i].GetResearch() == research)
            {

                if (!_researches[i].IsLearned())
                {

                    _researches[i].SetLearned(true);

                }

                return true;

            }

        }

        return false;

    }

	
}
