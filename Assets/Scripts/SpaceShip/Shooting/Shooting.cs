using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform weaponPosition;

    public void Shoot()
    {
        Instantiate(bullet, weaponPosition.position, weaponPosition.rotation);  
    }
}
