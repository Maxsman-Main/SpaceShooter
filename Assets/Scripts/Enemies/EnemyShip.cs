using UnityEngine;
using System.Collections;

public class EnemyShip : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private int money;

    private Rigidbody2D rb;

    public int Money
    {
        get
        {
            return money;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DestroyBorder")
        {
            DestroySelf();
        }
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    private Vector2 MakeDirection()
    {
        var currentRotation = gameObject.transform.eulerAngles.z * Mathf.Deg2Rad;
        Vector2 currentDirection = new Vector2(Mathf.Cos(currentRotation), -1 * Mathf.Sin(currentRotation));
        return currentDirection;
    }

    private void OnEnable()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Move();
    }

    private void Move()
    {
        Vector2 movement = new Vector2(speed * MakeDirection().y, speed * MakeDirection().x);
        rb.AddForce(movement);
    }
}
