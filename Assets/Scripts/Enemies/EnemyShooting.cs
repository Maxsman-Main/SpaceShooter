using System.Collections;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject ship;
    private float lastAngle = 0;

    public void EnemyShoot()
    {
        StartCoroutine(MakeShoot());
    }

    public void StopEnemyShoot()
    {
        StopAllCoroutines();
    }

    private IEnumerator MakeShoot()
    {
        while (true)
        {
            var angle = MakeDirection();
            if (angle != lastAngle)
            {
                gameObject.transform.rotation = new Quaternion(0, 0, 0, gameObject.transform.rotation.w);
                gameObject.transform.Rotate(gameObject.transform.forward, angle - 90);
                lastAngle = angle;
            }
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
            yield return new WaitForSeconds(3);
        }
    }

    private float MakeDirection()
    {
        return Mathf.Atan2(ship.transform.position.y - gameObject.transform.position.y, ship.transform.position.x - gameObject.transform.position.x) * Mathf.Rad2Deg;
    }
}
