using UnityEngine;
using UnityEngine.UI;

public class EngineFactory
{
    public static Engine MakeSimpleEngine(Slider slider)
    {
        return new Engine(slider, 50f, 1f);
    }
}
