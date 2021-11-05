using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ship : MonoBehaviour
{
    [SerializeField]
    private Slider speedSlider;
    private Engine engine;

    [SerializeField]
    private Slider rotateSlider;
    private Wings wings;

    private Rigidbody2D rb;
    private float oldRotate;
    private Vector2 oldMovement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        engine = EngineFactory.MakeSimpleEngine(speedSlider);
        wings = WingsFactory.MakeSimpleWings(rotateSlider);
        oldRotate = 0;
        oldMovement = new Vector2(0, 0);
    }

    private void FixedUpdate()
    {
        oldMovement = engine.Move(this, rb, oldMovement);
        oldRotate = wings.Rotate(this, rb, oldRotate);
    }
}
