using UnityEngine;
using UnityEngine.UI;

public class WingsFactory : MonoBehaviour
{
    public static Wings MakeSimpleWings(Slider slider)
    {
        return new Wings(slider, 2f, 1f);
    }
}
