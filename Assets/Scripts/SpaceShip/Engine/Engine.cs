using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Engine
{
    protected Slider slider;
    protected float moveSpeed;
    protected float moveSpeedBooster;

    public Engine(Slider slider, float moveSpeed, float moveSpeedBooster)
    {
        this.slider = slider;
        this.moveSpeed = moveSpeed;
        this.moveSpeedBooster = moveSpeedBooster;
    }

    private float MakeMoveForce() 
    {
        return moveSpeed * moveSpeedBooster * slider.value;
    }

    private Vector2 MakeDirection(Ship ship)
    {
        var currentRotation = ship.transform.eulerAngles.z * Mathf.Deg2Rad;
        Vector2 currentDirection = new Vector2(Mathf.Cos(currentRotation), -1 * Mathf.Sin(currentRotation));
        return currentDirection;
    }

    public virtual Vector2 Move(Ship ship, Rigidbody2D rb, Vector2 oldMovement)
    {
        Vector2 movement = new Vector2(MakeMoveForce() * MakeDirection(ship).y, MakeMoveForce() * MakeDirection(ship).x);
        if (oldMovement != movement)
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
            rb.AddForce(movement);
        }
        return movement;
    }
}   
