using UnityEngine;
using System.Collections;

public class EnemyShipSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject ship;
    [SerializeField]
    private int direction;

    private void Start()
    {
        StartCoroutine(SpawnCicle());
    }

    private void Spawn()
    {
        gameObject.transform.Rotate(ship.transform.forward, RandomizeAngle());
        Instantiate(ship, gameObject.transform.position, gameObject.transform.rotation);
    }

    private float RandomizeAngle()
    {
        var z = Random.Range(0, 360);
        return z;
    }


    private void FixedUpdate()
    {
        
    }
    private IEnumerator SpawnCicle()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(15);
        }
    }
}
