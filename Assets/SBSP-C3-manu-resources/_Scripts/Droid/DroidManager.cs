using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroidManager : MonoBehaviour {

    public Button createBayButton;
    public Text maxBayText;
    public GameObject bayPrefab;

    private DroidManagerModel _droidManagerModel;
    private DroidManagerView _droidManagerView;

    void Awake()
    {

        _droidManagerModel = new DroidManagerModel();
        createBayButton.onClick.AddListener(CreateNewBay);
        _droidManagerView = new DroidManagerView(createBayButton,maxBayText);

    }

    void Start()
    {

        _droidManagerView.SetBayStatus(_droidManagerModel.GetCurrentSize(), _droidManagerModel.GetMaxBaySize());

    }

    public void CreateNewBay()
    {

        if (_droidManagerModel.GetCurrentSize() < _droidManagerModel.GetMaxBaySize()) {

            GameObject newBayGameObject = Instantiate(bayPrefab);
            newBayGameObject.transform.SetParent(gameObject.transform);
            newBayGameObject.transform.localScale = new Vector3(1, 1, 1);

            DroidBay newBay = newBayGameObject.GetComponent<DroidBay>();
            newBay.GetDroidBayModel().SetBayIndex(_droidManagerModel.GetCurrentSize());
            newBay.gameObject.name = "DroidBay_" + newBay.GetDroidBayModel().GetBayIndex();

            _droidManagerModel.AddNewBay(newBay);
            _droidManagerModel.SetBaySize(_droidManagerModel.GetCurrentSize() + 1);

        }

    }




}
