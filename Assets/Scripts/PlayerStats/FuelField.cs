using UnityEngine;
using UnityEngine.UI;

public class FuelField : StatField
{
    [SerializeField]
    private Text fuelText;

    public override void UpdateTextField(int value)
    {
        fuelText.text = value.ToString();
    }
}
