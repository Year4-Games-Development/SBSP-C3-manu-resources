using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroidManagerView{

    private Button _createNewBayButton;
    private Text _maxBayText;

    private const string MAX_BAY_STRING = "BAY STATUS: ";

    public DroidManagerView(Button button, Text maxBayText)
    {

        _createNewBayButton = button;
        _maxBayText = maxBayText;

    }


    public void SetBayStatus(int current, int max)
    {

        _maxBayText.text = MAX_BAY_STRING + current + "/" + max;

    }

}
