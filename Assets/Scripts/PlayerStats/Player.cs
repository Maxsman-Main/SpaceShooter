using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int money;
    [SerializeField]
    private int fuel;
    [SerializeField]
    private int health;

    public int Money
    {
        get
        {
            return money;
        }
    }
    public int Fuel
    {
        get
        {
            return fuel;
        }
    }
    public int Health
    {
        get
        {
            return health;
        }
    }

    public void UpdateMoney(int money)
    {
        this.money = money;
    }
    public void UpdateFuel(int fuel)
    {
        this.fuel = fuel;
    }
    public void UpdateHealth(int health)
    {
        this.health = health;
    }
}
