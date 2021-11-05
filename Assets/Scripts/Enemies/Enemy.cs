using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private GameObject ship;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == ship.name)
        {
            gameObject.GetComponent<EnemyShooting>().EnemyShoot();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name == ship.name)
        {
            gameObject.GetComponent<EnemyShooting>().StopEnemyShoot();  
        }
    }
}