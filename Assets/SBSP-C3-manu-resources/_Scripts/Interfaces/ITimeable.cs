using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITimeable{

    void OnStartTimer();
    void OnIncrementTimer();
    void OnFinishTimer();
	
}
