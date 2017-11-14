using UnityEngine;

public class ManuModel
{
    /// <summary>
    /// items that can be manufactured 
    /// </summary>
    private string[] ManufactureBtnText = {"Manufacture", "Produce Rockets For Weapans", "Produce Fuel", "Produce Ammo For Weapons"};

    /// <summary>
    /// setters for manu facture items 
    /// </summary>
    /// <returns></returns>
    public string GetManufactureText()
    {
        return ManufactureBtnText[0];
    }
    public string GetRocketText()
    {
        return ManufactureBtnText[1];
    }
    public string GetFuelText()
    {   
        return ManufactureBtnText[2];
    }
    public string GetAmmoText()
    {
        return ManufactureBtnText[3];
    }


}
