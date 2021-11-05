using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private Shooting shooting;

    public void Fire()
    {
        shooting.Shoot();   
    }
}
