using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuController : MonoBehaviour {

    private ManuModel manuModel;

    // Use this for initialization
    void Awake()
    {
        manuModel = new ManuModel();
    }

    public ManuModel GetManuModel()
    {
        return manuModel;
    }

}
