using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Wings
{
    protected Slider slider;
    protected float rotateSpeed;
    protected float rotateSpeedBooster;

    public Wings(Slider slider, float rotateSpeed, float rotateSpeedBooster)
    {
        this.slider = slider;
        this.rotateSpeed = rotateSpeed;
        this.rotateSpeedBooster = rotateSpeedBooster;
    }

    private float MakeRotateForce()
    {
        return -rotateSpeed * rotateSpeedBooster * slider.value;
    }

    private Vector2 MakeDirection(Ship ship)
    {
        var currentRotation = ship.transform.eulerAngles.z * Mathf.Deg2Rad;
        Vector2 currentDirection = new Vector2(Mathf.Cos(currentRotation), -1 * Mathf.Sin(currentRotation));
        return currentDirection;
    }

    public virtual float Rotate(Ship ship, Rigidbody2D rb, float oldRotate)
    {
        var rotate = MakeRotateForce();
        //Debug.Log(rotate + " " + oldRotate);        
        rb.rotation += rotate;
        return rotate;
    }
}
