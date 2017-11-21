using UnityEngine.UI;

public class ManuModel
{

    private ManuPanelController manuPanelController;
    private ResearchPanelController researchPanelController;
    private Manufacture _manufacture;

    private RechargeTimer _timer;
    private ManuView _view;

    public ManuModel(Text name,Text description, Button button,Text cost)
    {
        _view = new ManuView(name, description, button, cost);
        _timer = new RechargeTimer();
    }

    public void SetManufacture(Manufacture manufacture)
    {
        _manufacture = manufacture;

        _view.SetName(_manufacture.GetName());
        _view.SetDescription(_manufacture.GetDescription());
        _view.SetCost("Cost to Produce: " + _manufacture.GetCost());
    }

    public void SetManufacturePanelController(ManuPanelController controller)
    {
        manuPanelController = controller;
    }

    public ManuView GetManuView()
    {
        return _view;
    }

    public Manufacture GetManufacture()
    {
        return _manufacture;
    }


    public RechargeTimer GetTimer()
    {
        return _timer;
    }
}
