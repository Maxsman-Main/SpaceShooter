using UnityEngine;
using System.Collections;

public class SpaceBullet : MonoBehaviour
{
    [SerializeField]
    private Ship ship;
    private GameObject playerStats;

    private Rigidbody2D rb;

    private float speed = 200f;
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == ship.name)
        {
            playerStats.GetComponent<Player>().UpdateHealth(playerStats.GetComponent<Player>().Health - damage);
            playerStats.GetComponent<PlayerStatsController>().UpdatePlayerStats();
            playerStats.GetComponent<PlayerStatsController>().CheckHealth();
            DestroySelf();
        }
        if(collision.tag == "Enemy")
        {
            playerStats.GetComponent<Player>().UpdateMoney(playerStats.GetComponent<Player>().Money + collision.GetComponent<EnemyShip>().Money);
            playerStats.GetComponent<PlayerStatsController>().UpdatePlayerStats();
            DestroySelf();
            collision.GetComponent<EnemyShip>().DestroySelf();
        }
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
        playerStats = GameObject.Find("PlayerStats");
        StartCoroutine(LiveTimer());
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }

    public void Move()
    {
        Vector2 movement = new Vector2(speed * MakeDirection().y, speed * MakeDirection().x);
        rb.AddForce(movement);
    }

    public IEnumerator LiveTimer()
    {
        int lifeTime = 0;
        while(lifeTime < 150)
        {
            lifeTime += 1;
            yield return null;
        }
        DestroySelf();
        yield break;
    }
}
