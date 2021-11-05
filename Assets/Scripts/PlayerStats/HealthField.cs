using UnityEngine;
using UnityEngine.UI;

public class HealthField : StatField
{

    [SerializeField]
    private Text healthText;

    public override void UpdateTextField(int value)
    {
        healthText.text = value.ToString();
    }
}
