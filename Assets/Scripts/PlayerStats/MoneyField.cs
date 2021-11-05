using UnityEngine;
using UnityEngine.UI;

public class MoneyField : StatField
{
    [SerializeField]
    private Text textField;

    public override void UpdateTextField(int value)
    {
        textField.text = value.ToString();
    }
}
