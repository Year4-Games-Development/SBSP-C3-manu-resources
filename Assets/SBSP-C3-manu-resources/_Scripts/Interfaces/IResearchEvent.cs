using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IResearchEvent{

    void OnResearchLearned();
    void SuscribeToResearchEvent(ResearchPanelController controller);
}
